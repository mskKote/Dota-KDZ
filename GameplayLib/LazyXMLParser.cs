using System.Xml;

namespace GameplayLib
{
    /// <summary>
    /// ####### XML Парсер ########
    /// </summary>
    public static class LazyXMLParser
    {
        //---------------------------------------------------Десереализация
        /// <summary>
        /// Функция получает героя из XML-документа
        /// </summary>
        /// <param name="path">Путь до файла с героем</param>
        /// <returns></returns>
        public static Hero DeserealiseHero(string path)
        {
            var docXml = new XmlDocument();
            docXml.Load(path);
            return new Hero(
                FieldData(docXml, "Name"),
                int.Parse(FieldData(docXml, "Type")),
                double.Parse(FieldData(docXml, "BaseStr")),
                double.Parse(FieldData(docXml, "BaseAgi")),
                double.Parse(FieldData(docXml, "BaseInt")),
                double.Parse(FieldData(docXml, "MoveSpeed")),
                double.Parse(FieldData(docXml, "BaseArmor")),
                double.Parse(FieldData(docXml, "MinDmg")),
                double.Parse(FieldData(docXml, "Regeneration")))
            {
                Health = double.Parse(FieldData(docXml, "Health"))
            };
        }
        /// <summary>
        /// Сокращённая запись для чтения поля.
        /// </summary>
        /// <param name="docXml">Документ с героем</param>
        /// <param name="name">Наименование характеристики</param>
        /// <returns></returns>
        private static string FieldData(XmlDocument docXml, string name)
        {
            return docXml.GetElementsByTagName(name)[0].InnerText;
        }

        //---------------------------------------------------Сереализация
        /// <summary>
        /// Сереализует героя в XML, возвращая 
        /// </summary>
        /// <param name="hero"></param>
        /// <returns></returns>
        public static XmlDocument LazyXmlSerialiser(Hero hero)
        {
            var xmlDoc = new XmlDocument();
            //var heroNode = xmlDoc.CreateNode(XmlNodeType.Document, "Hero", "Hero");
            var heroElement = xmlDoc.CreateElement("Hero");

            heroElement.AppendChild(XmlField(xmlDoc, "Name", hero.Name));
            heroElement.AppendChild(XmlField(xmlDoc, "Type", hero.Type.ToString()));
            heroElement.AppendChild(XmlField(xmlDoc, "BaseStr", hero.BaseStr.ToString()));

            heroElement.AppendChild(XmlField(xmlDoc, "BaseAgi", hero.BaseAgi.ToString()));
            heroElement.AppendChild(XmlField(xmlDoc, "BaseInt", hero.BaseInt.ToString()));
            heroElement.AppendChild(XmlField(xmlDoc, "MoveSpeed", hero.MoveSpeed.ToString()));

            heroElement.AppendChild(XmlField(xmlDoc, "BaseArmor", hero.BaseArmor.ToString()));
            heroElement.AppendChild(XmlField(xmlDoc, "MinDmg", hero.MinDmg.ToString()));
            heroElement.AppendChild(XmlField(xmlDoc, "Regeneration", hero.Regeneration.ToString()));

            heroElement.AppendChild(XmlField(xmlDoc, "Health", hero.Health.ToString()));
            heroElement.AppendChild(XmlField(xmlDoc, "maxHealth", hero.maxHealth.ToString()));

            xmlDoc.AppendChild(heroElement);
            return xmlDoc;
        }
        /// <summary>
        /// Возвращает заполненное поле для Xml.
        /// </summary>
        /// <param name="xmlDoc"></param>
        /// <param name="name"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        private static XmlNode XmlField(XmlDocument xmlDoc, string name, string data)
        {
            //Блок для 1 поля.
            var NameDataElement = xmlDoc.CreateElement(name);
            var someData = xmlDoc.CreateTextNode(name);
            someData.Value = data;
            NameDataElement.AppendChild(someData.Clone());
            return NameDataElement.Clone();
        }
        /// <summary>
        /// Сохраняет героя в Xml-документ.
        /// </summary>
        /// <param name="hero"></param>
        /// <param name="fileName"></param>
        public static void XmlSaver(Hero hero, string fileName)
        {
            XmlDocument xmlDoc = LazyXmlSerialiser(hero);
            xmlDoc.Save($@"..\..\HeroesData\{fileName}.xml");
        }
    }
}

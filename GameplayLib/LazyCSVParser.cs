using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace GameplayLib
{

    /// <summary>
    /// ####### CSV Парсер ########
    /// </summary>
    public static class LazyCSVParser
    {
        /// <summary>
        /// Символ-разделитель, служащий для того, чтобы справиться с экранированием.
        /// </summary>
        static readonly char specSep = '\n';
        /// <summary>
        /// Функция, считывающая героев из файла.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static List<Hero> ParseManager(string path)
        {
            var heroes = new List<Hero>();
            // Герой представляется в CSV ввиде блока строк, 
            // которые его описывают.
            string heroBlock = "";
            bool nextEcranStr = false;

            var lines = ReadAll(path);

            //Проверяем заголовок.
            var buff = lines[0];

            if (!CheckHead(lines[0]))
                throw new FormatException("CSV-парсер не обрабатывает заголовок.\nСообщите \"проверяющему\", что он сломал csv");

            //Нарезаем блоки текста на героев.
            for (int i = 1, kavichkiCounter = 0; i < lines.Count; i++, kavichkiCounter = 0)
            {
                try
                {
                    kavichkiCounter = lines[i].ToList().Count(letter => letter == '"');

                    // С самого начала необходимо проверить, 
                    // не является ли эта строка продолжением предыдущей,
                    // через экранирование.
                    if (nextEcranStr)
                    {
                        heroBlock += specSep + lines[i];
                        if (kavichkiCounter % 2 == 1)
                        {
                            //Экранирование закончилось.
                            //Надо передать heroBlock на обработку.
                            heroes.Add(ReadHero(heroBlock));
                            heroBlock = "";
                            nextEcranStr = false;
                        }
                        continue;
                    }

                    // Если есть в строке экранирование и у нас нечётное количество кавычек, 
                    // то явно мы не ограничиваемся 1 строчкой:
                    if (kavichkiCounter % 2 == 1)
                    {
                        heroBlock += specSep + lines[i];
                        nextEcranStr = true;
                    }
                    else
                    {
                        heroes.Add(ReadHero(lines[i]));
                    }
                }
                catch (Exception)
                {
                    // Ничего не делаем. Если что-то пошло некорректно, то герой не распарсится
                    // Соответственно, добавлять его ко всем героям не следует.
                    // Не будем же мы из-за 1 героя сворачивать парсер.
                }
            }
            //На случай, если экранирование не закрыто, раскидываемся ошибками.
            if (heroBlock != "")
                throw new FormatException("Проверяющий, тебе меня обмануть!\nТы не закрыл экранирование в CSV!!!");

            if (heroes.Count < 2)
                throw new FormatException("Нельзя играть, недостаточно героев. Проверьте CSV");

            return heroes;
        }
        /// <summary>
        /// Читает из файла все строки.
        /// Если возникает ошибка, то обрабатывается наверху.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private static List<string> ReadAll(string path)
        {
            return File.ReadAllLines(path).ToList();
        }

        /// <summary>
        /// Парсим блок с героем в Hero.
        /// </summary>
        /// <param name="heroFields">Блок с героем</param>
        /// <returns></returns>
        private static Hero ReadHero(string heroFields)
        {
            var Fields = new string[9];
            int i = 0;
            bool ecran = false;
            string specForEcran = $"{(char)0}";
            try
            {
                heroFields.Replace("\"\"", specForEcran);
                //Смотрим с учётом экранирования.
                foreach (var letter in heroFields.ToList())
                {
                    // Проверки на экранирование.
                    ecran = letter == '"' && !ecran;// Открытие/закрытие

                    // Дробим про разделителю.
                    if (!ecran && letter == ';')
                    {
                        i++;
                        continue;
                    }

                    Fields[i] += letter == '.' ? ',' : letter;
                }

                if (Fields.Length != 9)
                    throw new Exception("Подозрительные поля у героя. Кину-ка я на этот случай эксепшон");

                return new Hero(Fields[0], int.Parse(Fields[1]), double.Parse(Fields[2]),
                    double.Parse(Fields[3]), double.Parse(Fields[4]), double.Parse(Fields[5]),
                    double.Parse(Fields[6]), double.Parse(Fields[7]), double.Parse(Fields[8]));
            }
            catch (FormatException e)
            { throw new Exception(e.Message); }
            catch (Exception)
            { throw new Exception("Герой не получился. Лютый фейл. А ведь к успеху шёл..."); }
        }
        /// <summary>
        /// Проверяет, можно ли парсить с текущим заголовком.
        /// </summary>
        /// <param name="head">Заголовок CSV</param>
        /// <returns></returns>
        private static bool CheckHead(string head)
            => head == "name;type;baseStr;baseAgi;baseInt;moveSpeed;baseArmor;minDmg;regeneration";
    }
}

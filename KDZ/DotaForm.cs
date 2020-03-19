using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace KDZ
{
    /// <summary>
    /// ####### Главное меню ########
    /// </summary>
    public partial class DotaForm : Form
    {
        /// <summary>
        /// Относительный путь до файла игрока.
        /// </summary>
        private static readonly string UserPath = @"..\..\HeroesData\User.xml";
        /// <summary>
        /// Относительный путь до файла компьютера.
        /// </summary>
        private static readonly string ComputerPath = @"..\..\HeroesData\Computer.xml";
        /// <summary>
        /// Конструктор, в котором инициализируются все переменные
        /// и активируется возможность продолжения игры.
        /// </summary>
        public DotaForm()
        {
            InitializeComponent();
            // При наличии XML-файлов предыдущего сохранения, 
            // label для продолжения игры становится активным.
            if (File.Exists(UserPath) &&
                File.Exists(ComputerPath))
                labelContinue.Enabled = true;
        }
        //---------------------------------------------------Поведение label'ов при наведении
        /// <summary>
        /// Подчёркивает текст при наведении.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Underline_MouseMove(object sender, MouseEventArgs e)
        {
            (sender as Label).Font = new Font((sender as Label).Font, FontStyle.Underline);
            (sender as Label).ForeColor = Color.FromArgb(255, 255, 200);
        }
        /// <summary>
        /// Убирает подчёркивание текста при отводе мыши.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Underline_MouseLeave(object sender, EventArgs e)
        {
            (sender as Label).Font = new Font((sender as Label).Font, FontStyle.Regular);
            (sender as Label).ForeColor = Color.AliceBlue;
        }

        //---------------------------------------------------Логика нажатий на label'ы
        /// <summary>
        /// Выход из приложения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        /// <summary>
        /// Начало новой игры.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelNewGame_Click(object sender, EventArgs e)
        {
            try
            {
                new ChooseHeroForm().ShowDialog();
                if (File.Exists(UserPath) &&
                    File.Exists(ComputerPath))
                    labelContinue.Enabled = true;
            }
            catch (System.Security.XmlSyntaxException ex)
            {
                ErrorHandler("CSV", "Стоило знать, что писари той деревни писать не умеют\n\n" + ex.Message);
            }
            catch (System.Security.SecurityException ex)
            {
                ErrorHandler("CSV", "Данные переписаны на \"Российская Федерация\".\n\n" + ex.Message);
            }
            catch (IOException ex)
            {
                ErrorHandler("CSV", "Дилижанс с героями разбился!\nБерегите себя и своих героев.\n\n" + ex.Message);
            }
            catch (FormatException ex)
            {
                ErrorHandler("CSV", "Данные перепутались, драться в таком состоянии нельзя\n\n" + ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                ErrorHandler("CSV", "Леприконы украли данные из сохранения!\n\n" + ex.Message);
            }
            catch (OverflowException ex)
            {
                ErrorHandler("CSV", "Значения хранились на дискетах и при доставке свалились на героев! Медики бессильны.\n\n" + ex.Message);
            }
            catch (Exception ex)
            {
                ErrorHandler("CSV", "Случилось непредвиденное!\n\n" + ex.Message);
            }
        }
        /// <summary>
        /// Продолжение игры с сохранения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelContinue_Click(object sender, EventArgs e)
        {
            try
            {
                //Здесь читаем персонажей из файлов наших XML файлов.
                new BattleForm(GameplayLib.LazyXMLParser.DeserealiseHero(UserPath),
                               GameplayLib.LazyXMLParser.DeserealiseHero(ComputerPath)
                               ).ShowDialog();
            }
            catch (System.Security.XmlSyntaxException ex)
            {
                ErrorHandler("XML", "Стоило знать, что писари той деревни писать не умеют\n\n" + ex.Message);
            }
            catch (System.Security.SecurityException ex)
            {
                ErrorHandler("XML", "Данные переписаны на \"Российская Федерация\".\n\n" + ex.Message);
            }
            catch (IOException ex)
            {
                ErrorHandler("XML", "Дилижанс с героями разбился!\nБерегите себя и своих героев.\n\n" + ex.Message);
            }
            catch (FormatException ex)
            {
                ErrorHandler("XML", "Данные перепутались, драться в таком состоянии нельзя\n\n" + ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                ErrorHandler("XML", "Леприконы украли данные из сохранения!\n\n" + ex.Message);
            }
            catch (OverflowException ex)
            {
                ErrorHandler("XML", "Значения хранились на дискетах и при доставке свалились на героев! Медики бессильны.\n\n" + ex.Message);
            }
            catch (Exception ex)
            {
                ErrorHandler("XML", "Случилось непредвиденное!\n\n" + ex.Message);
            }
        }
        /// <summary>
        /// Для укороченного описания ошибки.
        /// </summary>
        /// <param name="message">То, что должен узнать пользователь.</param>
        private void ErrorHandler(string format, string message)
        {
            MessageBox.Show(message, $"Битый сейв [{format}]", MessageBoxButtons.OK);
            if (format == "XML")
                labelContinue.Enabled = false;

        }
    }
}

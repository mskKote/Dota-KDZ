using System;
using System.Drawing;
using System.Windows.Forms;

namespace KDZ
{
    /// <summary>
    /// ####### Форма битвы ########
    /// </summary>
    public partial class BattleForm : Form
    {
        /// <summary>
        /// Экземпляр битвы, содержащий логику сражения.
        /// </summary>
        private static GameplayLib.Battle battle;
        /// <summary>
        /// Герой игрока.
        /// </summary>
        private GameplayLib.Hero User;
        /// <summary>
        /// Герой компьютера.
        /// </summary>
        private GameplayLib.Hero Computer;
        /// <summary>
        /// Конструктор, задающий элементы,
        /// интерфейс, битву и героев.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="computer"></param>
        public BattleForm(GameplayLib.Hero user,
                          GameplayLib.Hero computer)
        {
            InitializeComponent();
            User = user;
            Computer = computer;
            battle = new GameplayLib.Battle(user, computer);

            EnemyNameLabel.Text = computer.Name;

            // Используем прогресс-бары
            EnemyHealthProgBar.Maximum = (int)computer.maxHealth;
            UserHealthProgBar.Maximum = (int)user.maxHealth;
            EnemyHealthProgBar.Value = (int)computer.Health;
            UserHealthProgBar.Value = (int)user.Health;
        }

        //--------------------------------------------------- Поведение интерфейса
        /// <summary>
        /// Выход в главное меню.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EXIT_Click(object sender, EventArgs e)
        {
            var XMLSave = MessageBox.Show("Чтобы сохранить игру, нажмите Да\n",
                                          "Выход в главное меню",
                                          MessageBoxButtons.YesNoCancel);

            if (XMLSave != DialogResult.Cancel)
            {
                if (XMLSave == DialogResult.Yes)
                {
                    GameplayLib.LazyXMLParser.XmlSaver(User, "User");
                    GameplayLib.LazyXMLParser.XmlSaver(Computer, "Computer");
                }
                ActiveForm.Close();
            }
        }
        /// <summary>
        /// При наведении на кнопку меняется её стиль.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_MouseMove(object sender, MouseEventArgs e)
        {
            (sender as Button).BackColor = Color.FromArgb(40, 40, 40);
        }
        /// <summary>
        /// При отводе мыши с кнопки 
        /// меняется стиль этой кнопки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_LeaveMove(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Transparent;
        }
        /// <summary>
        /// Переменная для рандома.
        /// </summary>
        private static readonly Random getRnd = new Random();
        //--------------------------------------------------- Логика
        /// <summary>
        /// Действие пользователя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Click(object sender, EventArgs e)
        {
            int decision = getRnd.Next(3);

            EnemyChoiceLabel.Text = "";
            switch (decision)
            {
                case 0:
                    EnemyChoiceLabel.Text = "Run";
                    break;
                case 1:
                    EnemyChoiceLabel.Text = "Defend";
                    break;
                case 2:
                    EnemyChoiceLabel.Text = "Attack";
                    break;
            }

            //Начинаем раунд.
            string resultStr;
            (User, Computer, resultStr) = battle.BattleManager((sender as Button).Text, decision);

            UserHealthProgBar.Value = (int)User.Health >= 0 ? (int)User.Health : 0;
            EnemyHealthProgBar.Value = (int)Computer.Health >= 0 ? (int)Computer.Health : 0;

            if (resultStr != "Continue")
            {
                MessageBox.Show(
                    resultStr == "Victory" ?
                    "Противник повержен. Впереди только слава и богатства!" :
                    "Повезёт в другой раз.\n" +
                    "Совет: всегда атакуйте! Ни шагу назад!\n" +
                    "И никогда не прикрывайтесь тем зонтиком, который на представлен кнопку Defend, - это верная смерть по законам этой игры.",
                    resultStr,
                    MessageBoxButtons.OK);
                ActiveForm.Close();
            }
        }
    }
}
//-----------------атрибуты для проверки.
//heroElement.SetAttribute("Name", hero.Name.ToString());
//heroElement.SetAttribute("Type", hero.Type.ToString());
//heroElement.SetAttribute("BaseStr", hero.BaseStr.ToString());
//heroElement.SetAttribute("BaseAgi", hero.BaseAgi.ToString());
//heroElement.SetAttribute("BaseInt", hero.BaseInt.ToString());
//heroElement.SetAttribute("MoveSpeed", hero.MoveSpeed.ToString());
//heroElement.SetAttribute("BaseArmor", hero.BaseArmor.ToString());
//heroElement.SetAttribute("MinDmg", hero.MinDmg.ToString());
//heroElement.SetAttribute("Regeneration", hero.Regeneration.ToString());
//heroElement.SetAttribute("Health", hero.Health.ToString());
//heroElement.SetAttribute("maxHealth", hero.maxHealth.ToString());
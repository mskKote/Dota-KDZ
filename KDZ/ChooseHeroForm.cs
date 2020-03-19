using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace KDZ
{
    /// <summary>
    /// ####### Форма выбора героя ########
    /// </summary>
    public partial class ChooseHeroForm : Form
    {
        /// <summary>
        /// Список героев из CSV-файла.
        /// </summary>
        private static List<GameplayLib.Hero> heroes;
        /// <summary>
        /// Герой, которого выбрал игрок.
        /// </summary>
        GameplayLib.Hero selectedHero = null;
        /// <summary>
        /// Герой компьютера.
        /// </summary>
        GameplayLib.Hero oppositeHero = null;

        /// <summary>
        /// Адрес CSV-файла.
        /// </summary>
        private static readonly string path = @"..\..\HeroesData\Dota2.csv";

        /// <summary>
        /// Конструктор формы, инициализирующий компоненты
        /// и создающий таблицу.
        /// </summary>
        public ChooseHeroForm()
        {
            InitializeComponent();
            try
            {
                heroes = GameplayLib.LazyCSVParser.ParseManager(path);
                LoadTable(heroes);
            }
            catch (System.IO.IOException e)
            {
                MessageBox.Show("Героев не нашли. \n\n" + e.Message,
                "Uno problemo, CSV dilemo", MessageBoxButtons.OK);
                ActiveForm.Close();
            }
            catch (FormatException e)
            {
                MessageBox.Show("Героев поймали, но, увы! Их слишком мало для драки.\n\n" + e.Message,
                                "Uno problemo, CSV dilemo", MessageBoxButtons.OK);
                ActiveForm.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Героев побили. Драться не хотят. Вы тоже устали и CSV потеряли...\n\n" + e.Message,
                                "Uno problemo, CSV dilemo", MessageBoxButtons.OK);
                ActiveForm.Close();
            }
        }

        //--------------------------------------------------- Поведение интерфейса
        /// <summary>
        /// Метод делает фильтры тусклее.
        /// </summary>
        /// <param name="off"></param>
        private void FiltrationDueOff(bool off)
        {
            FiltrationTitle.ForeColor = off ? Color.Gainsboro : Color.GhostWhite;
            RegenLabel.ForeColor = off ? Color.Gainsboro : Color.GhostWhite;
            MoveLabel.ForeColor = off ? Color.Gainsboro : Color.GhostWhite;
            TypeLabel.ForeColor = off ? Color.Gainsboro : Color.GhostWhite;

            MoveSpeedTB.BackColor = off ? Color.Gainsboro : Color.GhostWhite;
            RegenerationTB.BackColor = off ? Color.Gainsboro : Color.GhostWhite;
            TypeTB.BackColor = off ? Color.Gainsboro : Color.GhostWhite;
        }
        /// <summary>
        /// При наведении на TextBox'ы меняет стиль.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_Move(object sender, MouseEventArgs e)
        {
            FiltrationDueOff(false);
            (sender as TextBox).BackColor = Color.FromArgb(64, 64, 64);
            (sender as TextBox).ForeColor = Color.AliceBlue;
        }
        /// <summary>
        /// При отводе мыши от TextBox'ов меняет стиль.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_Leave(object sender, EventArgs e)
        {
            FiltrationDueOff(false);
            (sender as TextBox).BackColor = Color.GhostWhite;
            (sender as TextBox).ForeColor = Color.Black;
        }
        /// <summary>
        /// При нажатии на TextBox его текст будет обнулён.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TB_Click(object sender, EventArgs e)
        {
            (sender as TextBox).Text = "";
        }


        /// <summary>
        /// При наведении на кнопки меняет стиль.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Move(object sender, MouseEventArgs e)
        {
            (sender as Button).BackColor = Color.FromArgb(64, 64, 64);
        }
        /// <summary>
        /// При отводе мыши от кнопок меняет стиль.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Leave(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Transparent;
        }
        /// <summary>
        /// При наведении на Label'ы меняет стиль.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Label_Move(object sender, MouseEventArgs e)
        {
            FiltrationDueOff(false);
        }

        //---------------------------------------------------Логика
        /// <summary>
        /// Возвращение в главное меню.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EXIT_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        /// <summary>
        /// Переменная для рандома.
        /// </summary>
        private static readonly Random getRnd = new Random();
        /// <summary>
        /// Выбор персонажа из таблицы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeroDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && HeroDataGridView.Columns[e.ColumnIndex].Name == "SelectHero")
            {
                // Игрок
                selectedHero = (HeroDataGridView.Rows[e.RowIndex].DataBoundItem as GameplayLib.Hero);
                // Компьютер
                do
                {
                    oppositeHero = heroes[getRnd.Next(0, heroes.Count)];
                } while (oppositeHero == selectedHero);

                // Вывод результатов
                OpponentHeroLabel.Text = oppositeHero.Name;
                YourHeroLabel.Text = selectedHero.Name;

                OpponentHeroLabel.Visible = true;
                YourHeroLabel.Visible = true;

                OpponentTitle.Visible = true;
                HeroTitle.Visible = true;
                StartBtn.Enabled = true;

                FiltrationDueOff(true);
            }
        }
        /// <summary>
        /// При вводе пользователем некорректных значений, используется этот метод.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeroDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(
                "Попробуй ввести другое значение...\n\n" + e.Exception.Message,
                "С таблицей нужно быть нежнее...",
                MessageBoxButtons.OK);
        }
        /// <summary>
        /// Начало битвы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartBtn_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            new BattleForm(selectedHero, oppositeHero).ShowDialog();
            Close();
        }

        //---------------------------------------------------Таблица
        /// <summary>
        /// Отображение таблицы.
        /// </summary>
        /// <param name="heroes"></param>
        private void LoadTable(List<GameplayLib.Hero> heroes)
        {
            HeroDataGridView.DataSource = heroes;
        }
        /// <summary>
        /// Реализация фильтров.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Filtration(object sender, EventArgs e)
        {
            try
            {
                var regen = double.Parse(string.IsNullOrEmpty(RegenerationTB.Text) ? "0" : RegenerationTB.Text);
                var speed = double.Parse(string.IsNullOrEmpty(MoveSpeedTB.Text) ? "0" : MoveSpeedTB.Text);
                var type = double.Parse(string.IsNullOrEmpty(TypeTB.Text) ? "0" : TypeTB.Text);
                (sender as TextBox).BackColor = Color.GhostWhite;

                if (RegenerationTB.Enabled)
                {
                    LoadTable(heroes.Where(hero =>
                    hero.Regeneration >= regen
                    && hero.MoveSpeed >= speed
                    && hero.Type >= type).ToList());
                }
            }
            catch (FormatException)
            {
                if ((sender as TextBox).Text != "")
                {
                    (sender as TextBox).BackColor = Color.Firebrick;
                    //    MessageBox.Show("Необходимо вводить числа.", "Некорректный ввод", MessageBoxButtons.OK)
                }
            }
        }
    }
}

using System;

namespace GameplayLib
{
    /// <summary>
    /// ####### Логика сражения ########
    /// </summary>
    public class Battle
    {
        /* Цитата из таблицы: "Мы не на геймдизайне"
         поэтому справедливо ли оценивать качество кода в этом месте?

         Как говорится: "Без внятного ТЗ - результат ХЗ".*/

        /// <summary>
        /// Переменная для вычисления атаки компьютера.
        /// </summary>
        private static double ComputerAttack;
        /// <summary>
        /// Переменная для вычисления атаки игрока.
        /// </summary>
        private static double UserAttack;

        /// <summary>
        /// Герой игрока.
        /// </summary>
        private static Hero User;
        /// <summary>
        /// Герой компьютера.
        /// </summary>
        private static Hero Computer;
        /// <summary>
        /// Конструктор, в котором мы импортируем героев для битвы 
        /// и рассчитываем параметры битвы.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="computer"></param>
        public Battle(Hero user,
                      Hero computer)
        {
            User = user;
            UserAttack = user.MinDmg * user.BaseStr / 10 + user.BaseArmor * user.BaseAgi / 10;

            Computer = computer;
            ComputerAttack = computer.MinDmg * computer.BaseStr / 10 + computer.BaseArmor * computer.BaseAgi / 10;
        }
        /// <summary>
        /// Логика битвы.
        /// </summary>
        /// <param name="action">Действие пользователя</param>
        /// <param name="EnemyChoice">Действие противника</param>
        /// <returns>Возвращаем состояние раунда</returns>
        public (Hero, Hero, string) BattleManager(string action, int EnemyChoice)
        {
            switch (EnemyChoice)
            {
                case 0://Противник бежит.
                    Run(action);
                    break;
                case 1://Противник защищается.
                    Defend(action);
                    break;
                case 2://Противник атакует.
                    Attack(action);
                    break;
            }

            //Отправляем состояние игроков и исход раунда.
            return (User, Computer,
                    User.Health <= 0 ? "Defeat" :
                Computer.Health <= 0 ? "Victory" :
                "Continue");
        }

        //-----------------------------Убегать, защищаться, атаковать
        /// <summary>
        /// Бегство.
        /// </summary>
        /// <param name="userAction"></param>
        private static void Run(string userAction)
        {
            if (userAction == "Run")
            {
                RegenLogic(User);
                RegenLogic(Computer);
                return;
            }
            RunLogic(Computer);
        }
        /// <summary>
        /// Защита.
        /// </summary>
        /// <param name="userAction"></param>
        private static void Defend(string userAction)
        {
            if (userAction == "Defend")
                return;
            else if (userAction == "Run")
                RunLogic(User);
            else
                DamageLogic(User, Computer);
        }
        /// <summary>
        /// Атака.
        /// </summary>
        /// <param name="userAction"></param>
        private static void Attack(string userAction)
        {
            if (userAction == "Defend")
                DamageLogic(Computer, User);
            else if (userAction == "Run")
                RunLogic(User);
            else
                DamageLogic(UserAttack >= ComputerAttack ? User : Computer, //Attacker
                            UserAttack >= ComputerAttack ? Computer : User);//Defender
        }


        //-----------------------------Основные взаимодействия между героями.
        /// <summary>
        /// Логика регенерации.
        /// </summary>
        /// <param name="hero"></param>
        private static void RegenLogic(Hero hero)
        {
            hero.Health += Chance(0.2) ? 5 * hero.Regeneration : 0;
        }
        /// <summary>
        /// Логика отступления.
        /// </summary>
        /// <param name="hero"></param>
        private static void RunLogic(Hero hero)
        {
            // Это значит, что рождённый бегать..
            hero.Health = hero.Health - hero.maxHealth * 0.01 > 2 ?
                          hero.Health - hero.maxHealth * 0.01 : 2;//Бред же...
        }
        /// <summary>
        /// Логика нанесения урона.
        /// </summary>
        /// <param name="Attacker"></param>
        /// <param name="Defender"></param>
        private static void DamageLogic(Hero Attacker, Hero Defender)
        {
            Defender.Health -= Attacker.MinDmg * Attacker.BaseStr / 20;
        }

        /// <summary>
        /// Генератор случайных чисел.
        /// </summary>
        private static Random getRnd = new Random();
        /// <summary>
        /// Рассчёт вероятности внутриигровых событий.
        /// </summary>
        /// <param name="chance"> От [0, до 1) </param>
        /// <returns></returns>
        private static bool Chance(double chance)
        {
            return chance > getRnd.NextDouble();
        }
        /*
         Этапы битвы:
         1. Герои делают свой ход.
         2. Герои по очереди дают друг другу звиздюлей, а могут убежать итд.
         3. В конце каждого хода идёт проверка на смерть. Если хоть кто-то жив, то заново на 1-й пункт.
         4.1 Битва заканчивается, сообщение выводится и игрока выбрасывает в главное меню.
         4.2 При нажатии кнопки Menu --> "Да", запускается XML парсер, который сохранит все данные раунда:
             Объект User и Computer в 2-х разных файлах. 
         */
    }
}

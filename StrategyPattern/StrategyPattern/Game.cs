using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Weapons;

namespace StrategyPattern
{
    public class Game
    {
        public Player _player { get; private set; }
        public Game(Player player)
        {
            _player = player;
        }
        public void Start()
        {
            string gameString = "Выбор оружия:\n1) Меч\n2) Лук\n3) Топор\nВыбор: ";
            string choice = " ";
            while (choice != string.Empty)
            {
                Console.WriteLine(gameString);
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        _player.SetWeapon(new Sword());
                        break;
                    case "2":
                        _player.SetWeapon(new Bow());
                        break;
                    case "3":
                        _player.SetWeapon(new Axe());
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Установлено оружие по умолчанию (Меч).");
                        _player.SetWeapon(new Sword());
                        break;
                }
                _player.Attack();
                Console.WriteLine();
            }
        }
    }
}

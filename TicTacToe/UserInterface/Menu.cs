using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Auxiliary;
using TicTacToe.GameLogic;
namespace TicTacToe.UserInterface
{
    public class Menu
    {
        /// <summary>
        /// Метод для ориентирования в меню
        /// </summary>
        public static void MenuGreetings()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Доступные команды:\n" +
                "1. ’start’ (или ‘s’) - Запустить игру.\n" +
                "2. ‘help’ (или ‘h’) - Правила игры.\n" +
                "3. ‘quit’ (или ‘q’) - Выйти из игры.");
            InputTextOption(); //Вызов метода для ввода текста
        }
        /// <summary>
        /// Метод позволяющий ввести текст с консоли. 
        /// Полученный текст переводит в нижний регист, убирая пробелы и табуляцию
        /// Необходим для перехода в меню
        /// </summary>
        public static void InputTextOption()
        {
            Console.ForegroundColor= ConsoleColor.White;
            string inputNavigation = Console.ReadLine(); 
            inputNavigation = inputNavigation.ToLower().Replace(" ", "").Replace("\t", ""); 
            ExecuteMenu(inputNavigation); //Переходим в Меню
        }
        /// <summary>
        /// Получаем текст из метода "InputTextOption и сравниваем его с текстом
        /// </summary>
        public static void ExecuteMenu(string inputNavigation) 
        {
            if (inputNavigation == "start" || inputNavigation == "s")
            {
                PlayingField.CreateNewPlayingField();  //Метод создающий поле
            }
            else if (inputNavigation == "help" || inputNavigation == "h")
            {
                Console.Clear();
                InstructionsGame.Instruction(false); //Метод для вызова правил
            }
            else if (inputNavigation == "quit" || inputNavigation == "q")
            {
                Console.WriteLine("Bye!");
                Environment.Exit(0); //Выход с программы
            }
            else 
            {
                Console.WriteLine("Неправильный ввод, повторите попытку.");
                InputTextOption();
            }
        }
    }
}


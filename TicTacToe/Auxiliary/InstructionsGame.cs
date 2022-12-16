using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.UserInterface;

namespace TicTacToe.Auxiliary
{
    public class InstructionsGame
    {
        /// <summary>
        /// Метод хранящий в себе правила игры
        /// </summary>
        public static void Instruction(bool status)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Правила игры: \n" +
                "Игроки по очереди ставят на свободные клетки поля 3 на 3 знаки " +
                "(один всегда крестики, другой всегда нолики).\nПервый, " +
                "выстроивший в ряд 3 своих фигуры по вертикали, горизонтали или диагонали, " +
                "выигрывает.\nДля выбора клетки впишите 2 значения:\nНомер строки;\nНомер столбца.\n" +
                "Например: Если пользователь хочет поставить крестик на середину поля,\n" +
                "то он вводит “2 2” - второй ряд и вторая колонка.\n" +
                "В игре можно вызвать правила или выйти из игры, для этого не обходимо \n" +
                "ввести ‘help’ (или ‘h’), ‘quit’ (или ‘q’).");
            if (status == false) //status = false --> "Правила" открытые в меню
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Пожалуйства, введите следующую команду:");
                Menu.InputTextOption(); //Возвращаемся в метод для ввода пользователя
            }
        }
    }
}

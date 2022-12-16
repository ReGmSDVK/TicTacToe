using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.GameLogic
{
    public class PlayingField
    {
        public static string[,] field; //Поле
        public static bool turn = true; //очередность, true - User | false = Computer
        /// <summary>
        /// Метод позволяющий нарисовать новое поле
        /// </summary>
        public static void CreateNewPlayingField()
        {
            turn = true;
            Console.Clear();
            Console.WriteLine("Удачи!");
            field = new string[3, 3] //Стартовый вид поля
            {
                { "*", "*", "*" },
                { "*", "*", "*" },
                { "*", "*", "*" },
            };
            PlayingFieldPrint(field); //Выводим поле на экран
        }
        /// <summary>
        /// Метод рисующий поле
        /// </summary>
        public static void PlayingFieldPrint(string[,] field)
        {
            Console.WriteLine("Текущее состояние поля:");
            for (int xCoordinateIndex = 0; xCoordinateIndex < field.GetLength(0); xCoordinateIndex++)
            {
                for (int yCoordinateIndex = 0; yCoordinateIndex < field.GetLength(1); yCoordinateIndex++)
                {
                    Console.Write($"{field[xCoordinateIndex, yCoordinateIndex]} ");
                }
                Console.WriteLine();
            }
            if (turn == true) //Очередь пользователя
                UserLogic.UserInput();
            if (turn == false) //Очередь компьютера
            {
                Console.WriteLine("Компьютер думает...");
                ComputerLogic.ComputerInput();
            }         
        }
        /// <summary>
        /// Метод изменяющий очередность
        /// </summary>
        public static void PlayerTurn()
        {
            turn = !turn;
        }
    }
}

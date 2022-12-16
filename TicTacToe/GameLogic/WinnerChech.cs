using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.UserInterface;

namespace TicTacToe.GameLogic
{
    /// <summary>
    /// Проверка победиля 
    /// </summary>
    public class WinnerChech
    {
        public static string[] fieldCheck = new string[9] { "*", "*", "*", "*", "*", "*", "*", "*", "*"};
        /// <summary>
        /// Метод конвертирующий двумерный массив в одномерный
        /// </summary>
        public static void ConvertArray() 
        {
            
            int indexBox = 0;
            for (int xCoordinate = 0; xCoordinate < PlayingField.field.GetLength(0); xCoordinate++)
            {
                for (int yCoordinate = 0; yCoordinate < PlayingField.field.GetLength(1); yCoordinate++)
                {
                    fieldCheck[indexBox] = PlayingField.field[xCoordinate, yCoordinate];
                    indexBox++;
                }
            }
            CheckFieldUser(fieldCheck); //Вызываем метод проверки победителя
        }
        /// <summary>
        /// Метод проверяет комбинации символов 
        /// </summary>
        public static void CheckFieldUser(string[] fieldCheck)
        {
            if(true)
            {
                if (fieldCheck[0] == "X" && fieldCheck[1] == "X" && fieldCheck[2] == "X" ||
                    fieldCheck[3] == "X" && fieldCheck[4] == "X" && fieldCheck[5] == "X" ||
                    fieldCheck[6] == "X" && fieldCheck[7] == "X" && fieldCheck[8] == "X" ||
                    fieldCheck[0] == "X" && fieldCheck[3] == "X" && fieldCheck[6] == "X" ||
                    fieldCheck[1] == "X" && fieldCheck[4] == "X" && fieldCheck[7] == "X" ||
                    fieldCheck[2] == "X" && fieldCheck[5] == "X" && fieldCheck[8] == "X" ||
                    fieldCheck[0] == "X" && fieldCheck[4] == "X" && fieldCheck[8] == "X" ||
                    fieldCheck[2] == "X" && fieldCheck[4] == "X" && fieldCheck[6] == "X")
                {
                    Console.WriteLine("Победа! Сыграем еще раз?");
                    Menu.MenuGreetings(); //Переходит в меню
                }
                else if (fieldCheck[0] == "0" && fieldCheck[1] == "0" && fieldCheck[2] == "0" ||
                    fieldCheck[3] == "0" && fieldCheck[4] == "0" && fieldCheck[5] == "0" ||
                    fieldCheck[6] == "0" && fieldCheck[7] == "0" && fieldCheck[8] == "0" ||
                    fieldCheck[0] == "0" && fieldCheck[3] == "0" && fieldCheck[6] == "0" ||
                    fieldCheck[1] == "0" && fieldCheck[4] == "0" && fieldCheck[7] == "0" ||
                    fieldCheck[2] == "0" && fieldCheck[5] == "0" && fieldCheck[8] == "0" ||
                    fieldCheck[0] == "0" && fieldCheck[4] == "0" && fieldCheck[8] == "0" ||
                    fieldCheck[2] == "0" && fieldCheck[4] == "0" && fieldCheck[6] == "0")
                {
                    Console.WriteLine("Вы проиграли, повезет в следующий раз!");
                    Menu.MenuGreetings(); //Переходит в меню
                }
                else
                {
                    fieldCheck[0] = "z";
                    FreeFields(fieldCheck); //Проверка на свободные ячейки
                }
            }
            
        }
        /// <summary>
        /// Метод для проверки на свободные ячейки
        /// </summary>
        public static void FreeFields(string[] fieldCheck)
        {
            if (fieldCheck.Contains("*"))
            {
                PlayingField.PlayingFieldPrint(PlayingField.field); //Обновляет поле
            }
            else
            {
                Console.WriteLine("Ничья, попробуйте еще раз.");
                Menu.MenuGreetings(); //Переходит в меню
            }
        }
    }
}

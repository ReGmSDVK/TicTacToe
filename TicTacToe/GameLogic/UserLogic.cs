using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Auxiliary;
namespace TicTacToe.GameLogic
{
    /// <summary>
    /// Пользователь
    /// </summary>
    public class UserLogic
    {
        /// <summary>
        /// Ввод пользователя координат или одной из доступных команд.
        /// </summary>
        public static void UserInput()
        {
            int num;
            int[] coordinate = new int[2];
            string[] inputNumber;
            bool isOkayNum1 = false;
            bool isOkayNum2 = false;
            Console.WriteLine("Пожалуйста, введите индекс ячейки, в которую вы хотите поставить крестик:");
            while (!isOkayNum1 && !isOkayNum2)
            {
                var input = Console.ReadLine();
                if (input == "help" || input == "h")
                {
                    InstructionsGame.Instruction(true); //Метод для вызова правил
                    continue;
                }
                if (input == "quit" || input == "q")
                {
                    Console.WriteLine("Пока!");
                    Environment.Exit(0); //Метод для вызова правил

                }
                
                inputNumber = input.Split(" ");
                
                if (inputNumber.Length == 2) //Проверка правильности ввода пользователя
                {
                    isOkayNum1 = int.TryParse(inputNumber[0], out num);
                    if (isOkayNum1)
                        coordinate[0] = num - 1;
                    isOkayNum2 = int.TryParse(inputNumber[1], out num);
                    if (isOkayNum2)
                        coordinate[1] = num - 1;

                }

                if (!isOkayNum1 && !isOkayNum2)
                {
                    Console.WriteLine("Ты ввел не правильно:");
                }
            }
            FieldUpdateUser(coordinate); 
        }
        /// <summary>
        ///  Метод для изменения поля, ход Пользователя 
        /// </summary>
        public static void FieldUpdateUser(int[] coordinate)
        {
            int xCoordinate = coordinate[0];
            int yCoordinate = coordinate[1];
            try
            {
                if (PlayingField.field[xCoordinate, yCoordinate] == "*")
                {
                    PlayingField.field[xCoordinate, yCoordinate] = "X";
                    Console.Clear();
                    PlayingField.PlayerTurn(); //Меняем очередность
                    WinnerChech.ConvertArray(); //Проверяем поле на победителя или свободные ячейки 
                }
                else if (PlayingField.field[xCoordinate, yCoordinate] == "X" || PlayingField.field[xCoordinate, yCoordinate] == "0")
                {
                    Console.WriteLine("Клетка уже занята, попробуйте еще:");
                    UserInput(); //Просим пользователя ввести еще раз
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Вы вышли за границы поля:");
                UserInput();
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка");
                UserInput();
            }
        }
    }
}

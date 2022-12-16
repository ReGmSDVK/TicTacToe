using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.GameLogic
{
    /// <summary>
    /// Компьютер генерирует случайное число с задержкой в 0.5 сек
    /// Если клетка занята, компьютер генерирует число заново, с задержкой 0.5 сек. 
    /// По итогу ход компьютера занимает рандомное кол-во времени.
    /// </summary>
    public class ComputerLogic
    {
        /// <summary>
        /// Ассинхронный метод 
        /// </summary>
        public async static void ComputerInput()
        {
            ComputerInputAsync(true);
        }
        public async static void ComputerInputAsync(bool expectation)
        {
            // Лямбда, генерирует 2-е рандомные координаты, задержка 0.5 сек.
            var delay = Task.Run(async () => {
                Random randomNumber = new Random();
                int[] coordinate = new int[2];
                if (expectation == true)
                    await Task.Delay(1000);
                coordinate[0] = randomNumber.Next(0, 3);
                coordinate[1] = randomNumber.Next(0, 3);
                return coordinate;
            });
            var coordinate = delay.Result;
            FieldUpdateComputer(coordinate);
        }
        /// <summary>
        /// Метод для изменения поля, ход Пользователя 
        /// </summary>
        public static void FieldUpdateComputer(int[] coordinate)
        {
            int xCoordinate = coordinate[0];
            int yCoordinate = coordinate[1];
            if (PlayingField.field[xCoordinate, yCoordinate] == "*")
            {
                PlayingField.field[xCoordinate, yCoordinate] = "0";
                Console.Clear();
                PlayingField.PlayerTurn(); //Меняем очередность
                WinnerChech.ConvertArray(); //Проверяем поле на победителя или свободные ячейки 
            }
            else if (PlayingField.field[xCoordinate, yCoordinate] == "X" || PlayingField.field[xCoordinate, yCoordinate] == "0")
            {
                ComputerInput(); //Просим компьтер сгенерировать заново
            }
        }
    }
}

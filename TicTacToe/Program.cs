using System;
using TicTacToe.UserInterface;
using TicTacToe.GameLogic;
namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в игру Крестики-Нолики.");
            Menu.MenuGreetings(); //Вызываем метод "инструкцию к меню"
        }
    }
}

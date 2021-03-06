﻿using CBFitness.BL.Controller;
using System;

namespace CBFitness.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует ClearBreakFitness");

            Console.WriteLine("Введите имя пользователя");
            var name = Console.ReadLine();

            Console.WriteLine("Введите пол  пользователя");
            var gender = Console.ReadLine();

            Console.WriteLine("Введите дату рождения пользователя");
            var birthdate = DateTime.Parse(Console.ReadLine()) ;

            Console.WriteLine("Введите вес пользователя");
            var weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите рост пользователя");
            var height = double.Parse(Console.ReadLine());
            
            var userController = new UserController(name, gender, birthdate, weight, height);
            userController.Save();

        }
    }
}

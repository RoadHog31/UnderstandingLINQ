﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace UnderstandingLINQ
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>()
            {
                new Car() { Make = "BMW", Model= "550i", CarColor=CarColor.Blue, StickerPrice=55000, Year=2009 },
                new Car() { Make="Toyota", Model="4Runner", CarColor=CarColor.White, StickerPrice=35000, Year=2010 },
                new Car() { Make="BMW", Model = "745li", CarColor=CarColor.Black, StickerPrice=75000, Year=2008 },
                new Car() { Make="Ford", Model="Escape", CarColor=CarColor.White, StickerPrice=25000, Year=2008 },
                new Car() { Make="BMW", Model="55i", CarColor=CarColor.Black, StickerPrice=57000, Year=2010 }
            };

            /*var bmws = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2010
                       select new { car.Make, car.Model, car.Year }; */

            var orderedCars = from car in myCars
                              orderby car.Year descending
                              select car;

            foreach (var car in orderedCars)
            Console.WriteLine("{0} - {1} - {2}", car.Make, car.Model, car.Year);
            Console.ReadLine();
        }
    }

    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
        public CarColor CarColor { get; set; }
    }

    public enum CarColor
    {
        White,
        Black,
        Red,
        Blue,
        Yellow
    }

}

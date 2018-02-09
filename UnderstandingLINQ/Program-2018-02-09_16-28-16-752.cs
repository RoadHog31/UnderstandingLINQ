﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>() {
                new Car() { Make = "BMW", Model= "550i", carColor=CarColor.Blue, StickerPrice=55000, Year=2009},
                new Car() { Make="Toyota", Model="4Runner", carColor=CarColor.White, StickerPrice=35000, Year=2010},
                new Car() { Make="BMW", Model = "745li", carColor=CarColor.Black, StickerPrice=75000, Year=2008},
                new Car() {Make="Ford", Model="Escape", carColor=CarColor.White, StickerPrice=25000, Year=2008},
                new Car() {Make="BMW", Model="55i", carColor=CarColor.Black, StickerPrice=57000, Year=2010}
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
        public CarColor carColor { get; set; }
    }

    enum CarColor
    {
        White,
        Black,
        Red,
        Blue,
        Yellow
    }

}

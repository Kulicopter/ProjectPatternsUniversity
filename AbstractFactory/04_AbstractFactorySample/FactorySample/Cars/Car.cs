﻿using System;
using FactorySample.Parts;

namespace FactorySample.Cars
{
    public abstract class Car
    {
        protected string Name = "";
        protected string Body = "Caravan";

        protected Engine Engine;
        protected Paint PaintColor;
        protected Wheels Wheels;

        public abstract void Configure();

        public void AssembleBody()
        {
            Console.WriteLine("Body is assembled");
        }

        public void InstallEngine()
        {
            Console.WriteLine("Engine is in its place");
        }

        public void Paint()
        {
            Console.WriteLine("Car is painted");
        }

        public void InstallWheels()
        {
            Console.WriteLine("Wheels are installed");
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Elephant : FarmAnimal, ISellable
    {
        decimal _price;
        public decimal Price { 
            get
            {
                return _price;
            }
       }

        //decimal ISellable.Price => throw new NotImplementedException();



        public Elephant() : base("ELEPHANT")
        {
            _price = 5000.50M; 
        }

        public override string MakeAwakeSoundOnce()
        {
            return "TRUMPET";
        }

        public override string MakeAwakeSoundTwice()
        {
            return "TRUMPET TRUMPET";
        }

        public override string eat()
        {
            return "yummy";
        }
    }
}

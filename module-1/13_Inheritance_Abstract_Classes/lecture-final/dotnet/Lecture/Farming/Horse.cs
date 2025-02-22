﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Horse : FarmAnimal
    {
        /// <summary>
        /// Creates a new horse.
        /// </summary>
        /// <param name="name">The name which the horse goes by.</param>
        public Horse() : base("HORSE")
        {
        }

        public override string eat()
        {
            return "crunch";
        }

        /// <summary>
        /// The single noise the horse makes.
        /// </summary>
        /// <returns></returns>
        public override string MakeAwakeSoundOnce()
        {
            return "NEIGH";
        }

        /// <summary>
        /// The double noise the horse makes.
        /// </summary>
        /// <returns></returns>
        public override string MakeAwakeSoundTwice()
        {
            return "NEIGH NEIGH";
        }
    }
}

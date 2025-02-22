﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Tractor : ISingable
    {
        public string Type { get; } = "TRACTOR";

        public string MakeSoundOnce()
        {
            return "VROOM";
        }

        public string MakeSoundTwice()
        {
            return "VROOM VROOM";
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture
{
    public partial class LectureExample
    {

        /*
        14. Write an if statement that checks 
            if the parameter number is either equal to or greater than 18. 
            Return "Adult" if it is or "Minor" if it's not.
            Topic: Comparison Operators
        */
        public string ReturnAdultOrMinor(int number)
        {
            if (number >= 18)
            {
                return "Adult";
            }
            else //if (number<18) redundant and gives me an error
            {
                return "Minor";
            }
        }
    }
}

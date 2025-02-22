﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lecture.Aids
{
    public static class SummingUpNumbers
    {
        public static void ReadFile()
        {
            // Reading in a file of numbers
            string folder = Environment.CurrentDirectory;
            string filename = "numbers.txt";
            // get the full path
            string fullpath = Path.Combine(folder, filename);

            int sum = 0;
            try
            {               
                using (StreamReader sr = new StreamReader(fullpath))
                {
                    // Read until we get to the end of the file
                    while (!sr.EndOfStream)
                    {
                        // Read the line
                        string line = sr.ReadLine();

                        // Convert to a number
                        int number = 0;
                        try
                        {
                            number = int.Parse(line); //System.FormatException
                        }
                        catch (System.FormatException e)
                        {
                            Console.WriteLine("Skipping " + line);
                        }

                        // Add to Sum
                        sum += number;
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.GetType() + " encountered " + e.Message);
            }
            
            Console.WriteLine("The sum is " + sum);
        }
    }
}

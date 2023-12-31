﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2D Arrays");
            Console.WriteLine();

            char[,] emoticon; // declaration
            emoticon = new char[5, 5]; // instantiation 3x3

            //initialization
            emoticon[2, 0] = '*';
            emoticon[1, 1] = '*';
            emoticon[3, 1] = '*';
            emoticon[0, 2] = '*';
            emoticon[4, 2] = '*';
            emoticon[1, 3] = '*';
            emoticon[3, 3] = '*';
            emoticon[2, 4] = '*';


            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    Console.Write(emoticon[x, y]);
                }
                Console.WriteLine() ;
            }
            
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}

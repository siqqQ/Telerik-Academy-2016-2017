﻿using System;

namespace TelerikPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)
            {
                if ((i + 2) % 2 == 0)
                {
                    Console.WriteLine(i + 2);
                }
                else
                {
                    Console.WriteLine(-(i + 2));
                }
            }
        }
    }
}

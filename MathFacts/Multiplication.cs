﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFacts
{
    class Multiplication
    {

        public void MultiplicationTitle()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            string appTitle = @"    _____        .__   __  .__       .__  .__               __  .__                ___________     ___.   .__          
   /     \  __ __|  |_/  |_|__|_____ |  | |__| ____ _____ _/  |_|__| ____   ____   \__    ___/____ \_ |__ |  |   ____  
  /  \ /  \|  |  \  |\   __\  \____ \|  | |  |/ ___\\__  \\   __\  |/  _ \ /    \    |    |  \__  \ | __ \|  | _/ __ \ 
 /    Y    \  |  /  |_|  | |  |  |_> >  |_|  \  \___ / __ \|  | |  (  <_> )   |  \   |    |   / __ \| \_\ \  |_\  ___/ 
 \____|__  /____/|____/__| |__|   __/|____/__|\___  >____  /__| |__|\____/|___|  /   |____|  (____  /___  /____/\___  >
         \/                   |__|                \/     \/                    \/                 \/    \/          \/ ";

            Console.WriteLine(appTitle);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You will be able to select a starting number and an ending Number between 1 and 10");
            Console.WriteLine("Next you will see the bumbers between these selections be multiplied");
            Console.WriteLine("to numbers 1 - 10");
            Console.WriteLine("");
            Console.WriteLine("Select a starting number between 1 and 10");
        }

        public void MultiplicationTitle(int startNum, int endNum)
        {
            //TODO = build out the logic of the addition table
            for (int i = startNum - 1; i <= endNum; i++)
            {
                if (i == startNum - 1)
                {
                    Console.Write(String.Format("{0, 6}", "n"));
                }
                else
                {
                    Console.Write(String.Format("{0,6}", i));
                }

            }

            Console.WriteLine("\n");


            for (int i = 1; i <= 10; i++)
            {
                Console.Write(String.Format("{0, 6}", i));
                for (int b = startNum; b <= endNum; b++)
                {
                    string output = String.Format("{0, 6}", i * b);
                    Console.Write(output);
                }
                Console.WriteLine("");
            }


        }

    }
}

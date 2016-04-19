﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIMEngine.Core.PlayerSetup
{
    public class PlayerStats
    {
                            
        public static int[] rollStats()
        {

            int[] test = new int[6];

            //todo wtf is a list
            //List<int> test2 = new List<int>();


            for (int i = 0; i <= 6; i++)
            {
                var result = dice(3, 6);
                test[i] = result;
            }


            return test;
        }

        public static int dice(int number, int size)
        {
            int sum = 0;
            Random dice = new Random((int)DateTime.Now.Ticks);

            for (int i = 0; i < number; i++)
            {
                sum += dice.Next(1, size);
            }

            return sum;
        }
    }
}
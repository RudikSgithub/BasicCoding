﻿using System;

namespace Solution.IZ04_01_InsertNumber
{
    static public class Number
    {
        static public int Insert(int numberSource, int numberIn, int i, int j)
        {
            const int indexLast = 31;

            if (i > j ||
                i < 0 || j < 0 ||
                i > indexLast || j > indexLast) throw new ArgumentException("i > j or negative i,j or outbound bit");

            int mask;
            if (indexLast == j)
            {
                mask = 0 | ((1 << i) - 1);
            }
            else
            {
                mask = (~0 << j + 1) | ((1 << i) - 1);
            }

            return numberSource & mask | (numberIn << i) & ~mask;
        }
    }
}

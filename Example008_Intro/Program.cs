﻿//Это вспомогательный механизм, который ищет максимум из трех чисел (понять что это и почему не ставитcя ;?)
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 12;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 3311;
int a3 = 13;
int b3 = 23;
int c3 = 33;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

// Ниже отсылка к функциональному программированию
int max = Max(
    Max(a1, b1, c1), 
    Max(a2, b2, c2), 
    Max(a3, b3, c3));
Console.WriteLine(max);




// Это стихиный подход
// if (b1 > max) max = b1; // Т.е. в макс кладем в1 (можно) и так записать.
// if (c1 > max) max = c1;
// if (a1 > max) max = a1;

// if (b2 > max) max = b2; // Т.е. в макс кладем в1 (можно) и так записать.
// if (c2 > max) max = c2;
// if (a2 > max) max = a2;

// if (b3 > max) max = b3; // Т.е. в макс кладем в1 (можно) и так записать.
// if (c3 > max) max = c3;
// if (a3 > max) max = a3;
﻿using System;



//2. Напишите программу,
 //которая принимает на вход
 // трёхзначное число и на выходе
  // показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1


// Подразумеваем что число вводится только целое

int N = new Random().Next(100,1000);
//int N = 205;
if (N > 100 && N <1000 ){ 
    N =  (N/10)%10;
    Console.WriteLine("Second count = " + N);
}




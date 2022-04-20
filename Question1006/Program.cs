using System;

static int SecondNum(int res){
    int num = ((res/10)/10)%10;
    return num;
    } 
    
//6. Напишите программу, которая принимает
//на вход отрицательное четырехзначное число
//и на выходе показывает вторую цифру этого числа.


// Числа генерируются рандомно, часть для ввода собственноручно 
// под комментарием  

int rand_count = new Random().Next(1000,10000);
rand_count *=-1;
//int rand_count = -1100;
Console.WriteLine("Random number = " + rand_count);
Console.WriteLine("Second num is " + SecondNum(rand_count));

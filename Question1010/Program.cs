
 int MaxCount(){

    int rand_count = new Random().Next(10,100);
    int dec = rand_count/10;
    int count = rand_count%10;
    Console.WriteLine("Random num = "+ rand_count);
    if (dec>count){
        return dec;
        }
    else {
        return count;
        }
    }
        
// 1. Напишите метод, который выводит 
// случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8 
          
Console.WriteLine("{0} is bigger", MaxCount());
    

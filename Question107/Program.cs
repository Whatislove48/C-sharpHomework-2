
/*
7. Напишите программу, которая выводит 
третью цифру заданного числа 
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/


int ThirdCount(int numeric){
    int Countnumber = 0; // колличество цифр в числе
    int x = numeric; // копия числа
    while (x !=0 ){
        x /=10;        // отсеивание последней цифры 
        Countnumber++; // подсчет 
    }
    int[] NumericCount = new int [Countnumber]; // массив чисел
    int i = (NumericCount.Length -1); // корректировка индекса
    while (i>0){
        NumericCount[i] = (numeric%10);  // присваиваине в массив последней цифры числа
        numeric /= 10;                   // срез последней цифры
        i--;                   
    } 
    return NumericCount[2];            // возвращение 3й цифры
}


int num = 1859476;
if (num>=100){
    Console.WriteLine("Third number is {0}",ThirdCount(num));
}
else{
    Console.WriteLine("3й цифры нет");
}


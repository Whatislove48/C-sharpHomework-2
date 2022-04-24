

// 8 Напишите программу, которая принимает на вход 
// цифру, обозначающую день недели, и проверяет,
 // является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

// Допустим месяц выбран апрель 2022

int Weeknd(int numday){
    int[] Weekend = {2,3,9,10,16,17,23,24,30};// Числа выходных (сб,вс)
    int i = 0;
    int flag = 0;
    while (i<Weekend.Length){
        if (Weekend[i] == numday){
            flag = 1;
            break;
        }
        else {
            flag = 0;
        }
        i++;
    }
    return flag;
}


int day = 10;

if (Weeknd(day) == 1 ){
    Console.WriteLine("Да ");
}
else{
    Console.WriteLine("Нет");
}

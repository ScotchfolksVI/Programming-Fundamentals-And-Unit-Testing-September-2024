﻿//входни данни
int count = int.Parse(Console.ReadLine()); //брой на числата, които трябва да въведа и сумирам

double sum = 0; //сума на въведените стойности на числа

//всяко число с пореден номер от 1 (първото) до  count (последното) -> въвеждаме стойност + сумираме
//повтарящо се действие определен брой пъти -> for цикъл

//1. начало -> първото число (1)
//2. край -> последнто число (count)
//3. повтаряме -> въвеждаме стойността на числото и добавяме числото към сумата
//4. промяна -> +1

for (int number = 1; number <= count; number++)
{
    //въвеждаме стойността на числото
    double value = double.Parse(Console.ReadLine());
    //добавяме числото към сумата
    sum = sum + value;  //sum += value;
}

//обходили сме всички числа от първото до последното
//като за всяко сме въвели стойността му и сме го сумирали
Console.WriteLine(sum);


//Задача 10.
//Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
/*
Console.WriteLine("Enter your number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (secondNumber > 99 && secondNumber < 1000)
{
    int mid = (secondNumber % 100 - secondNumber % 10) / 10;
    Console.WriteLine($"The second digit is {secondNumber} {mid}");
}
else
{
    Console.WriteLine("ERROR!");
}
*/
//Задача 13.
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
/*
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

{
    if (number < 0) number *= -1;
    if (number < 100)
        Console.WriteLine("Третьей цифры у этого числа нет.");
    else if (number < 1000)
        Console.WriteLine("Третья цифра заданного числа: " + number%10);
    else if (number > 999)
        Console.WriteLine("Третья цифра заданного числа: " + (number / 100) % 10);
}
*/
//Задача 15.
//Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
/*
Console.Write("Введите число от 1 до 7: ");
int input = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(getHoliday(input));

string getHoliday(int dayNum)
{
    string getHoliday = "нет";
    if (dayNum < 1 || dayNum > 7) getHoliday = "Введёное число не от 1 до 7";
    if (dayNum == 6 || dayNum == 7) getHoliday = "да";
    return getHoliday;
};
*/

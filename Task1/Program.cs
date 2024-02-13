// Задание 1
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
Console.Write("Введите число:");
int chislo = Convert.ToInt32(Console.ReadLine());
if(chislo%7==0 && chislo%23==0){
Console.WriteLine("Да");
}else{
    Console.WriteLine("нет");
}
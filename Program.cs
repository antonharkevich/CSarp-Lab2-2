using System;
using System.Globalization;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
             //fr-FR en-Us en-ES de-De ru-Ru
            string str = Console.ReadLine();
            CultureInfo culture = CultureInfo.CreateSpecificCulture(str);//переменная спецификатора культуры
            DateTime someDate = new DateTime();//начальная дата 01.01.
            for (int i = 0; i < 12; i++)
            {
               
                Console.WriteLine(someDate.AddMonths(i).ToString("MMMM", culture));//в реальности кроме строки нигде не добавляется// формат MMMM вывод полного значения месяца 
            }
        }
    }
}

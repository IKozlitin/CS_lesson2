using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace PropsWPU221
{
    class Magazine
    {
        public string magazineName { get; set; } = "Journal";
        public string magazineDate { get; set; } = "2002";
        public string magazineDescription { get; set; } = "CS";
        public string phoneNumber { get; set; } = "8(888)888-88-88";
        public string eMail { get; set; } = "www.journal@gmail.com";

        public void enterInfo()
        {
            Write("Введите название журнала: ");
            string magazineName = ReadLine();

            Write("Введите год основания: ");
            string magazineDate = ReadLine();

            Write("Введите описание журнала: ");
            string magazineDescription = ReadLine();

            Write("Введите номер телефона: ");
            string phoneNumber = ReadLine();

            Write("Введите адрес эл.почты: ");
            string eMail = ReadLine();

            WriteLine($"\nЖурнал: {magazineName}\nГод: {magazineDate}\nОписание: {magazineDescription}" +
                $"\nТелефон: {phoneNumber}\nЭл.почта: {eMail}");
        }
        public void Print()
        {
            WriteLine($"\nЖурнал: {magazineName}\nГод: {magazineDate}\nОписание: {magazineDescription}" +
                 $"\nТелефон: {phoneNumber}\nЭл.почта: {eMail}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Magazine mag1 = new Magazine();
            Magazine mag2 = new Magazine();
            mag1.Print();
            mag2.enterInfo();

        }
    }
}
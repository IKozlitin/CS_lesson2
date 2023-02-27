using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace PropsWPU221
{
       class Student
    {
        public string FirstName { get; set; } = "John";
        public string LastName { get; set; } = "Connor";
        public string Group { get; set; } = "WPU221";
        public DateTime BirthDate { get; set; } = DateTime.Now;

        public void Print()
        {
            WriteLine($"Имя: {FirstName}\nФамилия: {LastName}\nДата рождения: {BirthDate}\nГруппа: {Group}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student
            {
                FirstName = "Sara",
                LastName = "Connor",
                BirthDate = new DateTime(1956, 3, 8),
                Group = "T1000"
            };
            Student st2= new Student
            {
                FirstName = "Arnold",
                LastName = "Shwarznegger",
                BirthDate = new DateTime(1946, 12, 23),
                Group = "T800"
            };
            Student st3 = new Student
            {
                FirstName = "Robert",
                LastName = "Patrick",
                BirthDate = new DateTime(1966, 7, 18),
                Group = "T1000"
            };
            Student st4 = new Student();
            st1.Print();
            st2.Print();
            st3.Print();
            st4.Print();
        }
    }
}
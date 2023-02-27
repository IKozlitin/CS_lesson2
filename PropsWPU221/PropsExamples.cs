using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//для быстрого создания АВТОСВОЙСТВА пишем prop, нажимаем 2 раза таб

namespace PropsWPU221
{
  
    class Employee
    {
        string _firstName;
        public string FirstName
        {
            get { return _firstName != null ? _firstName : "Аристарх"; }
            set { _firstName = value.ToUpper(); }
        }

        string _lastName;
        public string LastName
        {
            get { return _lastName != null ? _lastName : "Абрикосов"; }
            set { _lastName = value.ToUpper(); }
        }

        int _age;
        public int Age
        {
            get { return _age; } 
            set { _age = (value < 1 || value > 100) ? 0 : value; }
        }

        double _salary;
        public double Salary
        {
            get { return _salary; }
            set { _salary = value < 0 ? 0 : value; }
        }
        public void Print()
        {
            WriteLine($"Имя: {FirstName}\nФамилия: {LastName}\nВозраст: {Age}\nЗарплата: {Salary}");
        }
    }

   internal class Program
   {
        static void Main(string[] args)
        {
           
            Employee emp1 = new Employee
            {
                FirstName = "Альберт",
                LastName = "Энштейн",
                Age = 19,
                Salary = 12000
            };

            Employee emp2 = new Employee();

            Employee emp3 = new Employee
            {
                FirstName = "Венцеслав",
                LastName = "Зайцев",
                Age = 123,
                Salary = -100
            };
            emp1.Print();
            emp2.Print();
            emp3.Print();
        }
   }
}
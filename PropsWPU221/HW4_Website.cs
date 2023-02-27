using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace PropsWPU221
{
    class Website
    {
        public string siteName { get; set; } = "WebSite";
        public string siteAddress { get; set; } = "www.website@gmail.com";
        public string siteDescription { get; set; } = "WebShop";
        public string ipAddress { get; set; } = "192.168.0.1";
             
        public void enterInfo()
        {
            Write("Введите название сайта: ");
            string siteName = ReadLine();

            Write("Введите адрес сайта: ");
            string siteAddress = ReadLine();

            Write("Введите описание сайта: ");
            string siteDescription = ReadLine();

            Write("Введите Ip: ");
            string ipAddress = ReadLine();

            WriteLine($"\nСайт: {siteName}\nАдрес: {siteAddress}\nОписание: {siteDescription}\nIp: {ipAddress}");
        }
        public void Print()
        {
            WriteLine($"\nСайт: {siteName}\nАдрес: {siteAddress}\nОписание: {siteDescription}\nIp: {ipAddress}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Website web1 = new Website();
            Website web2 = new Website();
            web1.Print();
            web2.enterInfo();
           
        }
    }
}
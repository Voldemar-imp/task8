using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int patientsInLine;
            int receptionTime = 10;
            int minutesPerHour = 60;
            int minutes;
            int hours;

            Console.WriteLine("Добро пожаловать в поликлиннику, время приема одного пациента составлет: " + receptionTime + " минут");
            Console.Write("Введите количество пациентов в очереди:");
            patientsInLine = Convert.ToInt32(Console.ReadLine());

            minutes = patientsInLine * receptionTime;
            hours = minutes / minutesPerHour;
            minutes -= hours * minutesPerHour;
            Console.WriteLine("Вы должны отстоять в очереди {0} часа и {1} минут.", hours, minutes);
        }
    }
}

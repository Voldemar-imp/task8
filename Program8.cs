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
            int minutesOfWaiting;
            int hoursOfWaiting;

            Console.WriteLine("Добро пожаловать в поликлиннику, время приема одного пациента составлет: " + receptionTime + " минут");
            Console.Write("Введите количество пациентов в очереди:");
            patientsInLine = Convert.ToInt32(Console.ReadLine());

            minutesOfWaiting = patientsInLine * receptionTime;
            hoursOfWaiting = minutesOfWaiting / minutesPerHour;
            minutesOfWaiting -= hoursOfWaiting * minutesPerHour;
            Console.WriteLine("Вы должны отстоять в очереди {0} часа и {1} минут.", hoursOfWaiting, minutesOfWaiting);
        }
    }
}

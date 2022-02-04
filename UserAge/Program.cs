using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust
            //programm arvutab kasutaja sünniaastat
            //programm kuvab sünniaastat konsoolis
            //"oled sündinud aastal {yearOfBirth}

            Console.WriteLine("Palun sisesta siia oma vanus.");
            int userage = Convert.ToInt32(Console.ReadLine());

            int yearOfBirth = 2022 - userage;

            Console.WriteLine("oled sündinud " + yearOfBirth + ". aastal");
        }
    }
}

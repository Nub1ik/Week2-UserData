using System;

namespace User_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat;
            //programm arvutab kasutaja vanust;
            //programm kuvab kasutaja vanust konsoolis;

            Console.WriteLine("Palun, sisesta oma sünniaasta");
            int yearofbirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2022 - yearofbirth;

            //Console.WriteLine("Oled, " + userAge + " aastat vana");

            //string interpolation

            Console.WriteLine($"Oled {userAge} aastat vana.");
                




        }
    }
}

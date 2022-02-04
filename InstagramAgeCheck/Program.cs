using System;

namespace InstagramAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {

            //Programm küsib kasutaja vanust
            //programm kontrollib kas kasutaja on vanem kui 13 või noorem
            //kui kasutaja on vanem siis ta võib kasutada instagrammi
            //kui kasutaja on noorme kui 13 siiis ei või kasutada

            Console.WriteLine("Palun sisesta siia oma vanus");
            int userAge = Convert.ToInt32(Console.ReadLine());

            if (userAge > 13)
            {
                Console.WriteLine("Oled piisavalt vana, et Instagrami kontot luua.");
            }
            else if (userAge < 13)
            {
                Console.WriteLine("Oled liiga noor, et Instagrami kontot luua");
            }
            else 
            {
                Console.WriteLine("Oled 13 nüüd saad endale Instagrami konto luua");
            }

            Console.WriteLine("Kena päeva!");




        }
    }
}

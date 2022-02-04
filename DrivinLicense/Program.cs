using System;

namespace DrivinLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaja sünniaastat
            //Programm arvutab kasutaja vanust
            //Kui kasutaja on noorem kui 18 siis programm kuvab konsoolis "Oled liiga noor, et juhiluba taodelda"
            //Kui kasutaj on vanem kui 18 siis programm kuvab "
            //"Oled piisavalt vana, et juhiluba taodelda"
            //Kui kasutaja on 18 siis programm siisprogramm kuvab konsoolis
            //"palju Õnne! Nüüd sa saad ka juhiluba taodelda"

            Console.WriteLine("Palun sisesta siia oma sünniaata!");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2022 - yearOfBirth;

            if (userAge > 18) 
            {
                Console.WriteLine("Oled piisavalt vane, et juhiluba taodelda");
            }
            else if (userAge < 18) 
            {
                Console.WriteLine("Oled veel liiga noor, et juhilub taodelda");
            }
            else 
            {
                Console.WriteLine("Palju Õnne! Nüüd saad juhilube taodelda!");
            }

            Console.WriteLine("Ilusat Päeva!");

        }


    }
}


using System;
using System.Collections.Generic;

namespace kisiselproject
{
    class Program
    {

        /*
         Rank'a göre maaş hesaplaması. 
        
        */
        static void Main(string[] args)
        {

            var wages = new List<Employee>
            {

            new SeniorDev { UserID = 1, Name = "Türkay Ürkmez", LevelBonus = 2.8 },
            new MidDev { UserID = 2, Name = "Yusuf Kükrer", LevelBonus = 1.8 },
            new JuniorDev { UserID = 3, Name = "Yuşe Yusuf Kılıç", LevelBonus = 1.3 }
            };

            foreach (var wage in wages)
            {
                Console.WriteLine($"{wage.Name}'s wage is {wage.CalculateWage()}TL. ");
            }





        } 
           
    }
}
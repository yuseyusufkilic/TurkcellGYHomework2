using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kisiselproject
{

    public abstract class Employee
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public double MainWage { get; set; } = 5000;

        public double LevelBonus { get; set; }

        public abstract double CalculateWage();
    }

    public class SeniorDev : Employee
    {
        public override double CalculateWage()
        {

            return  (MainWage * LevelBonus);
        }
    }


    public class MidDev : Employee
    {
        public override double CalculateWage()
        {
            return (MainWage * LevelBonus);
        }
    }

    public class JuniorDev : Employee
    {
        public override double CalculateWage()
        {
            return (MainWage * LevelBonus);
        }
    }



}

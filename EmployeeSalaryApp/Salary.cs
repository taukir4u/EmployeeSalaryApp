using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryApp
{
    class Salary
    {
        public double MedicalPercentage { set; get; }
        public double ConveyancePercentage { set; get; }
        public double BasicSalary { set; get; }
        public int NoofIncrements { private set; get; }

        public double GetTotalSalary()
        {
            return BasicSalary + GetConveyanceAmount() + GetMedicalAmount();
        }

        public double GetMedicalAmount()
        {
            return (MedicalPercentage*BasicSalary)/100;
        }

        public double GetConveyanceAmount()
        {
            return (ConveyancePercentage * BasicSalary) / 100;
        }

        public void IncreaseSalary(double incrementPercentageOfBasic)
        {
            BasicSalary = BasicSalary + (BasicSalary*incrementPercentageOfBasic/100);
            NoofIncrements += 1;
        }
    }
}

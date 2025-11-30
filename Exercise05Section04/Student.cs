using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05Section04
{
    internal class Student
    {
        public string? Name;
        public double FirstQuarterGrade;
        public double SecondQuarterGrade;
        public double ThirdQuarterGrade;
        private const double MinimumGrade = 60;

        public double FinalGrade()
        {
            return FirstQuarterGrade + SecondQuarterGrade + ThirdQuarterGrade;
        }

        public bool IsApproved()
        {
            return FinalGrade() >= MinimumGrade;
        }

        public double RemainingPoints()
        {
            if (!IsApproved())
            {
                return MinimumGrade - FinalGrade();
            }
            else
            {
                return 0;
            }
        }
    }
}
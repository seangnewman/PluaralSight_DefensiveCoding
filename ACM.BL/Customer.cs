using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string EmailAddress { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void ValidateEmail()
        {
             
        }

        public decimal CalculatePercentOfGoalSteps(string goalSteps, string actualSteps)
        {
            decimal goalStepCount = 0;
            decimal actualStepCount = 0;

            if (string.IsNullOrWhiteSpace(goalSteps))
                throw new ArgumentException("Goal must be entered", "goalSteps");
            if (string.IsNullOrWhiteSpace(actualSteps))
                throw new ArgumentException("Goal must be entered", "actualSteps");

            if (!decimal.TryParse(goalSteps, out goalStepCount))
                throw new ArgumentException("Goal must be numeric");
            if(!decimal.TryParse(actualSteps, out actualStepCount))
                throw new ArgumentException("Steps must be numeric");
            return CalculatePercentOfGoalSteps(goalStepCount, actualStepCount);
        }

        public decimal CalculatePercentOfGoalSteps(decimal goalStepCount, decimal actualStepCount)
        {
            if (goalStepCount <= 0)
                throw new ArgumentException("Goal must be greater than 0", "goalSteps");

            return Math.Round((actualStepCount / goalStepCount) * 100, 2);
        }

    }
}

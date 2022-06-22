using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengesWithTestsMark8
{
    public class Business
    {
        public string Name { get; set; }
        public double TotalRevenue { get; set; }
        public double TotalExpenses { get; set; }
        public Business ParentCompany { get; set; }
    }
}

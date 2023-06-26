using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBasic
{
    public class ConditionStructure
    {
        public void GoToInstruction()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 18)
            {
                goto ineligible;
            }
            else
            {
                Console.WriteLine("You are eligible to vote!");
                goto endMethod;
            }

        ineligible:
            Console.WriteLine("You are NOT eligible to vote!");
        endMethod:
            return;
        }

        
    }
}

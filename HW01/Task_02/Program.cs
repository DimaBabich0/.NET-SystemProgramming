using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class Program
    {
        static void Main()
        {
            Bank bank = new Bank("Bank", 5000, 2);
            bank.Money = 10000;
            bank.Percent = 1;
            bank.Name = "New Bank";
        }
    }
}

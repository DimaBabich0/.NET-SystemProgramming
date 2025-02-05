using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_02
{
    internal class Bank
    {
        static private readonly string filePath = "BankInfo.txt";
        static private readonly object lockObj = new object();

        private void SaveData()
        {
            new Thread(LogData).Start();
        }

        private void LogData()
        {
            lock(lockObj)
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine($"Name: {Name}, Money: {Money}, Percent: {Percent}%");
                }
            }
        }

        private string _name;
        private int _money;
        private int _percent;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                SaveData();
            }
        }

        public int Money
        {
            get
            {
                return _money;
            }
            set
            {
                _money = value;
                SaveData();
            }
        }

        public int Percent
        { 
            get
            {
                return _percent;
            }
            set
            {
                _percent = value;
                SaveData();
            }
        }

        public Bank(string name, int money, int percent)
        {
            _name = name;
            _money = money;
            _percent = percent;
            SaveData();
        }
    }
}

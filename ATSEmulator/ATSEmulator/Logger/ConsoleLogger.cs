﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATSEmulator
{
    public class ConsoleLogger : ILogger
    {
        public void WriteToLog(string log)
        {
            Console.WriteLine(log);
        }
    }
}

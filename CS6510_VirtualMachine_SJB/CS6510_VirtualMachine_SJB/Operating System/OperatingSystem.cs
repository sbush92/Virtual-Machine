﻿using System;
using System.IO;
using System.Text;
namespace CS6510_VirtualMachine_SJB
{
    class OperatingSystem
    {
        static VirtualMachine VM = new VirtualMachine();
        static FiveProcess FP = new FiveProcess();
        static void Main(string[] args)
        {
            do
            {
            } while (OperatingSystem1.shellCommand(VM) == true);
            Console.WriteLine("program has ended press any key to exit");
            Console.ReadKey();
        }
    }
}




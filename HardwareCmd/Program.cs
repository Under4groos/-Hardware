using HardwareLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace HardwareCmd
{
    internal class Program
    {
        static void Main(string[] args)
        {

            main(args);
            Console.ReadLine();
        }

        static void main(string[] args)
        {
            MObjSearcher mObjSearcher = new MObjSearcher();
            mObjSearcher.Find(HIKeys.Win32_Processor);
            mObjSearcher.GetInformations();
            foreach (DMObject item in mObjSearcher.dMObjects)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}

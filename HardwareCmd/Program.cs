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
        static MObjSearcher mObjSearcher = new MObjSearcher();
        static void main(string[] args)
        {
            if(args.Length == 0)
            {
                while (true)
                {

                    string cmd_ = Console.ReadLine();

                    switch (cmd_)
                    {
                        case "help":
                            Console.WriteLine("get hikeys");
                            Console.WriteLine("get");
                            Console.WriteLine("help me pls!");
                            break;
                        case "get hikeys":
                            foreach (HIKeys item in Enum.GetValues(typeof(HIKeys)))
                            {
                                Console.WriteLine(item);
                            }
                            break;
                        case "get":
                            Console.WriteLine("say HIKeys -> cmd:\"get hikeys\"");



                            mObjSearcher.Find(Console.ReadLine());
                            mObjSearcher.GetInformations();
                            foreach (DMObject item in mObjSearcher.dMObjects)
                            {
                                Console.WriteLine(item);
                            }
                            break;
                        default:
                            break;
                    }
                }
                
                
            }
            
            
        }
    }
}

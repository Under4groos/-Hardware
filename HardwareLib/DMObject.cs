using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareLib
{
    public struct DMObject
    {
        public string Name;
        public string Value;
        public string Type;
        public override string ToString()
        {
            return $"{Name} {Value} {Type}";
        }
    }
}

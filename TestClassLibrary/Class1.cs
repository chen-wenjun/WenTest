using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace TestClassLibrary
{
    public class Class1
    {
        private static Class1 _intance = new Class1();

        public Class1()
        {
            
        }

        public static Class1 Instance
        {
            get
            {
                return _intance;
            }
        }

        public string GetStr()
        {
            return "test string";
        }
    }
}

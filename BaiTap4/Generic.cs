using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap4
{
    internal class Generic
    {
        public static void display<T>(T value)
        {
            Console.WriteLine("Gia tri: " + value);
        }

        public static T traVe<T>(T value) {

            return value;
        }
    }
}

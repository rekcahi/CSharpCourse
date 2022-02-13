using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorsDemo
{
     class Nested
    {
        public Nested(string a)
        {
            Console.WriteLine("1-Nested Çalıştı {0}",a);                
        }
    }
    class Nested1:Nested
    {
        public Nested1(string a, string b):base("a")
        {
            Console.WriteLine("2-Nested1 Çalıştı {0}--{1}",a,b);
        }
    }

    class Nested2:Nested1
    {
        public Nested2(string a, string b,string c):base("a","b")
        {
            Console.WriteLine("2-Nested2 Çalıştı {0}--{1}--{2}",a,b,c);

        }

    }
}

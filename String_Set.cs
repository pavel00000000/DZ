using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Реализуйте класс "StringSet", представляющий множество строк.
//Перегрузите операторы объединения (+) и пересечения(&) для множеств строк.
//Создайте два объекта типа "StringSet" и выполните операции объединения и пересечения между ними.
namespace String
{
    class StringSet
    {
        public string Value { get; set; }

        public static StringSet operator +(StringSet c1, StringSet c2)
        {
            return new StringSet { Value = c1.Value + c2.Value };
        }

        public struct Struct
        {
            public string value { get; set; }

            public Struct(string value1)
            {
                this.value = value1;
            }

            public static Struct operator &(Struct a, Struct b)
            {

                return new Struct(a.value + b.value);
            }
        }

    }
}

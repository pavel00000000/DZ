using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Создайте класс "StringCollection", представляющий коллекцию строк.
//Реализуйте индексатор, который позволяет получать и задавать элементы коллекции по индексу.
//Создайте объект типа "StringCollection" и добавьте несколько строк.
//Затем выведите некоторые строки, используя индексатор.

namespace StringColl
{
   class String_Collection
    {
        public class String_arr
        {
            public string stroka  { get; set; }
          
            public override string ToString()
            {
                return $"{stroka}";
            }
        }
        public class String_Collection_1
        {
            String_arr[] Arr { get; }
            public String_Collection_1(int size)
            {
                Arr = new String_arr[size];
            }
            public int  Length
            {
                get { return Arr.Length; }
            }
            public String_arr this[int index]
            {
                get
                {
                    if (index >= 0 && index < Arr.Length)
                    {
                        return Arr[index];
                    }
                    throw new IndexOutOfRangeException();
                }
                set
                {
                    Arr[index] = value;
                }
            }
        }
        
    }
}

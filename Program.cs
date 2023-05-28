
//Реализуйте класс "StringSet", представляющий множество строк. Перегрузите операторы объединения (+) и пересечения(&) для множеств строк. Создайте два объекта типа "StringSet" и выполните операции объединения и пересечения между ними.


//Реализуйте класс "Matrix", представляющий двумерную матрицу. Реализуйте индексатор, который позволяет получать и задавать элементы матрицы по индексу строки и столбца. Создайте объект типа "Matrix" и заполните его элементами. Затем выведите некоторые элементы матрицы, используя индексатор.


//Создайте класс "StringCollection", представляющий коллекцию строк. Реализуйте индексатор, который позволяет получать и задавать элементы коллекции по индексу. Создайте объект типа "StringCollection" и добавьте несколько строк. Затем выведите некоторые строки, используя индексатор.


using Microsoft.VisualBasic;
using String;
using Matrix1;
using StringColl;

Console.WriteLine("Реализуйте класс \"StringSet\", представляющий множество строк. Перегрузите операторы объединения (+) и пересечения(&) для множеств строк. Создайте два объекта типа StringSet и выполните операции объединения и пересечения между ними.");
//Реализуйте класс "StringSet", представляющий множество строк. Перегрузите операторы объединения (+) и пересечения(&) для множеств строк. Создайте два объекта типа "StringSet" и выполните операции объединения и пересечения между ними.
Console.WriteLine();
StringSet counter1 = new StringSet { Value = "Hello, " };
StringSet counter2 = new StringSet { Value = "world! " };
StringSet c1 = counter1 + counter2;
Console.WriteLine("оператор объединения (+) " + c1.Value);
Console.WriteLine();
StringSet.Struct struct1 = new StringSet.Struct(" Hello, ");
StringSet.Struct struct2 = new StringSet.Struct("world!");
StringSet.Struct result = struct1 & struct2;
Console.WriteLine("оператор пересечения(&)" + result.value);
Console.WriteLine();
////__________________________________________________________________________
Console.WriteLine("Реализуйте класс Matrix, представляющий двумерную матрицу. Реализуйте индексатор, который позволяет получать и задавать элементы матрицы по индексу строки и столбца. Создайте объект типа \"Matrix\" ");

Matrix matrix = new Matrix(3, 3);
matrix[0, 0] = 1;
matrix[0, 1] = 2;
matrix[0, 2] = 3;
matrix[1, 0] = 4;
matrix[1, 1] = 5;
matrix[1, 2] = 6;
matrix[2, 0] = 7;
matrix[2, 1] = 8;
matrix[2, 2] = 9;

Console.WriteLine(matrix[0, 0]);
Console.WriteLine(matrix[1, 1]);
Console.WriteLine(matrix[2, 2]);
//___________________________________________________________________________________
//Создайте класс "StringCollection", представляющий коллекцию строк. Реализуйте индексатор, который позволяет получать и задавать элементы коллекции по индексу. Создайте объект типа "StringCollection" и добавьте несколько строк. Затем выведите некоторые строки, используя индексатор.

Console.WriteLine("Создайте класс StringCollection, представляющий коллекцию строк. Реализуйте индексатор, который позволяет получать и задавать элементы коллекции по индексу. Создайте объект типа StringCollection и добавьте несколько строк. Затем выведите некоторые строки, используя индексатор. ");

String_Collection.String_Collection_1 collection = new String_Collection.String_Collection_1(5);

collection[0] = new String_Collection.String_arr { stroka = "Привет" };
collection[1] = new String_Collection.String_arr { stroka = "Мир" };
collection[2] = new String_Collection.String_arr { stroka = "Пример" };
collection[3] = new String_Collection.String_arr { stroka = "Индексатор" };
collection[4] = new String_Collection.String_arr { stroka = "Строки" };

Console.WriteLine(collection[0].stroka);
Console.WriteLine(collection[2].stroka);
Console.WriteLine(collection[4].stroka);






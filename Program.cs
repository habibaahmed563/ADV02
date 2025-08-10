using System.Collections;

namespace ADV02
{
    internal class Program
    {

        public static void PrintArrayList(ArrayList arraylist)
        {
            Console.WriteLine();
            foreach(int item in arraylist)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine();
        }

        public static int SumArrayList(ArrayList list)
        {
            int Sum = 0;
            if(list is not null)
            {
                for(int i=0;i<list.Count;i++)
                {
                    if (list[i] is int)
                    {
                       Sum += (int)list[i]; //unboxing [referenceType] To [ValueType] - UnSafe
                    }
                }
            }
            return Sum;
        }
        static void Main(string[] args)
        {
            #region What is Collections ? 
            //Collections : Built-in DS in C#
            //Array : Container

            //Collections in C# 
            //Lists
            //Hashtable

            //Generic - Non Generic
            //Lists : 
            //Non-Generic Lists : ArrayList- stack - Queue
            //Generic Lists : list,LinkedList , stack , Queue

            //Hashtables :
            //Non-Generic HashTable :hashtable
            //generic Hashtable:Dictionary - sorteddectionary 
            #endregion

            #region Non-Generic Lists : Arraylist
            //Lists
            //Non-Generic Lists : Arraylist

            //Arraylist Like Array 
            //Array Based 
            //Index

            //Array     Indexed Collection : Fixed size
            //ArrayList Indexed Collection : Dynamic Size

            //Index :0 1 2 3 4 5
            //items :4 5 6 7 8 1
            //Size  :6

            //Arr[1] ---> 5

            //int[] Numbers = { 9, 8, 7, 6, 1, 2, 3, 4, 5 };

            //Console.WriteLine(Numbers[1]);
            //Numbers[1] = 12;
            //Console.WriteLine(Numbers[1]);

            //ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });

            //Console.WriteLine($"Count : {list.Count},Capacity : {list.Capacity}");

            //list.Add(6);
            //list.Add(6);
            //list.Add(6);
            //list.Add(6);
            //list.Add(6);
            //list.Add(6);
            //list.Add(6);
            //list.Add(6);
            //Console.WriteLine($"Count : {list.Count},Capacity : {list.Capacity}");

            //ArrayList list = new ArrayList();

            //list.Add(1);
            //Console.WriteLine($"Count : {list.Count}, Capacity : {list.Capacity}");

            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //Console.WriteLine($"Count : {list.Count}, Capacity : {list.Capacity}");
            //list.Add(5);
            //Console.WriteLine($"Count : {list.Count}, Capacity : {list.Capacity}");
            //list.Add(6);
            //list.Add(7);
            //list.Add(8);
            //list.Add(9);
            //Console.WriteLine($"Count : {list.Count}, Capacity : {list.Capacity}");

            //Console.WriteLine(list.IsFixedSize);
            //Console.WriteLine(list.IsReadOnly);
            //Console.WriteLine(list[1]);

            //list[1] = 12;
            //Console.WriteLine(list[1]);

            //list.AddRange(new[] { 10, 11, 12 });

            //PrintArrayList(list);
            //int Index = list.BinarySearch(2);
            //int Index = list.BinarySearch(2);

            //Console.WriteLine(Index);

            //Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Age = 29, Salary = 12000 };
            //Employee E02 = new Employee() { Id = 2, Name = "Ali", Age = 35, Salary = 13000 };
            //Employee E03 = new Employee() { Id = 3, Name = "Omar", Age = 32, Salary = 14000 };
            //Employee E04 = new Employee() { Id = 4, Name = "mariam", Age = 30, Salary = 15000 };

            //ArrayList list = new ArrayList();
            //list.AddRange(new Employee[] { E01, E02, E03, E04, });

            //int Index = list.BinarySearch(E01);
            //Console.WriteLine($"Index : {Index}");

            //list.BinarySearch(0, 2, new Employee() { Name = "Ali" });
            //Console.WriteLine(Index);

            //Console.WriteLine("========");
            //foreach(Employee item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //ArrayList list = new ArrayList();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //Console.WriteLine($"Count : {list.Count}, Capacity : {list.Capacity}");

            //list.Clear();
            //Console.WriteLine($"Count : {list.Count}, Capacity : {list.Capacity}");

            //bool Flag = list.Contains(20);
            //Console.WriteLine(Flag);

            //int[] Arr = new int[10];

            //list.CopyTo(Arr,3);

            //foreach(int item in Arr)
            //{
            //    Console.WriteLine(item);
            //}

            //ArrayList arraylist = list.GetRange(0, 2);

            // foreach(int item in arraylist)
            // {
            //     Console.WriteLine(item);
            // }

            //list.IndexOf(5,4,5);
            //Console.WriteLine(i);

            //list.Insert(0, 100);

            //PrintArrayList(list);

            //list.InsertRange(0, new int[] { 10, 20, 30, 40 });

            //PrintArrayList(list);

            //list.LastIndexOf(5);

            //int i = list.LastIndexOf(5);
            //Console.WriteLine(i);

            //list.Remove(5);
            //PrintArrayList(list);
            //list.SetRange(0, new int[] { 1, 2, 3 });
            //list.Sort();
            //Console.WriteLine($"Count : {list.Count}, Capacity : {list.Capacity}");

            //list.TrimToSize(); //Delete | Release

            //Console.WriteLine($"Count : {list.Count}, Capacity : {list.Capacity}");

            //PrintArrayList(list); 
            #endregion

            #region Problems with Non-Generic Lists [Arraylist]
            //ArrayList list = new ArrayList();

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);

            ////list.Add("Hello World");
            //list.Add(new Employee());
            //list.Add(2, 3);

            //int sum = SumArrayList(list);
            //Console.WriteLine(sum); 
            #endregion


        }
    }
}

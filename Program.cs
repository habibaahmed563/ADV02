using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

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

        public static void PrintList<T>(List<T> values)
        {
            Console.WriteLine();
            foreach(T item in values)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine();
        }

        public static int SumList(List<int> list)
        {
            int Sum = 0;
            if (list is not null)
            {
                for (int i = 0; i < list.Count; i++)
                { 
                        Sum += list[i];
                }
            }
            return Sum;
        }

        public static void PrintlinkedList(LinkedList<int> linkedlist)
        {
            Console.WriteLine();
            foreach(int item in linkedlist)
            {
                Console.WriteLine($"<- {item} ->");
            }
            Console.WriteLine("null");
            Console.WriteLine();

        }

        public static void PrintStack(Stack<int> stack)
        {
            Console.WriteLine();
            foreach(int item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
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

            #region Generic List : List
            //Generic List : List
            //List : Version Generic of Arraylist
            //List ;ike Arraylist like Aray : Generic-dynamic size

            //List<int> list = new List<int>(new int[] {1,2,3});
            List<int> list = new List<int>();

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add("Hello");

            //PrintArrayList(list);

            //int sum = SumList(list);
            //Console.WriteLine(sum);

            //list.AddRange(new List<int> { 10, 20, 30, 40 });
            //PrintArrayList(list);

            //list.AsReadOnly();
            //int i = list.BinarySearch(20);

            ////PrintArrayList(list);

            //Console.WriteLine(i);

            //Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Age = 29, Salary = 12000 };
            //Employee E02 = new Employee() { Id = 2, Name = "Ali", Age = 35, Salary = 13000 };
            //Employee E03 = new Employee() { Id = 3, Name = "Omar", Age = 32, Salary = 14000 };
            //Employee E04 = new Employee() { Id = 4, Name = "mariam", Age = 30, Salary = 15000 };

            //List<Employee> employee = new List<Employee>{ E01, E02, E03, E04 };

            //int i = employee.BinarySearch(E01);
            //Console.WriteLine(i);

            //Console.WriteLine($"Count : {list.Count},Capacity : {list.Capacity}");

            //list.EnsureCapacity(10);

            //Console.WriteLine($"Count : {list.Count},Capacity : {list.Capacity}");

            //List<int> result = list.GetRange(0, 2);

            //PrintList(result);

            //list.Sort();

            //Console.WriteLine($"Count : {list.Count},Capacity : {list.Capacity}");

            //list.TrimExcess();

            //Console.WriteLine($"Count : {list.Count},Capacity : {list.Capacity}"); 
            #endregion

            #region Genericlists : Linkedlist
            //Genericlists : Linkedlist

            //Linkedlist<>

            //Linkedlist

            //LinkedList<int> linkedlist = new LinkedList<int>();

            //linkedlist.AddFirst(1);
            //linkedlist.AddFirst(2);
            //linkedlist.AddLast(1);
            //linkedlist.AddLast(2);
            //linkedlist.AddLast(3);

            //LinkedListNode<int> node = new LinkedListNode<int>(3);
            //linkedlist.AddLast(1);

            //Console.WriteLine(linkedlist.First.Value);
            //Console.WriteLine(linkedlist.Last.Value);

            //linkedlist.Clear();

            //Console.WriteLine(linkedlist.First.Next);
            //linkedlist.Remove(linkedlist.First);
            //linkedlist.Remove(2);

            //PrintArrayList(linkedList); 
            #endregion

            #region Generic list : STACK 
            //Generic list : STACK 

            //Stack<int> stack = new Stack<int>();

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);
            //int top = stack.Pop();
            //Console.WriteLine(top);

            ////int top = stack.Peek();
            ////Console.WriteLine(top);

            //stack.TryPeek();
            //bool flag = stack.TryPeek(out int top);
            //Stack.Pop();
            //bool flag = stack.TryPop(out int top);

            //PrintStack(stack);
            //Console.WriteLine(top);

            //undo : ctrl + z 
            #endregion

        }
    }
}

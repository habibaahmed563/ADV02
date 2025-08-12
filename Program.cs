using System.Collections;

namespace ADV02
{
    internal class Program
    {

        static void ReverseQueueUsingStack(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();

            while(queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            while(stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
        }

        static bool IsBalanced(string input)
        {
            Stack<char> stack = new Stack<char>();
            foreach(char c in input)
            {
                if(c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }else if(c==')' || c== ']' || c== '}')
                {
                    if (stack.Count == 0) return false;
                    char top = stack.Pop();
                    if ((c == ')' && top != '(') || (c == ']' && top != '[') || (c == '}' && top != '{'))
                        return false;

                }
            }
            return stack.Count == 0;
        }

        static int[] Removeduplicates(int[] arr)
        {
            return arr.Distinct().ToArray();
        }

        static void RemoveOddNumbers(ArrayList list)
        {
            for(int i=list.Count-1; i>=0;i--)
            {
                if ((int)list[i] %2 !=0)
                {
                    list.RemoveAt(i);
                }
            }
        }

        static void ReverseFirstK(Queue<int> n, int K)
        {
            Stack<int> s = new Stack<int>();

            for(int i=0;i<K;i++)
            {
                s.Push(n.Dequeue());
            }

            while(s.Count>0)
            {
                n.Enqueue(s.Pop());
            }

            for(int i= 0; i<n.Count-K;i++)
            {
                n.Enqueue(n.Dequeue());
            }
        }

        static void Main(string[] args)
        {

            // Q1 :

            //string[] firstLine = Console.ReadLine().Split();
            //int N = int.Parse(firstLine[0]);
            //int Q = int.Parse(firstLine[1]);

            //string[] array = Console.ReadLine().Split();
            //int[] arr = new int[N];

            //for(int i=0; i<N ; i++)
            //{
            //    arr[i] = int.Parse(array[i]);
            //}

            //for (int i = 0; i < Q; i++)
            //{
            //    int count = 0;
            //    int x = int.Parse(Console.ReadLine());

            //    for(int j=0; j<N; j++)
            //    {
            //        if(arr[j] > x)
            //        {
            //            count++;
            //        }
            //    }
            //    Console.WriteLine(count);
            //}



            // Q2 : 


            //int N = int.Parse(Console.ReadLine());

            //string[] input = Console.ReadLine().Split();
            //int[] arr = new int[N];

            //for(int i=0; i<N; i++)
            //{
            //    arr[i] = int.Parse(input[i]);
            //}

            //bool ispalindrome = true;
            //for(int i =0; i<N/2; i++)
            //{
            //    if (arr[i]!= arr[N-1-i])
            //    {
            //        ispalindrome = false;
            //        break;
            //    }
            //}
            //if (ispalindrome)
            //{
            //    Console.WriteLine("yes");
            //}
            //else
            //    Console.WriteLine("No");



            // Q3 : 


            //Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5 });
            //ReverseQueueUsingStack(queue);
            //Console.WriteLine($"{queue}");


            // Q4 : 


            //string input = "[{()}]";
            //Console.WriteLine(IsBalanced(input) ? "Balanced" : "Not Balanced");


            //// Q5 :

            //int[] numbers = { 1, 2, 2, 3, 3, 4, 5 };
            //int[] result = Removeduplicates(numbers);

            //Console.WriteLine(string.Join(" ", result));


            // Q6 :

            //ArrayList numbers = new ArrayList { 1, 2, 3, 4, 5, 6 };
            //RemoveOddNumbers(numbers);
            //Console.WriteLine(string.Join(" ", numbers.ToArray()));


            // Q7 : 

            //Queue queue = new Queue();

            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);

            //Console.WriteLine("Queue elements : ");
            //foreach(var item in queue)
            //{
            //    Console.WriteLine(item);
            //}


            // Q8 :

            //Stack<int> stack = new Stack<int>();

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);

            //int target = 30;
            //int count = 0;
            //bool found = false;

            //foreach(int item in stack)
            //{
            //    count++;
            //    if(item==target)
            //    {
            //        Console.WriteLine($"Target was found successfully and the count = {count}");
            //        found = true;
            //        break;
            //    }
            //}

            //if(!found )
            //{
            //    Console.WriteLine("target was not found");
            //}



            // Q9 :

            //int N1 = 5;
            //int N2 = 3;

            //int[] arr1 = { 1, 2, 3, 4, 4 };
            //int[] arr2 = { 10, 4, 4 };
            //List<int> tempArr2 = new List<int>(arr2);
            //List<int> intersection = new List<int>();

            //foreach (int num in arr1)
            //{
            //    if(tempArr2.Contains(num))
            //    {
            //        intersection.Add(num);
            //        tempArr2.Remove(num);
            //    }
            //}

            //Console.WriteLine(string.Join(" ", intersection));



            // Q10 :

            //List<int> nums = new List<int> { 1, 2, 3, 7, 5 };
            //int target = 12;

            //for (int start = 0; start < nums.Count; start++)
            //{
            //    int sum = 0;
            //    for(int end=start; end<nums.Count; end++)
            //    {
            //        sum += nums[end];
            //        if(sum==target)
            //        {
            //            List<int> subList = nums.GetRange(start, end - start + 1);
            //            Console.WriteLine(string.Join(" ", subList));
            //            return;
            //        }
            //    }
            //}


            // Q11 :

            //Queue<int> queue = new Queue<int>(new int[] { 1, 2, 3, 4, 5 });
            //int K = 3;

            //ReverseFirstK(queue, K);
            //Console.WriteLine(string.Join(" ", queue));

        }
    }
}

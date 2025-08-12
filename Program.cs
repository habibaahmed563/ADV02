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
        }
    }
}

namespace ADV02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Q1 :

            string[] firstLine = Console.ReadLine().Split();
            int N = int.Parse(firstLine[0]);
            int Q = int.Parse(firstLine[1]);

            string[] array = Console.ReadLine().Split();
            int[] arr = new int[N];

            for(int i=0; i<N ; i++)
            {
                arr[i] = int.Parse(array[i]);
            }

            for (int i = 0; i < Q; i++)
            {
                int count = 0;
                int x = int.Parse(Console.ReadLine());
                
                for(int j=0; j<N; j++)
                {
                    if(arr[j] > x)
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
            }



        }
    }
}

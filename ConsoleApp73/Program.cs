namespace ConsoleApp73
{
    class Program
    {

        class List
        {
            private int[] Arr = new int[4];
            public int count = 0;
            public int size = 0;

   
            public void Add(int value)
            {
                if (count == Arr.Length - 1)
                {
                    int[] newarr = new int[count];
                    for (int i = 0; i < count; i++)
                    {
                        newarr[i] = Arr[i];
                    }
                    Arr = new int[Arr.Length * 2];

                    for (int i = 0; i < count; i++)
                    {
                        Arr[i] = newarr[i];
                    }

                    Arr[count++] = value;
                    size = Arr.Length;
                }
                else
                {
                    Arr[count++] = value;
                }
            }

            public int Get(int index)
            {
                return Arr[index - 1];
            }


            public void Remove(int index)
            {
                Arr[index-1] = 0;
            }


            public void Insert(int index, int value)
            {
                if (index > Arr.Length)
                {
                    int[] newarr = new int[count];
                    for (int i = 0; i < count; i++)
                    {
                        newarr[i] = Arr[i];
                    }
                    while (index >= Arr.Length)
                    {
                        Arr = new int[Arr.Length * 2];
                    }
                    for (int i = 0; i < count; i++)
                    {
                        Arr[i] = newarr[i];
                    }

                    Arr[index - 1] += value;
                    count++;
                }
                else
                {
                    Arr[index-1] += value;
                }

                size = Arr.Length;
            }

        }





        static void Main()
        {

            List l1 = new List();

            l1.Add(1);
            l1.Add(1);
            l1.Add(1);
            l1.Add(1);
            l1.Add(6);
            l1.Add(1);
            Console.WriteLine($"Size - {l1.size} \n{l1.Get(6)}");
            l1.Insert(19,1);
            Console.WriteLine(l1.Get(5));
            Console.WriteLine(l1.size);
        }
    }
}
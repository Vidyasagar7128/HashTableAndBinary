using System;

namespace HashTableAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hash Table!");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");List<string> str = new List<string>();
            string freq = "";
            int count = 1;
            for(int i = 0; i <= 5; i++)
            {
                str.Add(hash.Get(i.ToString()));
                Console.WriteLine(str[i]);
            }
            for(int i = 0; i < str.Count; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    if (str[i] == str[j])
                    {
                        freq = str[j];
                        count++;
                    }
                }
            }
            Console.WriteLine($"{freq} : {count}");
        }
    }
}

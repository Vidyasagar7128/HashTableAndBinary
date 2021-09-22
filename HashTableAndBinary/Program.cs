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
            hash.Add("5", "be");
            string hash5 = hash.Get("5");
            Console.WriteLine("Fifth index is: {0} ", hash5);
            string hash2 = hash.Get("2");
            Console.WriteLine("Second index is: {0} ", hash2);
        }
    }
}

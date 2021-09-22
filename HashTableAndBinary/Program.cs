using System;

namespace HashTableAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hash Table!");
            int key = 0;
            string originalParagraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] paragraph = originalParagraph.Split(" ");
            MyMapNode<int, string> hash = new MyMapNode<int, string>(paragraph.Length);

            foreach (string word in paragraph)
            {
                hash.Add(key, word);
                key++;
            }
            for (key = 0; key < paragraph.Length; key++)
            {
                string value = hash.Get(key);
                Console.WriteLine($"Frequency of Words : '{value}' is {key}");
            }
        }
    }
}

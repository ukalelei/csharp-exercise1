using System;

namespace exercise1_search_strings
{
    class Program
    {
        static void Main(string[] args)
        {

            string AliceString = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            string input;
            string LowerCased;
            int InputIndex;
            int InputLength;

            Console.WriteLine("Search a term that's in the passage below:");
            Console.WriteLine($"\"{AliceString}\"");
            input = Console.ReadLine();
            LowerCased = input.ToLower();

            if ((AliceString.ToLower()).Contains(LowerCased))
            {
                InputIndex = (AliceString.ToLower()).IndexOf(LowerCased);
                InputLength = LowerCased.Length;

                Console.WriteLine("Search term found");
                Console.WriteLine(true);
                Console.WriteLine("Index: " + InputIndex);
                Console.WriteLine("Length: " + InputLength);
                Console.WriteLine(AliceString.Remove(InputIndex, InputLength));
           
            }

            //Console.WriteLine(LowerCased);

        }
    }
}

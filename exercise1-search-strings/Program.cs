using System;

namespace exercise1_search_strings
{
    class Program
    {
        static void Main(string[] args)
        {

            string aliceSentence = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            string input;
            string lowerCased;
            int inputIndex;
            int inputLength;

            while (aliceSentence.Length > 0)
            {
                Console.WriteLine("Search a term that's in the passage below:");
                Console.WriteLine($"\"{aliceSentence}\"");
                input = Console.ReadLine();
                lowerCased = input.ToLower();


                if ((aliceSentence.ToLower()).Contains(lowerCased))
                {
                    inputIndex = (aliceSentence.ToLower()).IndexOf(lowerCased);
                    inputLength = lowerCased.Length;

                    Console.WriteLine("Search term found");
                    Console.WriteLine(true);
                    Console.WriteLine("Index: " + inputIndex);
                    Console.WriteLine("Length: " + inputLength);

                    aliceSentence = aliceSentence.Remove(inputIndex, inputLength);
                    Console.WriteLine(aliceSentence);

                }

            }
        }
    }
}

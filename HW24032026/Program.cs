using System.IO.Compression;
#pragma warning disable
namespace dbguivned
{
        class Program
    {
        static void Algorithm(string input)
        {
            // Breaks input into a list of chars
            List<char> chars = new List<char>();
            for (int n = 0; n < input.Length; n++)
            {
                chars.Add(input[n]);
            }
            
            //
            int currentPoint = 0;
            int count = 1;
            bool finished = false;
            while(finished == false && currentPoint+1 < chars.Count())
            {
                // Gets the number of chars next to each other
                if(chars[currentPoint] == chars[currentPoint + 1])
                {    
                    currentPoint = 0;
                    count = 1;
                    while(chars[currentPoint] == chars[currentPoint + 1]);
                    {
                        count++;
                        currentPoint++;
                    }
                    Console.Write($"{chars[currentPoint]} {count} ");
                }
                else
                {
                    Console.Write($"{chars[currentPoint]} 1 ");
                    
                    if(currentPoint+1 > chars.Count()){finished = true;}else{currentPoint++;}
                }
            }

            
            
            
        }
        static void Main()
        {
            Console.WriteLine("Enter string pls");
            Console.Write(">>> "); string input = Console.ReadLine();
            Algorithm(input);
        }
    }
}


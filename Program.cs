using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Myclass
    {
        public static void Main(string[] args)
        {
            string full = "I am using hackerrank to improve programming";
            string partial = "am hackerrank to improve";
            List<string> answer = new List<string>();
            answer = missingwords(full, partial);
            for (int i = 0; i < answer.Count; i++)
            {
                Console.WriteLine(answer[i]);
            }
            Console.ReadLine();

        }
        public static List<String> missingwords(String full, String partial)
        {

            String[] partialWords = partial.Split(' ');
            String[] fullWords = full.Split(' ');
            List<string> missingWords = new List<string>();
           
            for (int i = 0; i < fullWords.Length; i++)
            {
                if (!partialWords.Contains(fullWords[i]))
                {
                    missingWords.Add(fullWords[i]);
                }
            }
            return missingWords;
        }
    }
}

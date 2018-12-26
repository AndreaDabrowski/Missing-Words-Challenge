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
            string t = "I am using hackerrank to improve programming";
            string s = "am hackerrank to improve";
            List<string> answer = new List<string>();
            answer = missingwords(t, s);
            for (int i = 0; i < answer.Count; i++)
            {
                Console.WriteLine(answer[i]);
            }
            Console.ReadLine();

        }
        public static List<String> missingwords(String t, String s)
        {

            String[] partialWords = s.Split(' ');
            String[] fullWords = t.Split(' ');
            List<string> missingWords = new List<string>();
            List<string> actualmissingWords = new List<string>();
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

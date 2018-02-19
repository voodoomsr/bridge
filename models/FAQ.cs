using System;
using System.Collections.Generic;

namespace models
{
    public class FAQ : IManuscript
    {
        public string Title { get; set; }
        public Dictionary<string, string> Questions { get; set; }

        public FAQ()
        {
            Questions = new Dictionary<string, string>();
        }

        public void Print()
        {
            Console.WriteLine("Title: {0}", Title);
            foreach (var question in Questions)
            {
               Console.WriteLine(" Question: {0}", question.Key);
               Console.WriteLine(" Answer: {0}", question.Value); 
            }
            Console.WriteLine();
        }
    }
}

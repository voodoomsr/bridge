using System;
using models;
using System.Collections.Generic;

namespace consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            var documents = new List<Manuscript>();
            var formatter = new StandardFormatter();
            var reverseFormatter = new ReverseFormatter();

            var faq = new FAQ(formatter);
            faq.Title = "The Bridge Pattern FAQ";
            faq.Questions.Add("What is it?", "A design pattern");
            faq.Questions.Add("When do we use it?", "When you need to separate an bastraction from an implementation");
            documents.Add(faq);

            var book = new Book(formatter)
            {
                Title = "Lots of Patterns", 
                Author = "John Sonmez",
                Text = "Bla bla bla"
            };
            documents.Add(book);

            var paper = new TermPaper(reverseFormatter)
            {
                Class = "Design Patterns",
                Student = "Joe N00b", 
                Text = "Bla bla bla", 
                References = "GOF"  
            };

            documents.Add(paper);

            foreach (var doc in documents)
            {
                doc.Print();
            }
        }
    }
}

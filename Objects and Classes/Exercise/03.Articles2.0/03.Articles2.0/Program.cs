using System;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections.Generic;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var currentArticle = Console.ReadLine().Split(", ").ToArray();
                Article article = new Article(currentArticle[0], currentArticle[1], currentArticle[2]);
                articles.Add(article);
            }
            string sortBy = Console.ReadLine();

            if (sortBy == "title")
            {
                Console.WriteLine(string.Join(Environment.NewLine, articles.OrderBy(i => i.Title)));
            }
            else if (sortBy == "content")
            {
                Console.WriteLine(string.Join(Environment.NewLine, articles.OrderBy(i => i.Content)));
            }
            else
            {
                Console.WriteLine(string.Join(Environment.NewLine, articles.OrderBy(i => i.Author)));
            }
        }
    }

    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}

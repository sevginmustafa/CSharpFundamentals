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
            string title = Console.ReadLine();
            string content = Console.ReadLine();
            string input = string.Empty;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<h1>");
            sb.AppendLine("    " + title);
            sb.AppendLine("</h1>");
            sb.AppendLine("<article>");
            sb.AppendLine("     " + content);
            sb.AppendLine("</article>");

            while ((input = Console.ReadLine()) != "end of comments")
            {
                sb.AppendLine("<div>");
                sb.AppendLine("     " + input);
                sb.AppendLine("</div>");
            }

            Console.WriteLine(sb);
        }
    }
}

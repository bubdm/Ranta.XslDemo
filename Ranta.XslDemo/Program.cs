using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace Ranta.XslDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunExample1();

            RunExample2();
        }

        static void RunExample1()
        {
            XslCompiledTransform transform = new XslCompiledTransform();

            transform.Load("Example_1\\style.xslt");

            StringBuilder output = new StringBuilder();

            using (StringWriter writer = new StringWriter(output))
            {
                transform.Transform("Example_1\\data.xml", new XsltArgumentList { }, writer);
            }

            Console.WriteLine(output.ToString());

            string text = output.ToString();

            Console.WriteLine(".......................");

            Console.Read();
        }

        static void RunExample2()
        {
            XslCompiledTransform transform = new XslCompiledTransform();

            transform.Load("Example_2\\style.xslt");

            StringBuilder output = new StringBuilder();

            using (StringWriter writer = new StringWriter(output))
            {
                transform.Transform("Example_2\\article.xml", new XsltArgumentList { }, writer);
            }

            Console.WriteLine(output.ToString());

            string text = output.ToString();

            Console.WriteLine(".......................");

            Console.Read();
        }
    }
}

using STree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1
{
    class Program
    {
        static void Main(string[] args)
        {
            SharedLogging.Logger logger = new SharedLogging.Logger();
            logger.WriteToFile("D:\\test.log", "I'm testing local logging from Solution M1");
            
            Helper.SharedHelper helper = new Helper.SharedHelper();
            Console.WriteLine(helper.GetLength("hello"));

            SubTree s = new SubTree();
            s.PrintSubTree();

            Console.ReadLine();
        }
    }
}

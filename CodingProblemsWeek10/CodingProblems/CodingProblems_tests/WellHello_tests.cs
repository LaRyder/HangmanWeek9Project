using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems_tests
{
    [TestClass]
    public static class WellHello_tests
    {
        [TestMethod]
        public static string Reverse(this string str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }

    public class Hello
    {
        public void Get_reverse_Answer()
        {
            string str = "hello";

            string reverse = str.Reverse();
            Console.WriteLine(reverse);
        }
    }
}

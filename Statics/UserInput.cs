using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseNoteSorter.Statics
{
    internal static class UserInput
    {
        public static string GetString()
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input != "")
                    return input;
                Console.WriteLine("No text. Enter in a text");
            }
        }
        public static int GetInt()
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (Int32.TryParse(input, out var i))
                    return i;
                Console.WriteLine("No number. Enter in a number");
            }
        }
    }
}

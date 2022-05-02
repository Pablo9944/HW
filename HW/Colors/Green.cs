using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW.Colors
{
    public static class Green
    {
        public static void GreenMessage (string message)
        {
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(message);
                Console.ResetColor();
            }
        }

    }

}

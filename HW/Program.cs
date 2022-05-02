using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Тут чёрт ногу сломит,но я старался=)

            Start();
     
        }
    
        static void Start()
        {

            Title title = new Title(new Basket());
            title.WelcomeTitle();
            
             
        }
    }
}

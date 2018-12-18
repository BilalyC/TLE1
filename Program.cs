using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] week = new string[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };
            /*string[] week = new string[7];
             * week[0] = "Lundi";
             * week[1] = "Mardi";
             * week[2] = "Mercredi";
             * week[3] = "Jeudi";
             * week[4] = "Vendredi";
             * week[5] = "Samedi";
             * week[6] = "Dimanche";
             **/
            for (int i = 0; i < week.Length; i++)
            {
                Console.WriteLine(week[i]);
            }
        }
    }
}

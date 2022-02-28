using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//shits buggy
namespace SinWave
{
    class Program
    {
        static void Main(string[] args)
        {
            double SinPoint = 0;
            string[] Lines = new string[18];
            float Inc = 0.40f;
            Console.SetWindowSize(45, 21);
            Console.Out.WriteLine("Traksjfhjkahsdfjkasjkhdfjk");
            int i = 0;
            while (true)
            {
                double SinValue = Math.Sin(SinPoint);
                string newline = "sin(" + String.Format("{0:0.00}", SinPoint) + ")= " + String.Format("{0:0.00}", SinValue);
                int SpaceAmount = 10;
                SpaceAmount += Convert.ToInt32(Math.Truncate(SinValue * 10));
                for(int j = SpaceAmount; j >= 0; j--)
                {
                    newline = " " + newline;
                }


                if(i == 17)
                {
                    for(int k = 0; k < Lines.Length-1; k++)
                    {
                        string frontline = Lines[k+1];
                        Lines[k] = frontline;
                    }
                }
                Lines[i] = newline;

                foreach (string Line in Lines)
                {

                    Console.Write("\r{0}%" + newline + "                          ", i);
                }

                System.Threading.Thread.Sleep(100);
                SinPoint += Inc;
                if(i <17) i++;
            }
            Console.ReadKey();
        }
    }
}

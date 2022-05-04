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
            Console.CursorVisible = false;
            int PaddingX = 15;
            int PaddingY = 5;
            double SinPoint = 0;
            string[] Lines = new string[18];
            float Inc = 0.20f;
            Console.SetWindowSize(45+(PaddingX*2), 21+(PaddingY*2));
            Console.SetCursorPosition(PaddingX, PaddingY);
            Console.Out.Write("{  [Sine Waves] Created By Parker Straus   }");
            Console.SetCursorPosition(PaddingX, PaddingY+1);
            Console.Out.Write("--------------------------------------------");
            int i = 0;
            while (true)
            {
                double SinValue = Math.Sin(SinPoint);
                string newline = "sin(" + String.Format("{0:0.00}", SinPoint) + ")= " + String.Format("{0:0.00}", SinValue);
                int SpaceAmount = 13;
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

                int pos = 0;

                foreach (string Line in Lines)
                {
                    Console.SetCursorPosition(0+PaddingX, pos+2+PaddingY);
                    Console.Write(Line + "                          "+"\r");
                    pos++;
                }

                System.Threading.Thread.Sleep(50);
                SinPoint += Inc;
                if(i <17) i++;
            }
            Console.ReadKey();
        }
    }
}

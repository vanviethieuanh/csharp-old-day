using System;
using System.Drawing;

namespace bit
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = @"v.png";
            Bitmap bitmap = new Bitmap(source);
            for (int i = 0; i< bitmap.Height - 1;i++)
            {
                for (int j = 0; j < bitmap.Width-1;j++)
                {
                    Color current = bitmap.GetPixel(j,i);
                    int sum = current.R + current.G + current.B;
                    if (sum > 564)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(0);
                    }
                    if (sum <= 564 && sum > 150)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write(0);
                    }
                    if (sum <= 150 && sum > 1) {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(0);
                    }
                    if (sum <= 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(0);
                    }
                    
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}


using ConsoleColorsExtension;

using System;
internal class Program
{
    private static void Main(string[] args) {
       border_layout();
    }
         public static void border_layout(){ // -> Creates a solid layout
          //Console.Clear();
   

            Console.SetCursorPosition(0, 0);

            //Console width and height 
            int aa = 120; // Width 
            int bb = 25; // Height

            //Cursor position in default
            int def_width = 2;
            int def_height = 2;


            Console.SetWindowSize(aa, bb);
            Console.SetBufferSize(aa, bb);
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Gray;
            for (int a = 0; a < Console.WindowWidth - 1; a++)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("#");
                Thread.Sleep(0);

            }
            for (int b = 0; b < Console.WindowHeight; b++)
            {
                Console.WriteLine("#");

            }

            for (int c = 0; c < Console.WindowHeight; c++)
            {
                Console.SetCursorPosition(aa - 1, c);
                Console.WriteLine("#");

            }

            for (int d = 0; d < Console.WindowWidth; d++)
            {
                Console.Write("#");

            }
            Console.SetCursorPosition(def_width, def_height);
            Console.ResetColor();

           
         }
    }

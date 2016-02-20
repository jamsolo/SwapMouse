using System;
using System.Runtime.InteropServices;

namespace SwapMouse
{
    /// <summary>
    /// Program to quickly change mouse buttons
    /// </summary>
    class Program
    {
        [DllImport("user32.dll")]
        public static extern Int32 SwapMouseButton(Int32 bSwap);
        [DllImport("user32.dll")]
        public static extern Int32 GetSystemMetrics(Int32 Value);
        static void Main(string[] args)
        {
            Console.WriteLine("+----------------------------------------+");
            Console.WriteLine("|            SwapMouse 1.0               |");
            Console.WriteLine("|----------------------------------------|");
            Console.WriteLine("| This Program swaps the mouse buttons.  |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("| Created by: William Krebbers           |");
            Console.WriteLine("| Version   : 1.0 2015                   |");
            Console.WriteLine("+----------------------------------------+");
            try
            {
                bool swapped = GetSystemMetrics(23) != 0;
            
                if (swapped)
                {
                    SwapMouseButton(0);
                    Console.WriteLine("MouseButtons swapped back to default");
                }
                else
                {
                    SwapMouseButton(1);
                    Console.WriteLine("MouseButtons swapped");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error swapping mousebuttons");
                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();
            }


        }
    }
}

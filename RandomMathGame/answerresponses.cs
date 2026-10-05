using System;
using System.Runtime.InteropServices;

namespace RandomMathGame
{
    public class answers
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

        static public void Good()
        {
            // nothing, good continues loldhjkby hjf gtzwqrvztfcztrec zdwftwad zdft 
        }

        static public void Bad()
        {
            MessageBox(IntPtr.Zero, "Wrong", "Random Math Game", 0x00000030);
            Environment.Exit(0);
        }
    }
}
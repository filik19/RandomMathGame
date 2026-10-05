using System;
using System.Runtime.InteropServices;

namespace RandomMathGame
{
    public class easyq
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

        static public void q1()
        {
            int q1 = MessageBox(IntPtr.Zero, "15+15 = ?\n\nYes = 21\nNo = 30", "Random Math Game", 0x00000004 | 0x00000020);

            switch (q1)
            {
                case 6:
                    Console.WriteLine("[DEBUG] q1");
                    answers.Bad();
                    break;
                case 7:
                    Console.WriteLine("[DEBUG] q1");
                    easyq.q2();
                    break;
            }
        }

        static public void q2()
        {
            int q2 = MessageBox(IntPtr.Zero, "100+100 = ?\n\nYes = 987\nNo = 200", "Random Math Game", 0x00000004 | 0x00000020);

            switch (q2)
            {
                case 6:
                    Console.WriteLine("[DEBUG] q2");
                    answers.Bad();
                    break;
                case 7:
                    Console.WriteLine("[DEBUG] q2");
                    easyq.q3();
                    break;
            }
        }

        static public void q3()
        {
            int q3 = MessageBox(IntPtr.Zero, "69x69 = ?\n\nYes = 3951\nNo = 4761", "Random Math Game", 0x00000004 | 0x00000020);

            switch (q3)
            {
                case 6:
                    Console.WriteLine("[DEBUG] q2");
                    answers.Bad();
                    break;
                case 7:
                    Console.WriteLine("[DEBUG] q2");
                    easyq.q4();
                    break;
            }
        }

        static public void q4()
        {
            
        }

        static public void q5()
        {

        }

    }
}
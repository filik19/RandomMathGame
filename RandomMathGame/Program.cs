using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RandomMathGame
{
    public class Program
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);
        static public void Main()
        {
            Console.WriteLine("[DEBUG] prompting user with difficulty popup");
            int response1 = MessageBox(IntPtr.Zero, "Pick a number\n\nYes = 1\nNo = 2", "Random Math Game: difficulty selection", 0x00000004 | 0x00000020);

            switch (response1)
            {
                case 6:
                    Console.WriteLine("[DEBUG] diff: easy");
                    MessageBox(IntPtr.Zero, "Choosen difficulty: EASY AS FUCK", "Random Math Game", 0x00000030);
                    int responseeasy1 = MessageBox(IntPtr.Zero, "1+1 = ?\n\nYes = 2\nNo = 69", "Random Math Game", 0x00000004 | 0x00000020);

                    switch (responseeasy1)
                    {
                        case 6:
                            Console.WriteLine("[DEBUG] responseeasy1");
                            MessageBox(IntPtr.Zero, "okay, that was a test. now the real thing...", "Random Math Game", 0x00000030);
                            easyq.q1();
                            break;
                        case 7:
                            Console.WriteLine("[DEBUG] responseeasy1");
                            answers.Bad();
                            break;
                    }
                    break;
                case 7:
                    Console.WriteLine("[DEBUG] diff: impossible");
                    MessageBox(IntPtr.Zero, "Choosen difficulty: IMPOSSIBLE (baldiz basics version)", "Random Math Game", 0x00000030);
                    MessageBox(IntPtr.Zero, "Sorry, but this difficulty is not yet implemented.\n\nResetting program", "Random Math Game", 0x00000030);
                    Console.WriteLine("[INFO] Resetting application to Program.Main...\n\n\n");
                    Program.Main();
                    break;
            }
        }
    }
}

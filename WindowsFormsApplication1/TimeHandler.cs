using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class TimeHandler 
    {
        public static Stopwatch stopWatch = new Stopwatch();

        
        public static void StartTime()
        {
            string startString = GetNowTime()+"\t\t";           
            WriteToFile(startString, 1);
            stopWatch.Start();
            Console.WriteLine(stopWatch.IsRunning);

        }

        public static void StopTime()
        {
            Console.WriteLine(stopWatch.IsRunning);
            
            stopWatch.Stop();
            string escapedTime = stopWatch.Elapsed.TotalMilliseconds.ToString();
            Console.WriteLine(escapedTime);
            string stopString = GetNowTime() + "\t\t" +escapedTime;
            WriteToFile(stopString,1);
            Console.WriteLine(stopWatch.IsRunning);

        }



        private static void WriteToFile(string inputString,int i)
        {
            string path = "e:\\Log.txt";

            using (StreamWriter swa = File.AppendText(path))
            {
                if (i == 0)
                {
                    swa.Write(inputString);
                }
                else
                {
                    swa.WriteLine(inputString);
                }

            }
        }

        private static string GetNowTime()
        {
            DateTime nowTime = DateTime.Now;
            CultureInfo info = new CultureInfo("en-US");
            return nowTime.ToString(info);

        }


    }
}

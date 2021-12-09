using System;
using System.Text;
using MomentCS;
using MomentCS.Time;
using MomentCS.Formats;

namespace TestingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Build static TimeZones
            //foreach (String line in System.IO.File.ReadLines(@"C:\Source\MomentCS\TestingApp\TimesZones.txt"))
            //{
            //    //Get Offset
            //    int pFrom = line.IndexOf("data-offset=\"") + "data-offset=\"".Length;
            //    int pTo = line.LastIndexOf("\" ");

            //    String Offset = line.Substring(pFrom, pTo - pFrom);

            //    //Get TimeZoneName
            //    int pFrom1 = line.IndexOf("value=\"") + "value=\"".Length;
            //    int pTo1 = line.LastIndexOf("\">");

            //    String TimeZoneName = line.Substring(pFrom1, pTo1 - pFrom1);
            //    TimeZoneName = TimeZoneName.Replace(" ", "");

            //    StringBuilder sb = new StringBuilder();
            //    sb.Append(String.Format("public const int {0} = {1};", TimeZoneName, Offset));

            //    Console.WriteLine(sb);

            //    //Console.WriteLine(String.Format("{0} - {1}", TimeZoneName, Offset));
            //}
            int d = Moment.GetDateStamp();
            int t = Moment.GetTimeStamp();

            String dt = Moment.FormatDateAndTime(d, t, DateFormat.DDMMYYYY, TimeFormat.hhmmsstt, TimeZoneCS.UTC, "Todays Date: {Date}. Todays Time: {Time}");

            Console.WriteLine("Date: " + d);
            Console.WriteLine("Time: " + t);
            Console.WriteLine(dt);

        }
    }
}

using System;
using MomentCS.Formats;
using MomentCS.Time;

namespace MomentCS
{
    public static class Moment
    {
        /// <summary>
        /// Gets todays date in the number of days since 01/01/1900. Default Time is UTC.
        /// </summary>
        /// <param name="TimeZoneOffset">Pass in a timezone offset in the format of seconds. MomentCS.TimeZones</param>
        /// <returns></returns>
        public static int GetDateStamp(int TimeZoneOffset = TimeZoneCS.UTC)
        {
            DateTime start = DateTime.Parse(Definitions.StartDate);
            var DateToday = DateTime.UtcNow.AddSeconds(TimeZoneOffset);
            TimeSpan returnDate = DateToday - start;
            return (int)returnDate.TotalDays;
        }

        /// <summary>
        /// Format a momentCS DateStamp.
        /// </summary>
        /// <param name="Date"></param>
        /// <param name="pFormat"></param>
        /// <returns>A formatted date based on the day date MomentCS generates for you. Default format date: dd/MM/yyyy</returns>
        public static String FormatDate(int Date, String pFormat = DateFormat.Primary)
        {
            DateTime start = DateTime.Parse(Definitions.StartDate);
            DateTime answer = start.AddDays(Date);
            return answer.ToString(pFormat);
        }
    }
}

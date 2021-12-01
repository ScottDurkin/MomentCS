using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomentCS.Formats
{
    public class DateFormat
    {
        /// <summary>
        /// dd/MM/yyyy
        /// </summary>
        public const String Primary = "dd/MM/yyyy";

        /// <summary>
        /// MM/dd/yyyy
        /// </summary>
        public const String Secondary = "MM/dd/yyyy";




        /// <summary>
        /// 01
        /// </summary>
        public const String Day = "dd";
        /// <summary>
        /// Monday
        /// </summary>
        public const String DayNameLong = "dddd";
        /// <summary>
        /// Mon
        /// </summary>
        public const String DayNameShort = "ddd";



        /// <summary>
        /// 01
        /// </summary>
        public const String Month = "MM";
        /// <summary>
        /// January
        /// </summary>
        public const String MonthNameLong = "MMMM";
        /// <summary>
        /// Jan
        /// </summary>
        public const String MonthNameShort = "MMM";



        /// <summary>
        /// 2021
        /// </summary>
        public const String Year = "yyyy";
        /// <summary>
        /// 21
        /// </summary>
        public const String YearShort = "yy";
    }
}

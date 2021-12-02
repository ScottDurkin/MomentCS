using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomentCS.Formats
{
    public class DateFormat
    {
        /// <summary>Example: dd/MM/yyyy</summary>
        public const String Primary = "dd/MM/yyyy";
        /// <summary>Example: MM/dd/yyyy</summary>
        public const String Secondary = "MM/dd/yyyy";




        /// <summary>Example: 01</summary>
        public const String Day = "dd";
        /// <summary>Example: Monday</summary>
        public const String DayNameLong = "dddd";
        /// <summary>Example: Mon</summary>
        public const String DayNameShort = "ddd";



        /// <summary>Example: 01</summary>
        public const String Month = "MM";
        /// <summary>Example: January</summary>
        public const String MonthNameLong = "MMMM";
        /// <summary>Example: Jan</summary>
        public const String MonthNameShort = "MMM";



        /// <summary>Example: 2021</summary>
        public const String Year = "yyyy";
        /// <summary>Example: 21</summary>
        public const String YearShort = "yy";


        ///////////////////////////////////////////////////////////////////////////////////////////
        //  SECTION: Some predefined date formats
        //  PURPOSE: Less code to write, more reusable code.
        ///////////////////////////////////////////////////////////////////////////////////////////
        
        /// <summary>Example: 01/01/2021</summary>
        public const String DDMMYYYY = "dd/MM/yyyy";
        /// <summary>Example: 01/01</summary>
        public const String DDMM = "dd/MM";
        /// <summary>Example: 01/21</summary>
        public const String MMYY = "MM/yy";
        /// <summary>Example: 01/2021</summary>
        public const String MMYYYY = "MM/yyyy";

    }
}

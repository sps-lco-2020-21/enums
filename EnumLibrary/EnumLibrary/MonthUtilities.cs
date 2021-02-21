using System;
using System.Linq;

namespace EnumLibrary
{
    public static class MonthUtilities
    {
        public static Months NextMonth(Months current)
        {
            Months next = current + 1;
            return (Months)(((int)current + 1) % Enum.GetNames(typeof(Months)).Count());
        }

        // This is an extension method - the addition of the 'this' keyword makes for tastier syntatic sugar 
        public static Months NextMonthE(this Months current)
        {
            Months next = current + 1;
            return (Months)(((int)current + 1) % Enum.GetNames(typeof(Months)).Count());

            // see also https://stackoverflow.com/a/642621/2902 with the fabulous quote
            // "with LINQ as your hammer, the world is full of nails"
        }
    }
}

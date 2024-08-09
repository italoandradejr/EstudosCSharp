using System;


namespace ExtensionMethods_Udemy.Extensions
{
    static class StringExtensions
    {
        public static string Corte(this string EsteObj, int count)
        {
            if (EsteObj.Length <= count)
            {
                return EsteObj;
            }
            else
            {
                return EsteObj.Substring(0, count) + "...";
            }
        }
    }
}

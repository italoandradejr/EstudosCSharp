using System;
using System.Globalization;

namespace ExtensionMethods_Udemy.Extensions
{
    static class DateTimeExtensions
    {
        public static string TempoDecorrido(this DateTime esteObs)
        {
            TimeSpan duracao = DateTime.Now.Subtract(esteObs);

            if (duracao.TotalHours < 24.0) 
            {
                return duracao.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            }
            else
            {
                return duracao.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " Dias";
            }

        }
    }
}

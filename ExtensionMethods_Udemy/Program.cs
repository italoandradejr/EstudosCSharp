using ExtensionMethods_Udemy.Extensions;
using System;

public class ArquivoDeProcesso
{
    public static void Main()
    {
        DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45); // ano, mes, dia, hora, minuto, segundo
        Console.WriteLine(dt.TempoDecorrido());


        string s1 = "Bom dia estudantes";
        Console.WriteLine(s1.Corte(10));
    }
}
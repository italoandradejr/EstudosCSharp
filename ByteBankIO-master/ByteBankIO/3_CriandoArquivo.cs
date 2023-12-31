﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

partial class Program
{
    static void CriarArquivo()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";
        
        using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        {
            var ContaComoString = "456, 7895, 4785.40, Gustavo Santos";

            var encoding = Encoding.UTF8;

            var bytes = encoding.GetBytes(ContaComoString);

            fluxoDeArquivo.Write(bytes, 0, bytes.Length);
        }
    }

    static void CriarArquivoComWriter()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";

        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDeArquivo))
        {
            escritor.Write("456,65465,456.0,Pedro");
        }
        
    }



    static void TestaEscrita()
    {
        var caminhoNovoArquivo = "teste.txt";

        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDeArquivo))
        {
            for (int i=0; i < 10000000; i++)
            {
                escritor.WriteLine($"Linha {i}");
                escritor.Flush(); // despeja o buffer para o Stream
                Console.WriteLine($"linha {i} foi escrita no arquivo, tecle enter...");
                Console.ReadLine();
            }
        }
    }

}

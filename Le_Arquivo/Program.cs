using System;
using System.IO;

namespace Stream_Arquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"C:\Users\italo.andrade\Downloads\fire1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(caminho, FileMode.Open);
                sr = new StreamReader(fs);
                string linha = sr.ReadLine();
                Console.WriteLine(linha);
            }
            catch (IOException e)
            {
                Console.WriteLine("Um erro ocorreu");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if(sr != null) sr.Close();
                if(fs != null) fs.Close();
            }
        }
    }
}
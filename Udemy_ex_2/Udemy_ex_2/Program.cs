using System;
using Udemy_ex_2.Entities;

namespace Udemy_ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Comentario c1 = new Comentario("Tenha uma boa viagem");
            Comentario c2 = new Comentario("Wow Que maravilha!!");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Viajando para Nova Zelandia",
                "Estou indo visitar esse lindo País",
                12);

            p1.AddComentario(c1);
            p1.AddComentario(c2);

            Comentario c3 = new Comentario("Boa noite");
            Comentario c4 = new Comentario("Que a força esteja com vc");
            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Boa noite Pessoal",
                "Te vejo Amanhã",
                5);
            p2.AddComentario(c3);
            p2.AddComentario(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
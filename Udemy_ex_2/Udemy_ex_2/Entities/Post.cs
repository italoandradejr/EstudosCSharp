using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Udemy_ex_2.Entities
{
    class Post
    {
        public DateTime Momento { get; set; }
        public string Titulo { get; set; }
        public string Comentarios { get; set; }
        public int Likes { get; set; }
        public List<Comentario> Comente { get; set; } = new List<Comentario>();

        public Post()
        {
        }

        public Post(DateTime momento, string titulo, string comentarios, int likes)
        {
            Momento = momento;
            Titulo = titulo;
            Comentarios = comentarios;
            Likes = likes;
        }

        public void AddComentario(Comentario comentario)
        {
            Comente.Add(comentario);
        }

        public void RemoveComentario (Comentario comentario)
        {
            Comente.Remove(comentario);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Titulo);
            sb.Append(Likes);
            sb.Append("  Likes - ");
            sb.AppendLine(Momento.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Comentarios);
            sb.AppendLine("Comentarios: ");

            foreach (Comentario c in Comente)
            {
                sb.AppendLine(c.Texto);
            }
            return sb.ToString();
        }
    }
}

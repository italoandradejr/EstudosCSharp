using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
	public class Forma
	{
		public int X { get; private set; }
		public int Y { get; private set; }
		public int Altura { get; set; }
		public int Largura { get; set; }
		public int Raio { get; set; }


		public virtual void Desenhar()
		{
			Console.WriteLine("Preparando para desenhar");
		}

		public virtual void Area()
		{
			int area = Largura * Altura;
			Console.WriteLine("Área " + area);
		}
	}

	public class Circulo : Forma
	{
		public override void Desenhar()
		{
			base.Desenhar();
			Console.WriteLine("Desenhando um circulo");
		}

		public override void Area()
		{
			double area = 3.14 * (Raio * Raio);
			Console.WriteLine("Área Circulo " + area);
		}
	}


	public class Retangulo : Forma
	{
		public override void Desenhar()
		{
			base.Desenhar();
			Console.WriteLine("Desenhando um Retangulo");
		}

		public override void Area()
		{
			base.Area();
		}
	}

	public class Triangulo : Forma
	{
		public override void Desenhar()
		{
			base.Desenhar();
			Console.WriteLine("Desenhando um Triangulo");
		}

		public override void Area()
		{
			int area = (Largura * Largura) / 2;
			Console.WriteLine("Área Retangulo " + area);
		}
	}

}

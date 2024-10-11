using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversao
{
	class Program
	{
		static void Main(string[] args)
		{
			#region
			byte num1 = 100; // 8 bits, de 0 a 255
			ushort num2; //16 bits, 0 a 65.535

			float num3 = 1250.45f;
			double num4 = num3;

			num2 = num1;
			#endregion

			ushort num5 = 500;
			byte num6 = (byte)num5;

            Console.WriteLine(num6); // haverá perda de dados
			Console.ReadKey();


			Convert.

		}
	}
}

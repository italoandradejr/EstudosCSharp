using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipularString
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnExecutar_Click(object sender, EventArgs e)
		{

			//string nome = "Italo de andrade";

			//string nomeFinal = nome.Insert(0, "Silva ");

			//label1.Text = nomeFinal;

			//string nome = "Italo";
			//int qta = nome.Length;

			//label1.Text = nome + " = " + qta;

			//for (int i = 0; i < nome.Length; i++)
			//{
			//	label1.Text += nome[i] + "\n";
			//}


			string nomes = "Gabriel Italo Dani, Arthur Glória Bianca Flavio";
			char[] separador = { ' ' };
			
			string[] resultado = nomes.Split(separador);

			foreach (string nome in resultado) 
			{
				label1.Text += nome + "\n";
			}

		}
	}
}

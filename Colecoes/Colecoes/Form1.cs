using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colecoes
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnList_Click(object sender, EventArgs e)
		{
			lista.Items.Clear();

			//Array
			string[] nomes = new string[3];
			nomes[0] = "Italo";
			nomes[1] = "Gabriel";
			nomes[2] = "Rachel";

			// Lista Generica
			List<string> nomes2 = new List<string>();

			nomes2.Add("Rennan");
			nomes2.Add("Bete");
			nomes2.AddRange(nomes);

			//nomes2.Remove("Bete");

			//if(nomes2.Contains("Rachel"))
			//{
			//	MessageBox.Show("Contém");
			//}
			//else
			//{
			//	MessageBox.Show("Não Contém");
			//}

			//MessageBox.Show("Numero de elementos: " + nomes2.Count());
			//nomes2.Sort(); // coloca em ordem alfabetica

			//MessageBox.Show("Gabriel está no indice: " + nomes2.IndexOf("Gabriel"));

			//nomes2.Insert(2, "João");

			//nomes2.RemoveAt(1); //remove com base no indice

			//nomes2.Clear();

			foreach (string nome in nomes2)
			{
				lista.Items.Add(nome);
			}
		}
	}
}

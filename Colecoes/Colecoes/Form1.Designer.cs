namespace Colecoes
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.lista = new System.Windows.Forms.ListBox();
			this.btnList = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lista
			// 
			this.lista.FormattingEnabled = true;
			this.lista.ItemHeight = 16;
			this.lista.Location = new System.Drawing.Point(17, 16);
			this.lista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.lista.Name = "lista";
			this.lista.Size = new System.Drawing.Size(630, 404);
			this.lista.TabIndex = 0;
			// 
			// btnList
			// 
			this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnList.Location = new System.Drawing.Point(666, 16);
			this.btnList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(169, 53);
			this.btnList.TabIndex = 1;
			this.btnList.Text = "List";
			this.btnList.UseVisualStyleBackColor = true;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(849, 437);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.lista);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Listas Genericas";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lista;
		private System.Windows.Forms.Button btnList;
	}
}


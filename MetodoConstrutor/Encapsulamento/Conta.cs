﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
	class Conta
	{
		private string _cliente;
		private double _saldo;
		private double _taxa = 10;

		public string Cliente
		{
			get { return _cliente; }
			set
			{
				if(value != "italo" && value != "rachel")
				{
					_cliente = "visitante";
					Saldo = 0;
				}
				else
				{
					_cliente = value;
					Saldo = 200;
				}
			}
		}

		public double Saldo
		{
			get
			{
				return _saldo;
			}
			private set
			{
				_saldo = value;
			}
		}

		public void Sacar(double valor)
		{
			valor += _taxa;
			_saldo -= valor;
		}

		public void Depositar(double valor)
		{
			_saldo += valor;
		}
	}
}

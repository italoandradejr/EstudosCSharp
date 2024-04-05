using System.Collections.Generic;
using System;
using Ex_01_Udemy.Entities.Enums;


namespace Ex_01_Udemy.Entities
{
     class Trabalhador
    {
        public string Nome { get; set; }
        public NivelTrabalhador Level { get; set; }
        public double BaseSalarial { get; set; }
        public Departamento Departamento { get; set; }
        public List<ContratoDeHora> Contratos { get; set; } = new List<ContratoDeHora>();

        public Trabalhador ()
        {

        }

        public Trabalhador(string nome, NivelTrabalhador level, double baseSalarial, Departamento departamento)
        {
            Nome = nome;
            Level = level;
            BaseSalarial = baseSalarial;
            Departamento = departamento;
        }

        public void AddContratos(ContratoDeHora contratos)
        {
            Contratos.Add(contratos);
        }

        public void RemoveContrato (ContratoDeHora contratos)
        {
            Contratos.Remove(contratos);
        }

        public double Renda (int ano, int mes)
        {
            double soma = BaseSalarial;
            foreach (ContratoDeHora contrato in Contratos)
            {
                if(contrato.Data.Year == ano && contrato.Data.Month == mes)
                {
                    soma += contrato.ValorTotal();
                }
            }
            return soma;
        }
    }
}

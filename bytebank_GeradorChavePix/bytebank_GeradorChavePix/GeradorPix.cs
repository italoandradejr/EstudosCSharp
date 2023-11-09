using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_GeradorChavePix
{
    /// <summary>
    /// Classe que gera chaves Pix, usando o formato Guid.
    /// </summary>
    public static class GeradorPix
    {
        /// <summary>
        /// Método que retorna uma chava aleatória de Pix.
        /// </summary>
        /// <returns>Retorna uma chave Pix no formato string.</returns>
        public static string GetChavePix()
        {
            return Guid.NewGuid().ToString();
        }

        /// <summary>
        /// Método que retorna uma lista aleatória de chaves Pix.
        /// </summary>
        /// <param name="numeroDeChaves">Quantidade de chaves a serem geradas</param>
        /// <returns>Lista de Strings de Chaves Pix.</returns>
        public static List<string> GetChavesPix(int numeroDeChaves)
        {
            if (numeroDeChaves <= 0)
            {
                return null;
            }
            else
            {
                var chaves = new List<string>();
                for (int i = 0; i < numeroDeChaves;  i++)
                {
                    chaves.Add(Guid.NewGuid().ToString());
                }

                return chaves;
            }

        }
    }
}
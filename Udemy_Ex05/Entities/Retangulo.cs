
using Udemy_Ex05.Entities.Enums;

namespace Udemy_Ex05.Entities
{
     class Retangulo : Figura
    {
        public double Largura {  get; set; }
        public double Altura { get; set; }

        public Retangulo(double largura, double altura, Cor cor) : base(cor)
        {
            Largura = largura;
            Altura = altura;
        }


        public override double Area()
        { 
            return Largura * Altura;
        }
    }
}

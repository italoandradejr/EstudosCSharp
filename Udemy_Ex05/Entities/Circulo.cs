using Udemy_Ex05.Entities.Enums;

namespace Udemy_Ex05.Entities
{
    class Circulo : Figura
    {
        public double Raio {  get; set; }

        public Circulo(double raio, Cor cor) : base(cor)
        {
            Raio = raio;
        }

        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }

    }
}

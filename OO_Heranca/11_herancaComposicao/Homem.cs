

namespace _11_herancaComposicao
{
    public class Homem : Animal
    {
        private readonly ComportamentoAndar _comportamentoAndar;

        public Homem(ComportamentoAndar comportamentoAndar)
        {
            _comportamentoAndar = comportamentoAndar;
        }

        public void Locomocao()
        {
            Console.WriteLine(nameof(Homem));
            _comportamentoAndar.Andar();
        }
    }
}

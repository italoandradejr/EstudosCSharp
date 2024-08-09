
namespace RestricoesUdemy.Services
{
    class CalculationService
    {
        public T Maximo<T>(List<T> listap) where T : IComparable
        {
            if (listap.Count == 0)
            {
                throw new ArgumentException("A lista não pode estar vazia");
            }

            T max = listap[0];
            for (int i = 1; i < listap.Count; i++)
            {
                if(listap[i].CompareTo(max) > 0)
                {
                    max = listap[i];
                }
            }
            return max;
        }
    }
}

using System;

namespace HashSet_Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            ImprimirColecao(a);

            //union
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            ImprimirColecao(c);

            //intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            ImprimirColecao(d);

            //Diferrence
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            ImprimirColecao(e);
        }

        static void ImprimirColecao<W>(IEnumerable<W> colecao)
        {
            foreach (W objeto in colecao)
            {
                Console.Write(objeto + " ");
            }
            Console.WriteLine();
        }
    }
}



ClasseGenerica<int> objInt = new ClasseGenerica<int>();

objInt.Adicionar(10);
objInt.Adicionar(20);
objInt.Adicionar(30);
objInt.Adicionar(40);
objInt.Adicionar(50);

Console.WriteLine("Classe classeGenerica<T> de objetos int\n");

for(int i = 0; i < 5; i++)
{
    Console.WriteLine(objInt[i]);
}

Console.ReadKey();


public class ClasseGenerica<T>
{
    // definição do array com 5 elementos
    T[] obj = new T[5];
    int contador = 0;

    //adicionar elementos
    public void Adicionar(T item)
    {
        if (contador < 5)
        {
            obj[contador] = item;
        }
        contador++;
    }

    // indexador
    public T this[int index]
    {
        get { return obj[index]; }
        set { obj[index] = value; }
    }
}
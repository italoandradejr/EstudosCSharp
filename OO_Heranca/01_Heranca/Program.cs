
ClasseDerivada cd = new ClasseDerivada();

cd.VerificaAcesso();


Console.ReadKey();

public class ClasseDerivada : ClasseBase
{
    public void VerificaAcesso()
    {
        Public_Membro();
        Protected_Membro();
        Protected_Internal_Membro();
        Internal_Membro();
        AcessaPrivate();
    }
}


public class ClasseBase
{
    public void Public_Membro()
    {
        Console.WriteLine("ClasseBase - Método Public");
    }

    protected void Protected_Membro()
    {
        Console.WriteLine("ClasseBase - Método Protected");
    }

    internal void Internal_Membro()
    {
        Console.WriteLine("ClasseBase - Internal");
    }

    protected internal void Protected_Internal_Membro()
    {
        Console.WriteLine("ClasseBase - Método propected internal");
    }

    private void Private_Membro()
    {
        Console.WriteLine("ClasseBase - Método private");
    }

    // para acessar o private

    public void AcessaPrivate()
    {
        Private_Membro();
        Console.WriteLine("\n Método private - acessado por método público");
    }
}
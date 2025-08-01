
Console.ReadKey();

class A
{
    public static void ProcessarA()
    {
        B.ProcessarB();
    }
}

class B
{
    public static void ProcessarB()
    {
        C.ProcessarC();
    }
}

class C
{
    public static void ProcessarC()
    {
        throw new NotImplementedException("Método não implementado");
    }
}
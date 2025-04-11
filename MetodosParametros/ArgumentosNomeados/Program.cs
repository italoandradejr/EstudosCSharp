Console.WriteLine("## Argumentos Nomeados ##");

Email email = new Email();

email.Enviar("teste@email.com", "Reunião de orçamento", "Urgente");



//argumento nomeados

email.Enviar(titulo: "Urgente", destino: "teste@gmail.com", assunto: "Reunião Orçamento");


Console.ReadKey();


public class Email
{
    public void Enviar (string destino, string titulo, string assunto)
    {
        Console.WriteLine($"\nPara {destino} - {titulo} \n Assunto: {assunto}");
    }
}
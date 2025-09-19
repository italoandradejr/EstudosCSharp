await ExecutaOperacaoAsync();
Console.ReadKey();

static async Task ExecutaOperacaoAsync()
{
    //cria um CancellationTokenSource
    var tempo = 30;
    var cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(tempo));

    Console.WriteLine("\nIniciando download");
    Console.WriteLine($"\nCancelando a operação após {tempo} segundos ...");

    try
    {
        using var httpCliente = new HttpClient();
        var destino = @"C:\\Users\\italo.silva\\Documents\\CSharp\\EstudosCSharp\\01_Assincrona\arquivo.txt";

        var resposta = await httpCliente.GetAsync("https://www.macoratti.net/dados/Poesia.txt", HttpCompletionOption.ResponseHeadersRead, cancellationTokenSource.Token);

        var totalBytes = resposta.Content.Headers.ContentLength;
        var readBytes = 0L;

        await using var fileStream = new FileStream(destino, FileMode.Create, FileAccess.Write);

        await using var contentStream = await resposta.Content.ReadAsStreamAsync(cancellationTokenSource.Token);

        var buffer = new byte[81920];
        int bytesRead;

        while ((bytesRead = await contentStream.ReadAsync(buffer, 0, buffer.Length, cancellationTokenSource.Token)) > 0)
        {
            await fileStream.WriteAsync(buffer, 0, bytesRead, cancellationTokenSource.Token);
            readBytes += bytesRead;
            Console.WriteLine($"Progresso: {readBytes}/{totalBytes}");
        }

    }
    catch (OperationCanceledException ex)
    {
        if(cancellationTokenSource.IsCancellationRequested)
        {
            Console.WriteLine("\nDownload cancelado por tempo limite: " + ex.Message);
        }
        else
        {
            Console.WriteLine("\nO tempo limite para o download foi atingido");
        }

    }
    catch (HttpRequestException ex)
    {
        Console.WriteLine($"\nO correu um erro de rede: {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\nOcorreu um erro desconhecido: {ex.Message}");
    }
    finally
    {
        Console.WriteLine("\nDownload finalizado....");
    }
}
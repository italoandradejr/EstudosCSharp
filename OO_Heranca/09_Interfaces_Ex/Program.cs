

using _09_Interfaces_Ex;

SalvarXml salvarXml = new SalvarXml();
salvarXml.Salvar();
salvarXml.Nome();

SalvarJson salvarJson = new SalvarJson();
salvarJson.Salvar();
salvarJson.Nome();


ISalvar salvarArquivo = new SalvarJson();
salvarArquivo.Compactar();

Console.ReadKey();
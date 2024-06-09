try
{ 

    string[] linhas = File.ReadAllLines("Arquivos/arquivoleitura.txt");

    foreach(string linha in linhas)
    {
        Console.WriteLine(linha);
    }
} 
catch(FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado {ex.Message}");
}
catch(DirectoryNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminha da pasta não encontrado. " + ex.Message);
}
catch(Exception ex)
{ 
   Console.WriteLine($"Ocorreu uma exceção generica. {ex.Message}");
}
finally
{
    Console.WriteLine("Chegou ate aqui");
}
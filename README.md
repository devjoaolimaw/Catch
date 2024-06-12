# Catch:

Claro! Vou explicar o código usando partes dele:

1. **Tentativa de leitura do arquivo:**
   
   ```csharp
   try
   { 
       string[] linhas = File.ReadAllLines("Arquivos/arquivoleitura.txt");
   
       foreach(string linha in linhas)
       {
           Console.WriteLine(linha);
       }
   }
   ```

   Aqui, estamos tentando ler todas as linhas de um arquivo de texto especificado. A função `File.ReadAllLines()` é usada para ler todas as linhas de texto de um arquivo e armazená-las em um array de strings chamado `linhas`. Em seguida, um loop `foreach` itera sobre cada linha lida e a imprime no console.

2. **Tratamento de exceções específicas:**
   
   ```csharp
   catch(FileNotFoundException ex)
   {
       Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado: {ex.Message}");
   }
   catch(DirectoryNotFoundException ex)
   {
       Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado: {ex.Message}");
   }
   ```

   Estes blocos `catch` capturam exceções específicas que podem ocorrer durante a leitura do arquivo. Se o arquivo especificado não for encontrado, será lançada uma exceção do tipo `FileNotFoundException`, que será tratada pelo primeiro bloco `catch`. Se o diretório onde o arquivo está localizado não for encontrado, será lançada uma exceção do tipo `DirectoryNotFoundException`, que será tratada pelo segundo bloco `catch`.

3. **Tratamento de exceções genéricas:**
   
   ```csharp
   catch(Exception ex)
   { 
       Console.WriteLine($"Ocorreu uma exceção genérica: {ex.Message}");
   }
   ```

   Este bloco `catch` captura qualquer outra exceção não tratada pelos blocos `catch` anteriores. Ele lida com exceções mais genéricas, do tipo `Exception`, que podem surgir durante a execução do código.

4. **Bloco finally:**
   
   ```csharp
   finally
   {
       Console.WriteLine("Chegou até aqui");
   }
   ```

   O bloco `finally` é executado independentemente de ocorrer ou não uma exceção. Aqui, ele imprime uma mensagem indicando que o bloco `finally` foi alcançado. Geralmente, o bloco `finally` é usado para realizar ações que devem ser executadas independentemente de terem ocorrido exceções ou não, como liberar recursos ou limpar o estado.

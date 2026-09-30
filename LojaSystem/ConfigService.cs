using Microsoft.Extensions.Configuration;
using System;
using System.Configuration;
using System.IO;

public static class ConfigService
{
    public static (string Url, string Key) ObterCredenciaisSupabase()
    {
        // Constrói o leitor do ficheiro appsettings.json no diretório de execução da aplicação
        var builder = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

        IConfiguration configuration = builder.Build();

        // Extrai os valores das chaves
        string url = configuration["Supabase:Url"];
        string key = configuration["Supabase:Key"];

        return (url, key);
    }
}
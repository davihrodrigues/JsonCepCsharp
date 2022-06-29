using System;
using System.Threading.Tasks;
using Refit;

namespace ExemploRefit
{
    class MainClass
    {
        static async Task Main(string[] args)
        {
            try
            {
                var cepClient = RestService.For<ICepApiService>("https://viacep.com.br/");
                Console.WriteLine("Informe seu cep:");

                string cepInformado = Console.ReadLine().ToString();
                Console.WriteLine("Consultando informacoes do CEP:" + cepInformado);

                var address = await cepClient.GetAdressAsync(cepInformado);

                Console.Write($"\nLogradouro:{address.Logradouro}\nBairro:{address.Bairro}\nCidade:{address.Localidade}");
                Console.ReadKey();

            }   catch (Exception e)
            {
                Console.WriteLine("Erro na consulta de cep: " + e.Message);
            }
        }   
    }
}

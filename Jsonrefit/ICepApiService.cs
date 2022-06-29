using Refit;
using System.Threading.Tasks;

namespace ExemploRefit
{
    public interface ICepApiService

    {
        [Get("/ws/{cep}/json")]
        Task<CepResponse> GetAdressAsync(string cep);
    }
}

using W4G.Extensions.Models;

namespace W4G.Extensions.Interfaces
{
    internal interface ICepService
    {
        bool Validate(string cep);
        Endereco Info(string cep);
    }
}
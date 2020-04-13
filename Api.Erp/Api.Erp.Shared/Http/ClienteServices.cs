using Api.Erp.Shared.ViewModels;
using System.Text.Json;
using System.Threading.Tasks;

namespace Api.Erp.Shared.Http
{
    public static class ClienteServices
    {
        public static async Task<ClienteVM> PesquisarPorId(string id)
        {
            // Rota que retorna um cliente pelo id pesquisado
            var url = "http://localhost:5000/api/cliente/" + id;

            // Executa a requisição http
            var response = await RequestHttp.Request(url);

            // Converte o JSON retornado pela api em um objeto do tipo ClienteVM
            ClienteVM cliente = JsonSerializer.Deserialize<ClienteVM>(response);
            return cliente;
        }
    }
}
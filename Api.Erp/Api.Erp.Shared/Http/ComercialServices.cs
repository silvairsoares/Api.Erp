using Api.Erp.Shared.Repository;
using Api.Erp.Shared.ViewModels;
using System;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Api.Erp.Shared.Http
{
    public static class ComercialServices
    {
        public static async Task<VendaVmOutput> PesquisarPorId(string id)
        {
            // Rota que retorna uma venda pelo id pesquisado
            var url = "http://localhost:5003/api/venda/" + id;

            // Executa a requisição http de forma assíncrona
            var response = await RequestHttp.Request(url);

            // Converte o JSON retornado pela api em um objeto do tipo VendaVmInput
            VendaVmInput venda = JsonSerializer.Deserialize<VendaVmInput>(response);
            return await ObterVendaCompleta(venda);
        }

        public static async Task<VendaVmOutput> ObterVendaCompleta(VendaVmInput venda)
        {
            // Pesquisa o cliente da venda na Api.Erp.Clientes
            ClienteVM clienteDaVenda = await ClienteServices.PesquisarPorId(venda.idCliente);

            // Cria um objeto com os dados completos da venda, para retornar para o usuário
            VendaVmOutput vendaCompleta = new VendaVmOutput();
            vendaCompleta.id = venda.id;
            vendaCompleta.cliente = clienteDaVenda;
            vendaCompleta.valorTotal = venda.valorTotal;
            return vendaCompleta;
        }

        //public static async Task<VendaVmOutput> ObterVendaCompletaPorId(string id)
        //{
        //    // Obtem os dados da venda, salvos no repositório de vendas
        //    var venda = BaseRepository.RepositorioVendas.Where(cli => cli.id == id).FirstOrDefault();

        //    return await ObterVendaCompleta(venda);
        //}
    }
}
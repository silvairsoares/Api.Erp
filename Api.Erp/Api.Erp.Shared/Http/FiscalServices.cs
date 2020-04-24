using Api.Erp.Shared.ViewModels;
using System.Text.Json;
using System.Threading.Tasks;

namespace Api.Erp.Shared.Http
{
    public static class FiscalServices
    {
        public static async Task<NotaFiscalVmOutput> ObterNotaFiscalCompleta(NotaFiscalVmInput notafiscal)
        {
            // Pesquisa a venda da notafiscal na Api.Erp.Comercial
            VendaVmOutput vendaDaNotaFiscal = await PesquisarVendaPorId(notafiscal.idVenda);

            // Cria um objeto com os dados completos da notafiscal, para retornar para o usuário
            NotaFiscalVmOutput notafiscalCompleta = new NotaFiscalVmOutput();
            notafiscalCompleta.id = notafiscal.id;
            notafiscalCompleta.Venda = vendaDaNotaFiscal;
            notafiscalCompleta.valorTotalICMS = notafiscal.valorTotalICMS;
            notafiscalCompleta.valorTotalNotaFiscal = notafiscal.valorTotalNotaFiscal;

            return notafiscalCompleta;
        }

        private static async Task<VendaVmOutput> PesquisarVendaPorId(string id)
        {
            // Rota que retorna uma venda pelo id pesquisado
            var url = "http://localhost:5003/api/venda/" + id;

            // Executa a requisição http de forma assíncrona
            var response = await RequestHttp.Request(url);

            // Converte o JSON retornado pela api em um objeto do tipo VendaVmOutput
            VendaVmOutput venda = JsonSerializer.Deserialize<VendaVmOutput>(response);
            return venda;
        }
    }
}
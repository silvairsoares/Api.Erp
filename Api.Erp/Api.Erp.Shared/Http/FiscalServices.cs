using Api.Erp.Shared.Repository;
using Api.Erp.Shared.ViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Erp.Shared.Http
{
    public static class FiscalServices
    {
        public static async Task<NotaFiscalVmOutput> ObterNotaFiscalCompleta(NotaFiscalVmInput notafiscal)
        {
            var venda = BaseRepository.RepositorioVendas.Where(venda => venda.id == notafiscal.idVenda).FirstOrDefault();

            // Pesquisa a venda da notafiscal na Api.Erp.Comercial
            VendaVmOutput vendaDaNotaFiscal = await ComercialServices.ObterVendaCompleta(venda);

            // Cria um objeto com os dados completos da notafiscal, para retornar para o usuário
            NotaFiscalVmOutput notafiscalCompleta = new NotaFiscalVmOutput();
            notafiscalCompleta.id = notafiscal.id;
            notafiscalCompleta.Venda = vendaDaNotaFiscal;
            notafiscalCompleta.valorTotalICMS = notafiscal.valorTotalICMS;
            notafiscalCompleta.valorTotalNotaFiscal = notafiscal.valorTotalNotaFiscal;

            return notafiscalCompleta;
        }
    }
}
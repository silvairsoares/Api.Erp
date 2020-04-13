using Api.Erp.Shared.Http;
using Api.Erp.Shared.Repository;
using Api.Erp.Shared.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Erp.Comercial.Controllers
{
    [Route("api/venda/")]
    public class VendaController : Controller
    {
        [HttpPost]
        public async Task<VendaVmOutput> Add([FromBody] VendaVmInput DadosVenda)
        {
            BaseRepository.RepositorioVendas.Add(DadosVenda);
            return await ComercialServices.ObterVendaCompleta(DadosVenda);
        }

        [HttpGet("{id}")]
        public async Task<VendaVmOutput> GetVendaById(string id)
        {
            // Obtem os dados da venda, salvos no repositório de vendas
            var venda = BaseRepository.RepositorioVendas.Where(cli => cli.id == id).FirstOrDefault();
            VendaVmOutput vendaCompleta = await ComercialServices.ObterVendaCompleta(venda);

            return vendaCompleta;
        }

        [HttpGet]
        public async Task<ICollection<VendaVmOutput>> GetAllVendas()
        {
            ICollection<VendaVmOutput> vendasCompletas = new List<VendaVmOutput>();

            foreach (var item in BaseRepository.RepositorioVendas)
            {
                vendasCompletas.Add(await ComercialServices.ObterVendaCompleta(item));
            }

            return vendasCompletas;
        }

        [HttpDelete("{id}")]
        public object Deletar(string id)
        {
            var venda = BaseRepository.RepositorioVendas.Where(cli => cli.id == id).FirstOrDefault();
            if (BaseRepository.RepositorioVendas.Remove(venda))
            {
                return new
                {
                    resultado = "Venda: " + id + " excluida com sucesso!"
                };
            }
            else
            {
                return new
                {
                    resultado = "Erro ao excluir o venda " + id
                };
            }
        }
    }
}
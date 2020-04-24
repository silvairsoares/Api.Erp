using Api.Erp.Shared.Http;
using Api.Erp.Shared.Repository;
using Api.Erp.Shared.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Erp.Fiscal.Controllers
{
    [Route("api/notafiscal/")]
    public class NotaFiscalController : Controller
    {
        [HttpPost]
        public async Task<NotaFiscalVmOutput> Add([FromBody] NotaFiscalVmInput DadosNotaFiscal)
        {
            BaseRepository.RepositorioNotasFiscais.Add(DadosNotaFiscal);
            return await FiscalServices.ObterNotaFiscalCompleta(DadosNotaFiscal);
        }

        [HttpGet("{id}")]
        public async Task<NotaFiscalVmOutput> GetNotaFiscalById(string id)
        {
            // Obtem os dados da nota fiscal, salvos no repositório de notas fiscais
            var notafiscal = BaseRepository.RepositorioNotasFiscais.Where(cli => cli.id == id).FirstOrDefault();
            NotaFiscalVmOutput notafiscalCompleta = await FiscalServices.ObterNotaFiscalCompleta(notafiscal);

            return notafiscalCompleta;
        }

        [HttpGet]
        public async Task<ICollection<NotaFiscalVmOutput>> GetAllNotaFiscais()
        {
            ICollection<NotaFiscalVmOutput> notasFiscaisCompletas = new List<NotaFiscalVmOutput>();

            foreach (var item in BaseRepository.RepositorioNotasFiscais)
            {
                notasFiscaisCompletas.Add(await FiscalServices.ObterNotaFiscalCompleta(item));
            }

            return notasFiscaisCompletas;
        }

        [HttpDelete("{id}")]
        public object Deletar(string id)
        {
            var notafiscal = BaseRepository.RepositorioNotasFiscais.Where(cli => cli.id == id).FirstOrDefault();
            if (BaseRepository.RepositorioNotasFiscais.Remove(notafiscal))
            {
                return new
                {
                    resultado = "NotaFiscal: " + id + " excluida com sucesso!"
                };
            }
            else
            {
                return new
                {
                    resultado = "Erro ao excluir o notafiscal " + id
                };
            }
        }
    }
}
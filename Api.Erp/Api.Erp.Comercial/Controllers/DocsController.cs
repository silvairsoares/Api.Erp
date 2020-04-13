using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Erp.Comercial.Controllers
{
    /// <summary>
    /// Controller para exibir a documentação da API Comercial
    /// </summary>
    [Route("")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class DocsController : Controller
    {
        [Route(""), HttpGet]
        [AllowAnonymous]
        public IActionResult Swagger()
        {
            return Redirect("~/swagger");
        }
    }
}
using NJsonSchema.Annotations;
using System;

namespace Api.Erp.Shared.ViewModels
{
    /// <summary>
    /// Informações para o cadastro do cliente
    /// </summary>
    public class ClienteVM
    {
        /// <summary>
        /// Id do cliente no Banco de Dados
        /// </summary>
        [JsonSchemaExtensionData("example", "15")]
        public string id { get; set; }

        /// <summary>
        /// Nome do cliente
        /// </summary>
        [JsonSchemaExtensionData("example", "Nome do cliente")]
        public string nome { get; set; }

        /// <summary>
        /// Email do cliente
        /// </summary>
        [JsonSchemaExtensionData("example", "emaildocliente@provedor.com.br")]
        public string email { get; set; }
    }
}
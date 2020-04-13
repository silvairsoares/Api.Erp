using NJsonSchema.Annotations;

namespace Api.Erp.Shared.ViewModels
{
    /// <summary>
    /// Informações para geração de uma nova venda
    /// </summary>
    public class VendaVmInput
    {
        /// <summary>
        /// Id na venda no banco de dados
        /// </summary>
        [JsonSchemaExtensionData("example", "3")]
        public string id { get; set; }

        /// <summary>
        /// Id do cliente da venda
        /// </summary>
        [JsonSchemaExtensionData("example", "10")]
        public string idCliente { get; set; }

        /// <summary>
        /// Valor total da venda. Formato 00000.00
        /// </summary>
        [JsonSchemaExtensionData("example", 890.50)]
        public decimal valorTotal { get; set; }
    }
}
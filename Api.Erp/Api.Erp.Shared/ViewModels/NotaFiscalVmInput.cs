using NJsonSchema.Annotations;

namespace Api.Erp.Shared.ViewModels
{    
    /// <summary>
    /// Informações para geração de uma nova nota fiscal
    /// </summary>
    public class NotaFiscalVmInput
    {
        /// <summary>
        /// Id na Nota Fiscal no Banco de Dados
        /// </summary>
        [JsonSchemaExtensionData("example", "31")]
        public string id { get; set; }

        /// <summary>
        /// Id da venda que será a origem da Nota Fiscal
        /// </summary>
        [JsonSchemaExtensionData("example", "2")]
        public string idVenda { get; set; }

        /// <summary>
        /// Valor total do ICMS. Formato 00000.00
        /// </summary>
        [JsonSchemaExtensionData("example", 1500.90)]
        public decimal valorTotalICMS { get; set; }

        /// <summary>
        /// Valor total da nota fiscal
        /// </summary>
        [JsonSchemaExtensionData("example", 1500.00)]
        public decimal valorTotalNotaFiscal { get; set; }
    }
}
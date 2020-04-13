namespace Api.Erp.Shared.ViewModels
{
    /// <summary>
    /// Informações da nota fiscal
    /// </summary>
    public class NotaFiscalVmOutput
    {
        /// <summary>
        /// Id na Nota Fiscal no Banco de Dados
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Referência para a venda que originou a nota fiscal
        /// </summary>
        public VendaVmOutput Venda { get; set; }

        /// <summary>
        /// Valor total do ICMS
        /// </summary>
        public decimal valorTotalICMS { get; set; }

        /// <summary>
        /// Valor total da nota fiscal
        /// </summary>
        public decimal valorTotalNotaFiscal { get; set; }
    }
}
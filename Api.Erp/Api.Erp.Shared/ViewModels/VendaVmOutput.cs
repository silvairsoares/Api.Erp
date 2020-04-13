namespace Api.Erp.Shared.ViewModels
{
    /// <summary>
    /// Informações da venda
    /// </summary>
    public class VendaVmOutput
    {
        /// <summary>
        /// Id na venda no banco de dados
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Referência para o cliente, para o qual foi executada a venda
        /// </summary>
        public ClienteVM cliente { get; set; }

        /// <summary>
        /// Valor total da venda
        /// </summary>
        public decimal valorTotal { get; set; }
    }
}
namespace Api.Erp.Shared.ViewModels
{
    public class NotaFiscalVmInput
    {
        public string id { get; set; }
        public string idVenda { get; set; }
        public decimal valorTotalICMS { get; set; }
        public decimal valorTotalNotaFiscal { get; set; }
    }
}
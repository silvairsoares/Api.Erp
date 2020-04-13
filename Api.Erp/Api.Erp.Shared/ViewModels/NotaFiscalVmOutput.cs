namespace Api.Erp.Shared.ViewModels
{
    public class NotaFiscalVmOutput
    {
        public string id { get; set; }
        public VendaVmOutput Venda { get; set; }
        public decimal valorTotalICMS { get; set; }
        public decimal valorTotalNotaFiscal { get; set; }
    }
}
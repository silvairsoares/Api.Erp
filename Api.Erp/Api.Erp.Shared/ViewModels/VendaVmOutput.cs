namespace Api.Erp.Shared.ViewModels
{
    public class VendaVmOutput
    {
        public string id { get; set; }
        public ClienteVM cliente { get; set; }
        public decimal valorTotal { get; set; }
    }
}
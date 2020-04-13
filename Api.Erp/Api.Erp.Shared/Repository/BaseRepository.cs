using Api.Erp.Shared.ViewModels;
using System.Collections.Generic;

namespace Api.Erp.Shared.Repository
{
    public static class BaseRepository
    {
        static BaseRepository()
        {
            CriarDadosModelo();
        }

        private static void CriarDadosModelo()
        {
            // Na primeira execução, inclui alguns clientes para teste
            if (RepositorioClientes == null)
            {
                RepositorioClientes = new List<ClienteVM>();

                ClienteVM cliente1 = new ClienteVM();
                cliente1.id = "10";
                cliente1.nome = "Silvair Leite Soares";
                cliente1.email = "silvairsoares@outlook.com";
                RepositorioClientes.Add(cliente1);

                ClienteVM cliente2 = new ClienteVM();
                cliente2.id = "11";
                cliente2.nome = "José da Silva Sobrinho";
                cliente2.email = "josesobrinho@outlook.com";
                RepositorioClientes.Add(cliente2);
            }

            // Na primeira execução, inclui algumas vendas para teste
            if (RepositorioVendas == null)
            {
                RepositorioVendas = new List<VendaVmInput>();

                VendaVmInput venda1 = new VendaVmInput();
                venda1.id = "1";
                venda1.idCliente = "10";
                venda1.valorTotal = 100;
                RepositorioVendas.Add(venda1);

                VendaVmInput venda2 = new VendaVmInput();
                venda2.id = "2";
                venda2.idCliente = "11";
                venda2.valorTotal = 1500;
                RepositorioVendas.Add(venda2);
            }

            // Na primeira execução, inclui algumas notas fiscais para teste
            if (RepositorioNotasFiscais == null)
            {
                RepositorioNotasFiscais = new List<NotaFiscalVmInput>();

                NotaFiscalVmInput notafiscal1 = new NotaFiscalVmInput();
                notafiscal1.id = "20";
                notafiscal1.idVenda = "1";
                notafiscal1.valorTotalICMS = 100;
                notafiscal1.valorTotalNotaFiscal = 110;
                RepositorioNotasFiscais.Add(notafiscal1);

                NotaFiscalVmInput notafiscal2 = new NotaFiscalVmInput();
                notafiscal2.id = "30";
                notafiscal2.idVenda = "2";
                notafiscal2.valorTotalICMS = 800;
                notafiscal2.valorTotalNotaFiscal = 100;
                RepositorioNotasFiscais.Add(notafiscal2);
            }
        }

        // Variável para persistência temporária de clientes, somente para demonstração
        public static ICollection<ClienteVM> RepositorioClientes;

        // Variável para persistência temporária de vendas, somente para demonstração
        public static ICollection<VendaVmInput> RepositorioVendas;

        // Variável para persistência temporária de notas fiscais, somente para demonstração
        public static ICollection<NotaFiscalVmInput> RepositorioNotasFiscais;
    }
}
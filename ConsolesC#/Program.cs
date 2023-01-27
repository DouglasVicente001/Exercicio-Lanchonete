// See https://aka.ms/new-console-template for more information


namespace ConsolesC_.Models
{
    class TestClass
    {
        static void Main(string[] args)
        {

            Produto produto = new Produto(16,20,6,4);


            System.Console.WriteLine("OLÁ BEM VINDO AO MC BURGUER, Segue o cardápio do dia!");
            string Cardapio = ("\nLANCHE DE FRANGO R$16"
         + "\nLANCHE DE CARNE R$20" 
         + "\nBATATA FRITA R$ 6"
         + "\nSALADA R$ 2"
         + "\nREFRIGERANTE R$ 4"
         + "\nADICIONAL MAIONESE R$ 1");
            System.Console.WriteLine(Cardapio);

            double Total = 0;
            int PedidoLancheQntd = 0;

            System.Console.WriteLine("Lanche de Carne ou de Frango? [1] Frango [2] Carne");
            int TipoLanche = int.Parse(System.Console.ReadLine());
            if (TipoLanche == 1)
            {
                System.Console.WriteLine("Quantos Lanches de frango você deseja?");
                PedidoLancheQntd = int.Parse(System.Console.ReadLine());
                Total = (PedidoLancheQntd * produto.LancheFrango) + Total;
            }else 
            if (TipoLanche == 2)
            {
                System.Console.WriteLine("Quantos Lanches de Carne você deseja?");
                PedidoLancheQntd = int.Parse(System.Console.ReadLine());
                Total = (PedidoLancheQntd * produto.LancheCarne) + Total;
            }

            System.Console.WriteLine("Lanche com salada ou sem ? [1] SIM [2]NÃO ");
            int EscolhaSalada = int.Parse(System.Console.ReadLine());
            if (EscolhaSalada == 1)
            {
                Total = (PedidoLancheQntd * 2) + Total;
            }
            System.Console.WriteLine("Lanche com maionese ou sem ? [1] SIM [2]NÃO ");
            int EscolhaMaionese = int.Parse(System.Console.ReadLine());
            if (EscolhaMaionese == 1)
            {
               Total = (PedidoLancheQntd * 1) + Total;
            }  

            System.Console.WriteLine("Deseja batata frita? [1] SIM [2]NÃO");
            int PedidoBatata = int.Parse(System.Console.ReadLine());
            if(PedidoBatata == 1)
            {
                System.Console.WriteLine("Quantas Batatas fritas Você deseja?");
                int TotalQntdFritas = int.Parse(System.Console.ReadLine());
                Total = (TotalQntdFritas * produto.BatataFrita) + Total;

                System.Console.WriteLine("Batata com maionese ou sem ? [1] SIM [2]NÃO ");
                int EscolhaMaioneseBatata = int.Parse(System.Console.ReadLine());
                if (EscolhaMaioneseBatata == 1)
                {
                    Total = (TotalQntdFritas * 1) + Total;
                }
            }


            System.Console.WriteLine("Quantos Refrigerantes Você deseja?");
            int TotalQntdRefrigerante = int.Parse(System.Console.ReadLine());
            Total = (TotalQntdRefrigerante * produto.Refrigerante) + Total;


            System.Console.WriteLine($"O TOTAL DA COMPRA DO SEU LANCHE É DE {Total}");


        }
    }
}

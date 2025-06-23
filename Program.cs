using Cantina_2._0;

namespace Cantina_2._0
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
                ApplicationConfiguration.Initialize();

                // Aqui usamos a lista vinda da classe GestaoCardapio
                var lista = GestaoCardapio.Produtos;

                Application.Run(new VendasForm(lista));
            

        }
    }
}
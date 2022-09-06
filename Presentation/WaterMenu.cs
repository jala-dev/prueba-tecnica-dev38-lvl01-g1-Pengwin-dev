using System;

namespace Presentation
{
    public class WaterMenu
    {
        private string ApplicationName;

        public WaterMenu(string appName)
        {
            this.ApplicationName = appName;
        }

        public int ChooseOption()
        {
            this.ShowOptions();
            string selection = Console.ReadLine();
            return int.Parse(selection);
        }

        private void ShowOptions()
        {
            Console.WriteLine("");
            Console.WriteLine(ApplicationName);
            Console.WriteLine("======================================");
            Console.WriteLine("1. Registrar consumo de agua");
            Console.WriteLine("2. Consultar deuda de socio");
            Console.WriteLine("3. Consultar detalles del socio");
            Console.WriteLine("4. Registrar socio");
            Console.WriteLine("5. Registrar pago");            
            Console.WriteLine("6. Exit");
            Console.WriteLine("======================================");
        }
    }
}

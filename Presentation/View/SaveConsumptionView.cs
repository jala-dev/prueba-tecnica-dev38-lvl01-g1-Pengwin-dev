using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.View
{    
    public class SaveConsumptionView
    {        
        public InputData RequestData()
        {            
            return this.Show();
        }

        private InputData Show()
        {
            InputData input = new InputData();
            Console.WriteLine("======================================");
            Console.WriteLine("1. Ingrese el codigo del socio: ");
            input.fields.Add("CodigoSocio", Console.ReadLine());
            Console.WriteLine("2. Ingrese el valor del consumo: ");
            input.fields.Add("Consumo", Console.ReadLine());
            return input;
        }
    }
}

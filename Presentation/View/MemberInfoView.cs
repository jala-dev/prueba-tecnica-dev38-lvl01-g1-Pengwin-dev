using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.View
{
    public class MemberInfoView
    {
        public InputData RequestData()
        {
            return this.GetData();
        }

        private InputData GetData()
        {
            InputData input = new InputData();
            Console.WriteLine("======================================");
            Console.WriteLine("1. Ingrese el codigo del socio: ");
            input.fields.Add("CodigoSocio", Console.ReadLine());
            return input;
        }

        public void ShowResult(string fullName)
        {
            Console.WriteLine("R. El Id corresponde al socio: {0}", fullName);
            Console.WriteLine("======================================");
        }
    }
}

using BusinessLogic;
using Presentation;

namespace WACO_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            WaterMenu menu = new WaterMenu("SISTEMA DE COBRO COOPERATIVO DE AGUA");
            WaterSystem app = new WaterSystem(menu);
            app.Start();
        }
    }
}

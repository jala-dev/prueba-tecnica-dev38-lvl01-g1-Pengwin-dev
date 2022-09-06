using BusinessLogic.Core;
using Data;
using Data.Entities;
using Presentation;
using Presentation.View;

namespace BusinessLogic.Commands
{
    public class SaveConsumption: IWaterCommand
    {
        public void Execute()
        {
            InputData data = new SaveConsumptionView().RequestData();
            Consumption entity = new Consumption();
            entity.MemberID = int.Parse(data.fields["CodigoSocio"]);
            entity.Value = int.Parse(data.fields["Consumo"]);
            new ConsumptionRepository().Save(entity);
        }
    }
}

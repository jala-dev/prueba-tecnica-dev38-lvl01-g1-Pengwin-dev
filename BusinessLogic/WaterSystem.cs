using BusinessLogic.Commands;
using BusinessLogic.Core;
using Presentation;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class WaterSystem
    {
        private WaterMenu menu;
        private int exitOption = 6;
        List<IWaterCommand> commands;

        public WaterSystem(WaterMenu menu)
        {
            this.menu = menu;

            commands = new List<IWaterCommand>();
            commands.Add(new SaveConsumption());
            commands.Add(new MemberReceivableRequest());
        }

        public void Start()
        {
            int option;
            do
            {
                option = ReadOption();
                ExecuteOption(option);
            } while (option != exitOption);
        }

        private void ExecuteOption(int option)
        {
            switch(option)
            {
                case 1:
                    commands[0].Execute();
                    break;
                case 2:
                    commands[option-1].Execute();
                    break;
                case 3:
                    new MemberInfoRequest().Execute();
                    break;
                case 4:
                    new SaveUser().Execute();
                    break;
                case 5:
                    new SavePayment().Execute();
                    break;
                default:
                    break;
            }
        }

        private int ReadOption()
        {
            return menu.ChooseOption();            
        }
    }
}

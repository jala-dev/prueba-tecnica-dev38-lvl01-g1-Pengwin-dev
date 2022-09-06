using Data;
using Data.Entities;
using Presentation;
using Presentation.View;

namespace BusinessLogic.Commands
{
    class MemberInfoRequest
    {
        public void Execute()
        {
            MemberInfoView view = new MemberInfoView();
            InputData data = view.RequestData();
            Member entity = new Member();
            entity.ID = int.Parse(data.fields["CodigoSocio"]);

            Member member = new MemberRepository().GetMember(entity.ID);
            
            view.ShowResult(member.FirstName + " " + member.SecondName);
        }
    }
}

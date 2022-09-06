using System;
using Data;
using Data.Entities;
using Presentation;
using Presentation.View;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Commands
{
    class SaveUser
    {
        MemberRepository _repository = new MemberRepository();
        public void Execute()
        {
            NewUserView view = new NewUserView();
            InputData data = view.RequestData();
            Member entity = new Member();
            entity.ID = int.Parse(data.fields["CodigoSocio"]);
            entity.FirstName = data.fields["Nombre"];
            entity.SecondName = data.fields["Apellido"];
            if (this.checkValidation(entity))
            {
                Member member = _repository.GetMember(entity.ID);
                view.ShowResult(entity.FirstName + " " + entity.SecondName);
            }
        }

        public bool checkValidation(Member entity)
        {
            if(entity == null ||
                entity.ID == 0 ||
                entity.FirstName.Equals("") ||
                entity.SecondName.Equals("")) 
            {
                ErrorHandler errorView = new ErrorHandler();
                errorView.Show("Error: No fue posible realizar el registro del nuevo usuario");
                return false;
            }else if (entity.ID <5000 || entity.ID > 5999)
            {
                ErrorHandler errorView = new ErrorHandler();
                errorView.Show("Error: No fue posible, porque el id se encuentra fuera del rango. Ingrese un numero entre 5000 y 5999");
                return false;
            }else if (_repository.GetMember(entity.ID) != null)
            {
                ErrorHandler errorView = new ErrorHandler();
                errorView.Show("Error: No fue posible, porque el id ya existe");
                return false;
            }
            return true;
        }
    }
}

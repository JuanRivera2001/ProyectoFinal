using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Models
{
    public class LateralMenuModel
    {
        //Default Model used for a LateralMenu
        public LateralMenuModel()
        {
            TargetType = typeof(LateralMenuModel);
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public string Icon { get; set; }

        public Type TargetType { get; set; }

        public UserModel ActualUser { get; set; }

    }
}

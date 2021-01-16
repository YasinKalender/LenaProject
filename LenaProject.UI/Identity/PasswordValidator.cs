using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LenaProject.UI.Identity
{
    public class PasswordValidator: IdentityErrorDescriber
    {

        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresLower",
                Description="Parola küçük harf içermektedir"


            };


        }
    }
}

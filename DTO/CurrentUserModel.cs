using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace DTO
{
    public class CurrentUserModel : IPrincipal
    {
        public IIdentity Identity { get; set; }

        public bool IsInRole(string role)
        {
            return true;
        }

        public string CurrentFlightNumber { get; set; }

        public string CurrentUserName { get; set; }
    }
}

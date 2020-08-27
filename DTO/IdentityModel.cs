using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace DTO
{
    public class IdentityModel : IIdentity
    {
        public string AuthenticationType { get; set; }

        public bool IsAuthenticated { get; set; }

        public string Name { get; set; }
    }
}

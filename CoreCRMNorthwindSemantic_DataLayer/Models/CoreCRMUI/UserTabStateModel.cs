using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreCRMNorthwindSemantic_DataLayer.Models.CoreCRMUI
{
    public class UserTabStateModel
    {
        public ClaimsPrincipal User { get; set; }
        public List<TabSettings> TabSettings { get; set; }

        public UserTabStateModel(ClaimsPrincipal user, List<TabSettings> tabSettings)
        {
            User = user;
            TabSettings = tabSettings;
        }
    }
}

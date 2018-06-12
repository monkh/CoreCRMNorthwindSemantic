using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCRMNorthwindSemantic.Models
{
    public class UserTabStateModel
    {
        public ApplicationUser user { get; set; }
        public TabSettings[] tabSettings { get; set; }
    }
}

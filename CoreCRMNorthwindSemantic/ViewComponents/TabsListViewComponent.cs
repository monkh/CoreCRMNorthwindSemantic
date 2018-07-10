using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CoreCRMNorthwindSemantic.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreCRMNorthwindSemantic.ViewComponents
{
    public class TabsListViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(ClaimsPrincipal user)
        {
            var items = GetUserTabsAsync(user);
            return View(items);
        }
        private UserTabStateModel GetUserTabsAsync(ClaimsPrincipal user)
        {
            TabSettings tabSettings = new TabSettings("Home", "/");
            List<TabSettings> listTabSettngs = new List<TabSettings>();
            listTabSettngs.Add(tabSettings);
            var userTabState = new UserTabStateModel(user, listTabSettngs);
            return userTabState;
        }
    }
}

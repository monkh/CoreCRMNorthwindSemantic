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
        //private readonly UserTabStateModel _userTabStateModel;
        //public TabsListViewComponent(UserTabStateModel userTabStateModel)
        //{
        //    _userTabStateModel = userTabStateModel;
        //}

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
            //var taskUserTabState = new Task<UserTabStateModel>(() => userTabState);
            //var taskUserTabState = new Task<UserTabStateModel>((ob) => GetItemAsync((UserTabStateModel) ob).Result, userTabState);
            return userTabState;
            //return db.ToDo.Where(x => x.IsDone == isDone &&
            //                     x.Priority <= maxPriority).ToListAsync();
        }
    }
}

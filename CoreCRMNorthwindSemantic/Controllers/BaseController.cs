using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreCRMNorthwindSemantic.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreCRMNorthwindSemantic.Controllers
{
    public partial class BaseController : Controller
    {
        public UserTabStateModel userTabStateModel;

        public BaseController()
        {
            userTabStateModel = GetTabSettingsTest();
            ViewData["UserTabStateModel"] = userTabStateModel;
        }

        public UserTabStateModel GetTabSettingsTest()
        {
            // NOTE TO SELF: Self contained view componenets
            // https://docs.microsoft.com/en-us/aspnet/core/mvc/views/view-components?view=aspnetcore-2.1
            // TODO: Self contained view componenets
            List<TabSettings> tabs = new List<TabSettings>();
            
            TabSettings t1 = new TabSettings("About", "\\about" , new Microsoft.AspNetCore.Http.QueryString("?test=nope&woot=9000"));
            TabSettings t2 = new TabSettings("Home", "");
            TabSettings t3 = new TabSettings("Privacy", "\\privacy");
            tabs.Add(t1);
            tabs.Add(t2);
            tabs.Add(t3);

            UserTabStateModel userTabState = new UserTabStateModel(User, tabs);

            return userTabState;
        }

        public String ErrorMessage
        {
            get { return TempData["ErrorMessage"] == null ? String.Empty : TempData["ErrorMessage"].ToString(); }
            set { TempData["ErrorMessage"] = value; }
        }
    }
}
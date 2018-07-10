using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace CoreCRMNorthwindSemantic_DataLayer.Models.CoreCRMUI
{
    public class TabSettings
    {
        public Boolean Active { get; set; }
        public String TabName { get; set; }
        public String URL { get; set; }
        public List<TabQuery> TabQueries { get; set; }

        public TabSettings(String name, String url, QueryString queryString)
        {
            PopulateTabQueries(queryString);
            TabName = name;
            URL = url;
        }
        public TabSettings(String name, String url)
        {
            TabName = name;
            URL = url;
        }

        public String ReturnActiveStatus()
        {
            return this.Active ? "active" : "";
        }


        public string ReturnQueryString()
        {
            string returnQueryString = null;
            foreach (var TQ in TabQueries)
            {
                returnQueryString += $"&{TQ.QueryKey}={TQ.QueryValue}";
            }
            returnQueryString = returnQueryString.Substring(1);
            returnQueryString.Insert(0, "?");
            return returnQueryString;
        }

        private void PopulateTabQueries(QueryString queryString)
        {
            if (queryString.HasValue)
            {
                string qString = queryString.Value.Substring(1);
                List<TabQuery> tabQueries = new List<TabQuery>();
                foreach (var query in qString.Split("&"))
                {
                    var querySplit = query.Split("=");
                    TabQuery newTabQuery = new TabQuery
                    {
                        QueryKey = querySplit[0],
                        QueryValue = querySplit[1]
                    };
                    tabQueries.Add(newTabQuery);
                }
                TabQueries = tabQueries;
            }
        }
    }
}
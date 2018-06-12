using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace CoreCRMNorthwindSemantic.Models
{
    public class TabSettings
    {
        public String TabName { get; set; }
        public List<TabQuery> TabQueries { get; set; }

        public TabSettings(String name, QueryString queryString)
        {
            PopulateTabQueries(queryString);
            TabName = name;
        }

        public string ReturnQueryString()
        {
            string returnQueryString = null;
            foreach (var TQ in TabQueries)
            {
                returnQueryString += $"&{TQ.GetQueryKey()}={TQ.GetQueryValue()}";
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
                    TabQuery newTabQuery = new TabQuery();
                    newTabQuery.SetQueryKey(querySplit[0]);
                    newTabQuery.SetQueryValue(querySplit[1]);
                    tabQueries.Add(newTabQuery);
                }
                TabQueries = tabQueries;
            }
        }
    }
}
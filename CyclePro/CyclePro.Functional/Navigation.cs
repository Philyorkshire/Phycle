using System.Collections.Generic;
using System.Linq;

namespace CyclePro.Functional
{
    public enum PageNames
    {
        HomePage,
        Dashboard,
        Raw
    }

    public static class Navigation
    {
        public static Dictionary<PageNames, string> Pages = new Dictionary<PageNames, string>();

        public static string GetUrl(this PageNames page)
        {
            return Pages.Single(p=>p.Key.Equals(page)).Value;
        }

        static Navigation()
        {
            Pages.Add(PageNames.HomePage,   "http://localhost:58183/");
            Pages.Add(PageNames.Dashboard,  "http://localhost:58183/Analysis/Dashboard");
            Pages.Add(PageNames.Raw,        "http://localhost:58183/Analysis/Raw");
        }
    }
}

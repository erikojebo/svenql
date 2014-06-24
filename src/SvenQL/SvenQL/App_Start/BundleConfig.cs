using System.Web;
using System.Web.Optimization;

namespace SvenQL
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                        "~/Scripts/lib/jquery-{version}.js",
                        "~/Scripts/lib/jquery.floatThead.js",
                        "~/Scripts/lib/knockout-{version}.js",
                        "~/Scripts/eventAggregator.js"));

            bundles.Add(new ScriptBundle("~/bundles/query").Include(
                        "~/Scripts/url.js",
                        "~/Scripts/server.js",
                        "~/Scripts/viewModels/columnViewModel.js",
                        "~/Scripts/viewModels/rowViewModel.js",
                        "~/Scripts/viewModels/resultSetViewModel.js",
                        "~/Scripts/viewModels/queryPageViewModel.js",
                        "~/Scripts/index.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));
        }
    }
}
using System.Web.Optimization;

namespace Cafe
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                      "~/Scripts/materialize.min.js",
                      "~/Scripts/main.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/signalR").Include(
                      "~/Scripts/jquery.signalR-2.2.1.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/materialize.min.css",
                      "~/Content/css/font-awesome.min.css",
                      "~/Content/main.css"));
        }
    }
}

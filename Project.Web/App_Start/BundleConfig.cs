using System.Web;
using System.Web.Optimization;

namespace Project.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

          
            bundles.Add(new StyleBundle("~/Content/css1").Include(
                     "~/Content/bootstrap.css",
                     "~/Content/site.css"
                     ));
            bundles.Add(new StyleBundle("~/Content/css2").Include(
            "~/Content/css/font-awesome.min.css",
                      "~/Content/css/skel.css",
                      "~/Content/css/style-large.css",
                      "~/Content/css/style-medium.css",
                      "~/Content/css/style-small.css",
                      "~/Content/css/style-xlarge.css",
                      "~/Content/css/style-xsmall.css",
                      "~/Content/css/style.css"));
            //bundles.Add(new StyleBundle("~/bundles/js").Include(
            //    "~/Scripts/js/html5shiv.js","~/Scripts/js/init.js",
            //"~/Scripts/js/jquery.min.js",
            //"~/Scripts/js/skel-layers.min.js", "~/Scripts/js/skel.min.js"));

            bundles.Add(new StyleBundle("~/bundles/js").IncludeDirectory(
                "~/Scripts/js/", "*.js", true));

            BundleTable.EnableOptimizations = true;
        }
    }
}

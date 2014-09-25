using System.Web;
using System.Web.Optimization;

namespace TheStream.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/thirdpartylLibraries").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/respond.js",
                        "~/Scripts/app.js", 
                        "~/bower_components/slimScroll/jquery.slimscroll.js",
                        "~/bower_components/jquery.easy-pie-chart/dist/easypiechart.js",
                        "~/Scripts/app.plugin.js",
                        "~/bower_components/jplayer/jquery.jplayer/jquery.jplayer.js",
                        "~/bower_components/jplayer/add-on/jplayer.playlist.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/jplayer.flat.css",
                      "~/Content/bootstrap.css",
                      "~/Content/animate.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/simple-line-icons.css",
                      "~/Content/font.css",
                      "~/Content/app.css"
                      ));

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = false;
        }
    }
}

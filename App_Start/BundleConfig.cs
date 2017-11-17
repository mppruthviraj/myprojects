using System.Web;
using System.Web.Optimization;

namespace ABB_Portal
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

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/bundles/GeneralContents/css").Include(
                      "~/Content/GeneralContents/fonts.css",
                      "~/Content/GeneralContents/style.css"));

            bundles.Add(new ScriptBundle("~/bundles/GeneralContents/js").Include(
                      "~/Content/GeneralContents/app.js",
                      "~/Content/GeneralContents/jquery.min.js"));


            bundles.Add(new StyleBundle("~/bundles/assets/plugins/bootstrap/css").Include(
                "~/Content/assets/plugins/bootstrap/css/bootstrap.min.css"));
            

            bundles.Add(new StyleBundle("~/bundles/css2").Include(
                       "~/Content/css/style.css",
                       "~/Content/spinner.css",
                       "~/Content/animate.css",
                       "~/Content/colors/blue.css"
                       )); 

           bundles.Add(new StyleBundle("~/bundles/assets/plugins/morrisjs/morris").Include(
           "~/Content/assets/plugins/morrisjs/morris.css"));


            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                "~/Content/js/jquery.slimscroll.js",
                "~/Content/js/waves.js",
                "~/Content/js/sidebarmenu.js",
                "~/Content/js/custom.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/assets/plugins/jquery").Include(
                "~/Content/assets/plugins/jquery/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/assets/plugins/bootstrap/js").Include(
               "~/Content/assets/plugins/bootstrap/js/popper.min.js",
               "~/Content/assets/plugins/bootstrap/js/bootstrap.min.js"));


            bundles.Add(new ScriptBundle("~/bundles/assets/plugins/sticky-kit-master/dist").Include(
               "~/Content/assets/plugins/sticky-kit-master/dist/sticky-kit.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/assets/plugins/sparkline").Include(
               "~/Content/assets/plugins/sparkline/jquery.sparkline.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/assets/plugins/styleswitcher").Include(
               "~/Content/assets/plugins/styleswitcher/jQuery.style.switcher.js"));



        }
    }
}

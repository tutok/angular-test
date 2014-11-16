using System.Web.Optimization;

namespace app
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Content/scripts/jquery/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include("~/Content/scripts/jquery-validate/jquery.validate*"));
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Content/scripts/modernizr/modernizr-*"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Content/scripts/bootstrap/bootstrap.js",
                "~/Content/scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                "~/Content/scripts/angular/angular.js",
                "~/Content/scripts/angular/angular-route.js"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/Content/scripts/app/controllers.js"));



            bundles.Add(new StyleBundle("~/bundles/styles").Include(
                "~/Content/styles/bootstrap/bootstrap.css",
                "~/Content/styles/site.css"));

            //BundleTable.EnableOptimizations = true;
        }
    }
}
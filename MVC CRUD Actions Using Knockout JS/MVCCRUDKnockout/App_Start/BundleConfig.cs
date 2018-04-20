using System.Web.Optimization;

namespace MVCCRUDKnockout
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/Scripts/knockout-{version}.js",
                "~/Scripts/KOScripts/KOCreate.js", 
                "~/Scripts/KOScripts/KODelete.js",
                "~/Scripts/KOScripts/KORead.js",
                "~/Scripts/KOScripts/KOUpdate.js"));  
            bundles.Add(new ScriptBundle("~/bundles/create").Include(
                "~/Scripts/knockout-{version}.js",
                "~/Scripts/KOScripts/KOCreate.js"));  
            bundles.Add(new ScriptBundle("~/bundles/read").Include(
                "~/Scripts/knockout-{version}.js",
                "~/Scripts/KOScripts/KORead.js"));  
            bundles.Add(new ScriptBundle("~/bundles/edit").Include(
                "~/Scripts/knockout-{version}.js",
                "~/Scripts/KOScripts/KOUpdate.js"));  
            bundles.Add(new ScriptBundle("~/bundles/delete").Include(
                "~/Scripts/knockout-{version}.js",
                "~/Scripts/KOScripts/KODelete.js"));  
        }
    }
}
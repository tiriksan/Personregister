using System.Web;
using System.Web.Optimization;

namespace Personregister
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/Personregister")
            .IncludeDirectory("~/Scripts/Controllers", "*.js")
            .Include("~/Scripts/Personregister.js"));

        }
    }
}
﻿using System.Web;
using System.Web.Optimization;

namespace Vidly
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/bootstrap.js",
                      "~/scripts/bootbox.js",
                      "~/Scripts/respond.js",
                      "~/scripts/datatables/jquery.datatables.js",
                      "~/scripts/datatables/jquery.datatables.bootstrap.js",
                      "~/Scripts/typeahead.bundle.js",
                      "~/Scripts/toastr.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap-lumen3.css",
                      "~/Content/Vidly-bootstrap-theme.css",
                      "~/content/datatables/css/datatables.bootstrap.css",
                      "~/Content/typeahead.css",
                      "~/Content/Vidly-typeahead.css",
                      "~/Content/toastr.css",
                      "~/Content/Site.css"                      
                      ));
        }
    }
}

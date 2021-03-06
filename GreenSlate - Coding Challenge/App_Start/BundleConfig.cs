﻿using System.Web.Optimization;

namespace CodingChallenge.Web.App_Start
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/sammy").Include(
                "~/Scripts/sammy-{version}.js",
                "~/Scripts/app/app.js",
                "~/Scripts/app/routing.js"));

            bundles.Add(new ScriptBundle("~/bundles/userProjects").Include("~/Scripts/app/userProjects.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                 "~/Content/bootstrap.css",
                 "~/Content/Site.css"));
        }
    }
}

﻿using System.Web;
using System.Web.Optimization;

namespace ZakLyd
{
    public class BundleConfig
    {
        // Pour plus d'informations sur le regroupement, visitez http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilisez la version de développement de Modernizr pour le développement et l'apprentissage. Puis, une fois
            // prêt pour la production, utilisez l'outil de génération (bluid) sur http://modernizr.com pour choisir uniquement les tests dont vous avez besoin.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/moment-with-locales.js",
                      "~/Scripts/bootstrap-datepicker.js",
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/bootstrap-touchspin.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/jquery.polyglot.language.switcher.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                     "~/Content/bootstrap.css",
                      "~/Content/bootstrap-datepicker3.css",
                      "~/Content/bootstrap-social.css",
                      "~/Content/font-awesome.css",
                      "~/Content/languages.css",
                      "~/Content/polyglot-language-switcher.css",
                      "~/Content/datepicker.css",
                      "~/Content/bootstrap-touchspin.css",
                      "~/Content/site.css"));
            BundleTable.EnableOptimizations = false;
        }
    }
}

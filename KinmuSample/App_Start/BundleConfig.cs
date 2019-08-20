﻿using System.Web;
using System.Web.Optimization;

namespace KinmuSample
{
    public class BundleConfig
    {
        // バンドルの詳細については、https://go.microsoft.com/fwlink/?LinkId=301862 を参照してください
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // 開発と学習には、Modernizr の開発バージョンを使用します。次に、実稼働の準備が
            // 運用の準備が完了したら、https://modernizr.com のビルド ツールを使用し、必要なテストのみを選択します。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                   "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/datetimepicker").Include(
                       "~/Scripts/bootstrap.datetimepicker.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/momentjs").Include(
                           "~/Scripts/moment-with-locales.min.js",
                           "~/Scripts/moment-range.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            // #region bootstrap
            // bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //           "~/Scripts/bootstrap.bundle.min.js"));
            bundles.Add(new StyleBundle("~/Content/bootstrap-css").Include(
                      "~/Content/bootstrap.min.css"));
            //#endregion

            #region FontAwesome
            bundles.Add(new StyleBundle("~/Content/font-awesome").Include(
                      "~/Content/font-awesome.min.css"));
            #endregion
            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                   "~/Content/themes/base/all.css",
                   "~/Content/themes/base/jquery-ui.min.css"
                   ));
        }
    }
}

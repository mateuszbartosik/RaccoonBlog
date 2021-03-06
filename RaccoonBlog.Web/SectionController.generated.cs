// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
// 0114: suppress "Foo.BarController.Baz()' hides inherited member 'Qux.BarController.Baz()'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword." when an action (with an argument) overrides an action in a parent controller
#pragma warning disable 1591, 3008, 3009, 0108, 0114
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace RaccoonBlog.Web.Controllers
{
    public partial class SectionController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public SectionController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected SectionController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult PostsSeries()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.PostsSeries);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult FuturePosts()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.FuturePosts);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult RecentComments()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RecentComments);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public SectionController Actions { get { return MVC.Section; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Section";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Section";
        [GeneratedCode("T4MVC", "2.0")]
        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string PostsSeries = "PostsSeries";
            public readonly string FuturePosts = "FuturePosts";
            public readonly string List = "List";
            public readonly string ContactMe = "ContactMe";
            public readonly string TagsList = "TagsList";
            public readonly string ArchivesList = "ArchivesList";
            public readonly string PostsStatistics = "PostsStatistics";
            public readonly string RecentComments = "RecentComments";
            public readonly string AdministrationPanel = "AdministrationPanel";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string PostsSeries = "PostsSeries";
            public const string FuturePosts = "FuturePosts";
            public const string List = "List";
            public const string ContactMe = "ContactMe";
            public const string TagsList = "TagsList";
            public const string ArchivesList = "ArchivesList";
            public const string PostsStatistics = "PostsStatistics";
            public const string RecentComments = "RecentComments";
            public const string AdministrationPanel = "AdministrationPanel";
        }


        static readonly ActionParamsClass_PostsSeries s_params_PostsSeries = new ActionParamsClass_PostsSeries();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_PostsSeries PostsSeriesParams { get { return s_params_PostsSeries; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_PostsSeries
        {
            public readonly string sectionTitle = "sectionTitle";
        }
        static readonly ActionParamsClass_FuturePosts s_params_FuturePosts = new ActionParamsClass_FuturePosts();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_FuturePosts FuturePostsParams { get { return s_params_FuturePosts; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_FuturePosts
        {
            public readonly string sectionTitle = "sectionTitle";
        }
        static readonly ActionParamsClass_RecentComments s_params_RecentComments = new ActionParamsClass_RecentComments();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_RecentComments RecentCommentsParams { get { return s_params_RecentComments; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_RecentComments
        {
            public readonly string sectionTitle = "sectionTitle";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string AdministrationPanel = "AdministrationPanel";
                public readonly string ArchivesList = "ArchivesList";
                public readonly string ContactMe = "ContactMe";
                public readonly string FuturePosts = "FuturePosts";
                public readonly string List = "List";
                public readonly string PostsSeries = "PostsSeries";
                public readonly string PostsStatistics = "PostsStatistics";
                public readonly string RecentComments = "RecentComments";
                public readonly string TagsList = "TagsList";
            }
            public readonly string AdministrationPanel = "~/Views/Section/AdministrationPanel.cshtml";
            public readonly string ArchivesList = "~/Views/Section/ArchivesList.cshtml";
            public readonly string ContactMe = "~/Views/Section/ContactMe.cshtml";
            public readonly string FuturePosts = "~/Views/Section/FuturePosts.cshtml";
            public readonly string List = "~/Views/Section/List.cshtml";
            public readonly string PostsSeries = "~/Views/Section/PostsSeries.cshtml";
            public readonly string PostsStatistics = "~/Views/Section/PostsStatistics.cshtml";
            public readonly string RecentComments = "~/Views/Section/RecentComments.cshtml";
            public readonly string TagsList = "~/Views/Section/TagsList.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_SectionController : RaccoonBlog.Web.Controllers.SectionController
    {
        public T4MVC_SectionController() : base(Dummy.Instance) { }

        [NonAction]
        partial void PostsSeriesOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string sectionTitle);

        [NonAction]
        public override System.Web.Mvc.ActionResult PostsSeries(string sectionTitle)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.PostsSeries);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "sectionTitle", sectionTitle);
            PostsSeriesOverride(callInfo, sectionTitle);
            return callInfo;
        }

        [NonAction]
        partial void FuturePostsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string sectionTitle);

        [NonAction]
        public override System.Web.Mvc.ActionResult FuturePosts(string sectionTitle)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.FuturePosts);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "sectionTitle", sectionTitle);
            FuturePostsOverride(callInfo, sectionTitle);
            return callInfo;
        }

        [NonAction]
        partial void ListOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult List()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.List);
            ListOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void ContactMeOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult ContactMe()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ContactMe);
            ContactMeOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void TagsListOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult TagsList()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.TagsList);
            TagsListOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void ArchivesListOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult ArchivesList()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ArchivesList);
            ArchivesListOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void PostsStatisticsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult PostsStatistics()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.PostsStatistics);
            PostsStatisticsOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void RecentCommentsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string sectionTitle);

        [NonAction]
        public override System.Web.Mvc.ActionResult RecentComments(string sectionTitle)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RecentComments);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "sectionTitle", sectionTitle);
            RecentCommentsOverride(callInfo, sectionTitle);
            return callInfo;
        }

        [NonAction]
        partial void AdministrationPanelOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult AdministrationPanel()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AdministrationPanel);
            AdministrationPanelOverride(callInfo);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114

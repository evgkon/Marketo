using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace Marketo
{
    public static class HtmlHelpers
    {
        public static MvcHtmlString ActionLinkHtml(this AjaxHelper ajaxHelper, string linkText, string actionName,
                                        string controllerName, object routeValues, AjaxOptions ajaxOptions, object htmlAttributes)
        {
            var repID = Guid.NewGuid().ToString();
            var lnk = ajaxHelper.ActionLink(repID, actionName, controllerName, routeValues, ajaxOptions, htmlAttributes);
            return MvcHtmlString.Create(lnk.ToString().Replace(repID, linkText));
        }

        public static MvcHtmlString Label(string labelText)
        {
            return new MvcHtmlString(string.Format("<label>{0}</label>", labelText));
        }

        public static MvcHtmlString Label(string labelText, string forAssociatdControl)
        {
            return new MvcHtmlString(string.Format("<label for='{0}'>{1}</label>", forAssociatdControl, labelText));
        }

        public static MvcHtmlString MarketoForm()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("<script src= \"//app-sj31.marketo.com/js/forms2/js/forms2.min.js\"></script>");
            sb.AppendFormat("<form id=\"mktoForm_1008\"></form>");
            sb.AppendFormat("<script>MktoForms2.loadForm(\"//app-sj31.marketo.com\", \"682-XWP-826\", 1008);</script>");

            string h = sb.ToString();


            return new MvcHtmlString(h);
        }
    }
}
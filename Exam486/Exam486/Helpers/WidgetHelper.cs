using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exam486.Helpers
{
    public static class WidgetHelper
    {
        public static MvcHtmlString Widget(this HtmlHelper htmlHelper, IWidgetHtmlHelper widget)
        {
            return MvcHtmlString.Create(widget.Render());
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exam486.Helpers
{
    public class UserWidget : IWidgetHtmlHelper
    {
        private const string _template = @"<img class='nav-user-photo' src='/Content/images/user.jpg' alt='{0} {1}' /><span class='user-info'> <small>Welcome,</small> {0} </span>";

        public string Render()
        {
            return String.Format(_template, "Nelson", "Júnior");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewWeb.Models
{
    public partial class UCHitCount : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Show Hits
            object[] o = new object[2];
            o = new Hitcount().GetCount();
            lblTodayVisit.Text = o[0].ToString();
            lblTotalVisit.Text = o[1].ToString();
        }
    }
}
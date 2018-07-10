using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dz2zad1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.HyperLink2.NavigateUrl="Show_users.aspx";
        }

        protected void Button1_add_OnClick(object sender, EventArgs e)
        {
            if (_name.Text == "" || _familiy.Text == "" || _login.Text ==
                "" || _password.Text == "" || _city.Text == "" || _email.Text == "")
            {
                Label3.Visible = true;
                return;
            }
            else
            {
                Label3.Visible = false;
            }
            Singleton.Instens.Set_user(_name.Text,_familiy.Text,_login.Text,_email.Text,_password.Text,_city.Text,DropDownList2.SelectedItem.Text);
            _name.Text = null;
            _familiy.Text = null;
            _login.Text = null;
            _password.Text = null;
            _city.Text = null;
            _email.Text = null;
            DropDownList2.SelectedIndex = 0;
        }
    }
}
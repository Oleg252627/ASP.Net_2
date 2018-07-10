using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dz2zad1
{
    public partial class Rename_user : System.Web.UI.Page
    {
        private static int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            HyperLink1.NavigateUrl = "Show_users.aspx";
            if (!IsPostBack)
            {
                id = Convert.ToInt32(Request.QueryString["value"]);
                foreach (User VARIABLE in Singleton.Instens.UsersList)
                {
                    if (id == VARIABLE.Id)
                    {
                        this._name.Text = VARIABLE.Firs_name;
                        this._familiy.Text = VARIABLE.Last_name;
                        this._city.Text = VARIABLE.City;
                        this._password.Text = VARIABLE.Password;
                        this._email.Text = VARIABLE.Email;
                        this._login.Text = VARIABLE.Login;
                        foreach (ListItem V in DropDownList2.Items)
                        {
                            V.Selected = false;
                            if (VARIABLE.role.Name.Equals(V.Text))
                            {
                                V.Selected = true;
                            }
                        }
                    }
                }
            }
        }

        protected void LinkButton1_OnClick(object sender, EventArgs e)
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

            foreach (User user in Singleton.Instens.UsersList)
            {
                if (id == user.Id)
                {
                    user.Rename_user(_name.Text, _familiy.Text, _login.Text, _email.Text, _password.Text, _city.Text, DropDownList2.SelectedItem.Text);
                }
            }
            Server.Transfer("Show_users.aspx");
        }
    }
}
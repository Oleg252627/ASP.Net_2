using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dz2zad1
{
    public partial class Show_users : System.Web.UI.Page
    {
        public static List<string> list=new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Show_Users();
            }
            Create_linkButtom();
            this.LinkButton2.PostBackUrl = "Default.aspx";
            this.LinkButton1.PostBackUrl = "Delete.ashx";
        }

        private void Create_linkButtom()
        {
            foreach (User VARIABLE in Singleton.Instens.UsersList)
            {
                LinkButton button = new LinkButton();
                button.Text = "Редактировать";
                button.PostBackUrl = $"Rename_user.aspx?value={VARIABLE.Id}";
                this.Panel1.Controls.Add(button);
            }
        }

        private void Show_Users()
        {
            foreach (User VARIABLE in Singleton.Instens.UsersList)
            {
                CheckBoxList1.Items.Add("User " + VARIABLE.Id.ToString());
            }
        }

        protected void CheckBoxList1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < CheckBoxList1.Items.Count; i++)
            {
                if (CheckBoxList1.Items[i].Selected)
                {
                    this.LinkButton1.Visible = true;
                    break;
                }
                else
                {
                    this.LinkButton1.Visible = false;
                }
            }
            list.Clear();
            for (int j = 0; j < CheckBoxList1.Items.Count; j++)
            {
                if (CheckBoxList1.Items[j].Selected)
                {
                    String[] str = CheckBoxList1.Items[j].ToString().Split();
                    foreach (string s in str)
                    {
                        if (!s.Equals("User"))
                        {
                            list.Add(s);
                        }
                    }
                }
            }
        }
    }
}
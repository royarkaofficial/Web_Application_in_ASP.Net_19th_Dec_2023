using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomerWebApplication
{
    public partial class Customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            LblInfo.Visible = false;
        }

        protected void BtnReg_Click(object sender, EventArgs e)
        {
            LblInfo.Visible = true;
            LblInfo.Text = "Registration Done!!!<br/>";
            LblInfo.Text += "Name: " + TxtName.Text + "<br/>";
            LblInfo.Text += "Customer Mobile: " + TxtMobile.Text + "<br/>";
            LblInfo.Text += "Email: " + TxtEmail.Text + "<br/>";
            LblInfo.Text += "Password: " + TxtPwd.Text + "<br/>";
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string customername = TxtName.Text;
            args.IsValid = (customername.Length >= 6);
        }
    }
}
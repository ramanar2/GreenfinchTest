using Newsletters.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Newsletters
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //make sure the email is in valid format
            try
            {
                MailAddress emailAddress = new MailAddress(txtEmail.Text);

                //if email is correct proceed to check if its unique and push toi db
                NewsletterEntitiesSetup nes = new NewsletterEntitiesSetup();
                bool added = nes.Add(emailAddress.ToString(), ddlTelUs.SelectedValue.ToString(), txtReason.Text);

                if (added == true)
                {
                    Response.Write("Signed up successfully");
                }
                else
                {
                    Response.Write("Sign up failed");
                }
                
            }
            catch (FormatException ex)
            {
                Response.Write("Please enter a valid email!");
                
            }

            
        }
    }
}
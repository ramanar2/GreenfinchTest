using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Newsletters.Model
{
    public class NewsletterEntitiesSetup
    {
        private NotificationsDBEntities4 ndbe = new NotificationsDBEntities4();

        public bool Add(string email, string source, string reason)
        {
            bool added = false;
            Newsletter newsletter = new Newsletter();
            newsletter.C_ID = Guid.NewGuid().ToString();
            newsletter.email = email;
            newsletter.source = source;
            newsletter.reason = reason;

            //make sure passed up email is unique
            if (ndbe.Newsletters.Any(p => p.email == email))
            {
                added = false; 
            }
            else
            {
                added = true;
                ndbe.Newsletters.Add(newsletter);
                ndbe.SaveChanges();
            }
            return added;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactFormConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //ALWAYS FIRST create a connection to the database
            TravisEntities db = new TravisEntities();

            //add a new record to the contact form database
            //create a new contact form object
            ContactForm add = new ContactForm();
            //fill out our new object
            add.Name = "Dustin";
            add.Email = "dustin@seedpaths.com";
            add.CompanyName = "SeedPaths";
            add.Comments = "You guys are MF'n awesome!";

            //add it to the database
            db.ContactForms.Add(add);
            
            //save it
            db.SaveChanges();

            //retrieve a record from the database
            var contact = db.ContactForms.Find(1);

            //update the name
            contact.Name = "Billy Joel";

            //save changes
            db.SaveChanges();

            //delete a record from the database
            db.ContactForms.Remove(contact);

            //save changes
            db.SaveChanges();
        }
    }
}

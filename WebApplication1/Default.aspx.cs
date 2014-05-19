using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1 {
   public partial class Default : System.Web.UI.Page {
      protected void Page_Load(object sender, EventArgs e) {
         //getting a cookie
         var testCookie = Request.Cookies["test"];

         //creating a cookie
         var cookie = new HttpCookie("test") {
            Expires = DateTime.Now.AddDays(23),
            Value = "69"
         };
         Response.Cookies.Add(cookie);

         //deleting a cookie
         if (testCookie != null) {
            testCookie.Expires = DateTime.Now.AddDays(-1);
         }

         //modify a cookie
         if (testCookie != null) {
            testCookie.Value = "70";
         }
      }
   }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace ConfigarationTest
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String country,PrimeMinisrter,President;
            country = ConfigurationManager.AppSettings["Country"];
            PrimeMinisrter = ConfigurationManager.AppSettings["PrimeMinister"];
            President = ConfigurationManager.AppSettings["President"];
            Response.Write("Country: "+country+" <br/>PrimeMinister: "+PrimeMinisrter+"</br>President:"+President);
        }
    }
}
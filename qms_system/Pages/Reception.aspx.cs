using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace qms_system.Pages
{
    public partial class Reception : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //public void btnreception_Click(object sender, EventArgs e)
        //{
        //  int increase = 0;
        //increase++;
        //token_storage.Add(Convert.ToString(increase));
        //int calculate = token_storage.Count;
        //if(calculate == 0)
        //{
        //TextBox.text = "No customer in store";
        //}
        //else
        //{
        //TextBox.text = token_storage[0];
        //token_storage.Remove(token_storage[0]);
        //}

        //}

        public void btnreception_Click(object sender, EventArgs e)
        {
            Server.Transfer("PrintTokenTemplate.aspx");
        }
        public string Getname => customername.Text;
        public string Getlicense => license.Text;

        
    }

        
        



    
}
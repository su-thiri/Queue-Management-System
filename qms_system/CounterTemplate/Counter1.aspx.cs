using qms_system.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace qms_system.CounterTemplate
{
    public partial class Counter1 : System.Web.UI.Page
    {

        public static Int32 tk1;
        public static String token;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }


        }

        protected void nextbtn_Click(object sender, EventArgs e)
        {

            try
            {

                tk1 = Pages.PrintTokenTemplate.tokenQueue.Dequeue();
                
                token_num.Text = CommonFunction.ConvertTokenToStr(tk1);
                
                

            }
            catch (Exception ex)
            {
                token_num.Text = " No Customers ";
                Console.WriteLine(ex.Message);
            }

            

        }




    }
}

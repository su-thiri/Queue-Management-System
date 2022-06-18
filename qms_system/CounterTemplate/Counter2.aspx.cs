using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace qms_system.CounterTemplate
{
    public partial class Counter2 : System.Web.UI.Page
    {
        public static Int32 tk2;
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void counter2_btn_Click(object sender, EventArgs e)
        {
            try
            {
                tk2 = Pages.PrintTokenTemplate.tokenQueue.Dequeue();
                token_no_access.Text = Common.CommonFunction.ConvertTokenToStr(tk2);
            }
            catch (Exception ex)
            {
                token_no_access.Text = " No Customers ";
                Console.WriteLine(ex.Message);
            }
            


        }
       

        
    }
}
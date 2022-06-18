using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace qms_system.CounterTemplate
{
    public partial class Counter3 : System.Web.UI.Page
    {
        public static Int32 tk3;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void counter3_btn_Click(object sender, EventArgs e)
        {
            try
            {
                tk3 = Pages.PrintTokenTemplate.tokenQueue.Dequeue();
                token_no_access3.Text = Common.CommonFunction.ConvertTokenToStr(tk3);

            }
            catch (Exception ex)
            {
                token_no_access3.Text = " No Customers ";
                Console.WriteLine(ex.Message);  
            }
            

        }
        
        


    }
}
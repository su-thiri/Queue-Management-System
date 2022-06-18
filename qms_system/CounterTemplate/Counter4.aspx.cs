using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace qms_system.CounterTemplate
{
    public partial class Counter4 : System.Web.UI.Page
    {
        public static Int32 tk4;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void counter4_btn_Click(object sender, EventArgs e)
        {
            try
            {
                tk4 = Pages.PrintTokenTemplate.tokenQueue.Dequeue();
                token_no_access4.Text = Common.CommonFunction.ConvertTokenToStr(tk4);
            }
            catch (Exception ex)
            {
                token_no_access4.Text = " No Customers ";
                Console.WriteLine(ex.Message);
            }
            

        }
        public string Gettoken4 => token_no_access4.Text;
       
    }
}
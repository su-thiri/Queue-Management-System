using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace qms_system.CounterTemplate
{
    public partial class Counter5 : System.Web.UI.Page
    {
        public static Int32 tk5;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void counter5_btn_Click(object sender, EventArgs e)
        {
            try
            {
                tk5 = Pages.PrintTokenTemplate.tokenQueue.Dequeue();
                token_no_access5.Text = Common.CommonFunction.ConvertTokenToStr(tk5);
            }
            catch (Exception ex)
            {
                token_no_access5.Text = " No Customers ";
                Console.WriteLine(ex.Message);
            }
            


        }
        public string Gettoken5 => token_no_access5.Text;
        


    }
}
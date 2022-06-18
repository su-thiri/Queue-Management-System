using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.SessionState;
using System.IO;
using System.Reflection.Metadata;
using System.Collections;

namespace qms_system.Pages
{
    public partial class PrintTokenTemplate : Page
    {
        static int number;
        
        public static List<string> nextnumbertobeserved = new List<string>();

        public static Queue<int> tokenQueue = new Queue<int>();
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_Date.Text = "Date: " + DateTime.Now.ToString("yyyy-MM-dd / h:mm:ss tt");

            Reception reception;
            reception = (Reception)Context.Handler;
            txtusername.Text = "အမည် : " + reception.Getname;
            txtlicence.Text = "မော်တော်ယာဉ်အမှတ် : " + reception.Getlicense;
            
            if (number == null)
            {
                number = 0;
            }
            int nextTokenNumberTobeIssued = number + 1 ;
            number = nextTokenNumberTobeIssued;
            tokenQueue.Enqueue(nextTokenNumberTobeIssued);
            foreach (int token in tokenQueue)
            {
                txtshow_token.Text = "  Token : 000" + token.ToString();
                nextnumbertobeserved.Add(token.ToString());
                if (token > 9)
                {
                    txtshow_token.Text = "  Token : 00" + token.ToString();
                    nextnumbertobeserved.Add(token.ToString());
                }
                if(token > 99)
                {
                    txtshow_token.Text = "  Token : 0" + token.ToString();
                    nextnumbertobeserved.Add(token.ToString());
                }
                if(token > 999)
                {
                    txtshow_token.Text = "  Token : " + token.ToString();
                    nextnumbertobeserved.Add(token.ToString());
                }

            }

        }

    }
    
}
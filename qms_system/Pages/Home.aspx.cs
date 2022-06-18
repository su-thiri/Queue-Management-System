using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.SessionState;

namespace qms_system.Pages
{
    public partial class _Home : Page
    {
        
        public static int num = PrintTokenTemplate.nextnumbertobeserved.Count();
        protected void Page_Load(object sender, EventArgs e)
        {
 
            try
            {

                
                
                if (CounterTemplate.Counter1.tk1 == 0)
                {
                    lbltoshow1.Text = " Waiting.....";
                }
                lbltoshow1.Text = " Token : 000" + CounterTemplate.Counter1.tk1;
                if(lbltoshow1 != null)
                {
                   
                }



            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message);
            }



            try
            {
                
                
                
                if(CounterTemplate.Counter2.tk2 == 0)
                {
                    lbltoshow2.Text = " Waiting.....";
                }
                lbltoshow2.Text = " Token : 000" + CounterTemplate.Counter2.tk2;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            try
            {
                
                
                
                if (CounterTemplate.Counter3.tk3 == 0)
                {
                    lbltoshow3.Text = " Waiting.....";
                }
                lbltoshow3.Text = " Token : 000" + CounterTemplate.Counter3.tk3;
                


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            try
            {
                
                
                if (CounterTemplate.Counter4.tk4 == 0)
                {
                    lbltoshow4.Text = " Waiting.....";
                }
                lbltoshow4.Text = " Token : 000" + CounterTemplate.Counter4.tk4;
                


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }




            try
            {
                
                
                if (CounterTemplate.Counter5.tk5 == 0)
                {
                    lbltoshow5.Text = " Waiting.....";
                }
                lbltoshow5.Text = " Token : 000" + CounterTemplate.Counter5.tk5;
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            try
            {
                
                if((PrintTokenTemplate.tokenQueue.First().ToString()).Length == 1)
                {
                    lbltoshow6.Text = " Token : 000"+PrintTokenTemplate.tokenQueue.First().ToString();
                }
                if ((PrintTokenTemplate.tokenQueue.First().ToString()).Length == 2)
                {
                    lbltoshow6.Text = " Token : 00" + PrintTokenTemplate.tokenQueue.First().ToString();
                }
                if ((PrintTokenTemplate.tokenQueue.First().ToString()).Length == 3)
                {
                    lbltoshow6.Text = " Token : 0" + PrintTokenTemplate.tokenQueue.First().ToString();
                }
                if ((PrintTokenTemplate.tokenQueue.First().ToString()).Length == 4)
                {
                    lbltoshow6.Text = " Token : " + PrintTokenTemplate.tokenQueue.First().ToString();
                }

            }
            catch(Exception ex)
            {
                lbltoshow6.Text = " Waiting... ";
            }

            /* if (!IsPostBack)
            {
                
                lbltoshow1.Text = (string)Session["menuforcounter1"];
                lbltoshow2.Text = (string)Session["menuforcounter2"];
                lbltoshow3.Text = (string)Session["menuforcounter3"];
                lbltoshow4.Text = (string)Session["menuforcounter4"];
                lbltoshow5.Text = (string)Session["menuforcounter5"];
            }*/

         

        }

    }
}
using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace Chapter2_Listing_2_15
{
    public partial class Listing_2_15 : System.Web.UI.Page, System.Web.UI.ICallbackEventHandler
    {
        private string _callbackResult = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            string cbReference = Page.ClientScript.GetCallbackEventReference(this, "arg", "GetRandomNumberFromServer", "context");
            string cbScript = "function UseCallback(arg, context)" + "{" +cbReference + ";" + "}";
            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "UseCallback", cbScript, true);
        }
        public void RaiseCallbackEvent(string eventArg)
        {
            Random rnd = new Random();
            _callbackResult = rnd.Next().ToString();
        }
        public string GetCallbackResult()
        {
            return _callbackResult;
        }

    }
}
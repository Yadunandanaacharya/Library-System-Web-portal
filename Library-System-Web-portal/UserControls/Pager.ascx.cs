using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library_System_Web_portal.UserControls
{
    public partial class Pager : System.Web.UI.UserControl
    {
        private string _selectMethod = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string SelectMethod
        {
            set
            {
                _selectMethod = value;
            }
            get
            {
                return _selectMethod;
            }
        }
    }

    public class PagerData
    {
        public string LoadControlID { get; set; }
        public int PageSize { get; set; }
        public int PageIndex { get; set; }
        public string CurrentPageID { get; set; }
        public int CurrentPage { get; set; }
        public string Type { get; set; }
        public string SelectMethod { get; set; }
        public string ServiceMethod { get; set; }
        public object ExtraParam { get; set; }
        public string ServicePath { get; set; }
        public string PageAccessRights { get; set; }
        public int AccessLevelID { get; set; }
        public string PlantDateFormat { get; set; }
        public string PlantTimeFormat { get; set; }
    }
}
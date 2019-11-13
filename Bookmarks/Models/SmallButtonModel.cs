using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Bookmarks.Models
{
    public class SmallButtonModel
    {
        public string Action { get; set; }
        public string Text { get; set; }
        public string Glyph { get; set; }
        public string ButtonType { get; set; }
        public int? LinkId { get; set; }


        public string ActionParameter
        {
            get
            {
                var param = new StringBuilder("?");
                if (LinkId != null && LinkId > 0)
                    param.Append(String.Format("{0}={1}", "id", LinkId));

                return param.ToString();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sysinfo_MVC_AspNet.Models
{
    public class SysInfoViewModel
    {
        public string BodyContent { get; set; }

        public SysInfoViewModel(string content)
        {
            this.BodyContent = content;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfEntTool
{
    public class ConfLink
    {
        public int Id { get; set; }
        public string LinkName { get; set; }
        public string LinkUrl { get; set; }
        public string Password { get; set; }
        public bool PassEnabled { get; set; }
        public bool CopyUrl { get; set; }
    }
}

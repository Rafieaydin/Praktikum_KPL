using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class user
    {
        public string Name { get; set; }
        public Comment Comment { get; set; }
    }
    public class Comment
    {
        public string Title { get; set; }
    }
}

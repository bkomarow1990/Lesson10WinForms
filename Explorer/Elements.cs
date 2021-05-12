using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorer
{
    class Elements
    {
        public string Path { get; set; }
        public List<string> Directories;
        public List<string> Files;
        public Elements(string[] directories, string[] files)
        {
            Directories = new List<string>(directories);
            Files = new List<string>(files);
        }
    }
}

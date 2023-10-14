using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ART.Dynamic.Tools
{
    public class ScriptInfo
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public bool IsExe { get; set; }  // Flag to determine if it's an EXE or a script
        public string Arguments { get; set; } // Arguments for the EXE. Can be null/empty for scripts.

        public ScriptInfo(string name, string path, bool isExe = false, string arguments = null)
        {
            Name = name;
            Path = path;
            IsExe = isExe;
            Arguments = arguments;
        }
    }
}

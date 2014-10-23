using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhotoperiodScheduler.Core
{
    public class Preset
    {
        public string Name { get; set; }
        public string IrCode { get; set; }

        public Preset(string name, string irCode)
        {
            Name = name;
            IrCode = irCode;
        }

        public bool IsValid()
        {
            return (!String.IsNullOrWhiteSpace(Name) && !String.IsNullOrWhiteSpace(IrCode));
        }
    }
}
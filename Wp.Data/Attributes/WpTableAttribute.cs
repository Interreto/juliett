using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wp.Data.Attributes
{
    public class WpTableAttribute : TableAttribute
    {
        public WpTableAttribute(string name) 
            : base("wp_" + name)
        {
        }
    }
}

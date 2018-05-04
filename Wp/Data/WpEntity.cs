using System;
using System.Collections.Generic;
using System.Text;

namespace Wp.Data
{
    public abstract class WpEntity
    {
    }

    public abstract class WpEntity<T> : WpEntity where T : struct
    {
        public abstract T Id { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Wp
{
    public static class WpConfig
    {
        public static class Db
        {
            public static string Name => "www";
            public static string User => "root";
            public static string Password => "1";
            public static string Host => "localhost";
            public static string Charset => "utf8";
            public static string Collate => "";
            public static string TablePrefix => "wp_";
        }
    }
}

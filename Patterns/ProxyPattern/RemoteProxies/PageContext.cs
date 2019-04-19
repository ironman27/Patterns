﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.ProxyPattern.RemoteProxies
{
    class PageContext : DbContext
    {
        public DbSet<Page> Pages { get; set; }
    }
}

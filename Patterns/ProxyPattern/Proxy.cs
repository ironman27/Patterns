﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.ProxyPattern
{
    public class Proxy : Subject
    {
        Subject subject;
        public override void Request()
        {
            if (subject == null)
                subject = new RealSubject();
            subject.Request();
        }
    }
}

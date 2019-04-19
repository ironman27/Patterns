﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.BehavioralPatterns.ObserverPattern
{
    interface IObserver
    {
        void Update(Object ob);
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    public abstract class SandwichComponent
    {
        public abstract string Name { get; }  
        public abstract decimal Price { get; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices.Interfaces
{
    internal interface IPluggable
    {
        void PluggedIn();
        void PuggledOut();
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.AbstractFactory.CarTyre
{
    public class Michelin : ITyre
    {
        public string TyreInfo()
        {
            return "Michelin";
        }
    }
}

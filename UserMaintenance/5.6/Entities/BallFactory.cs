﻿using _5._6.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._6.Entities
{
    public class BallFactory : IToyFactory
    {
        public Toy CreateNew()
        {
            return new Ball();
        }

    }
}

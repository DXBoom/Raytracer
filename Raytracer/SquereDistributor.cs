﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raytracer
{
    class SquareDistributor : ISampleDistributor
    {
        public Vector2 MapSample(Vector2 sample)
        { return sample; }
    }
}

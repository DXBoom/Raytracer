﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Raytracer
{
    /* class HitInfo
     {
         public bool HitObject { get; set; }
         public Color Color { get; set; }
     }*/
    class HitInfo
    {
        /// <summary>Trafiony obiekt lub null jeśli promień w nic nie trafił</summary>
        public GeometricObject HitObject { get; set; }

        /// <summary>Referencja do świata który renderujemy</summary>
        public World World { get; set; }

        /// <summary>Normalna do punktu trafienia</summary>
        public Vector3 Normal { get; set; }

        /// <summary>Punkt trafienia (w koordynatach świata)</summary>
        public Vector3 HitPoint { get; set; }

        /// <summary>Promień który trafił obiekt</summary>
        public Ray Ray { get; set; }

        public int Depth { get; set; }
    }
}

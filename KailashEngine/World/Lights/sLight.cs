﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;

namespace KailashEngine.World.Lights
{
    class sLight : Light
    {


        public sLight(string id, Vector3 position, Vector3 rotation, float size, Vector3 color, float intensity, bool shadow)
            : base(id, position, rotation, size, color, intensity, shadow)
        {

        }

    }
}
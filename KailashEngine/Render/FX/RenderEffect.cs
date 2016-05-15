﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KailashEngine.Client;

namespace KailashEngine.Render.FX
{
    abstract class RenderEffect
    {

        protected ProgramLoader _pLoader;
        protected string _path_glsl_effect;


        public RenderEffect(ProgramLoader pLoader, string glsl_effect_path)
        {
            _pLoader = pLoader;
            _path_glsl_effect = glsl_effect_path;
        }

        protected abstract void load_Programs();

        public abstract void load();

        public abstract void unload();


    }
}

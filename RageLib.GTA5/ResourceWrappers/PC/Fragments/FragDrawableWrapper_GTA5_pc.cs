﻿/*
    Copyright(c) 2015 Neodymium

    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in
    all copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
    THE SOFTWARE.
*/

using RageLib.GTA5.ResourceWrappers.PC.Drawables;
using RageLib.Resources.GTA5.PC.Fragments;
using RageLib.ResourceWrappers.Drawables;
using RageLib.ResourceWrappers.Fragments;

namespace RageLib.GTA5.ResourceWrappers.PC.Fragments
{
    public class FragDrawableWrapper_GTA5_pc : IFragDrawable
    {
        private FragDrawable_GTA5_pc fragDrawable;

        public FragDrawableWrapper_GTA5_pc(FragDrawable_GTA5_pc fragDrawable)
        {
            this.fragDrawable = fragDrawable;
        }

        public string Name
        {
            get
            {
                return (string)fragDrawable.Name2;
            }
        }

        public IShaderGroup ShaderGroup
        {
            get
            {
                if (fragDrawable.ShaderGroup != null)
                    return new ShaderGroupWrapper_GTA5_pc(fragDrawable.ShaderGroup);
                else
                    return null;
            }
        }
    }
}

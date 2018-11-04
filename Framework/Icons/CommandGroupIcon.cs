﻿using CodeStack.SwEx.Common.Icons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CodeStack.SwEx.AddIn.Icons
{
    internal abstract class CommandGroupIcon : IIcon
    {
        private static readonly Color m_CommandTransparencyKey
            = Color.FromArgb(192, 192, 192);

        public Color TransparencyKey
        {
            get
            {
                return m_CommandTransparencyKey;
            }
        }

        public abstract IEnumerable<IconSizeInfo> GetHighResolutionIconSizes();
        public abstract IEnumerable<IconSizeInfo> GetIconSizes();
    }
}

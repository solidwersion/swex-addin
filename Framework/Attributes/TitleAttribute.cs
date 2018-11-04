﻿//**********************
//SwEx.AddIn - development tools for SOLIDWORKS add-ins
//Copyright(C) 2018 www.codestack.net
//License: https://github.com/codestack-net-dev/sw-dev-tools-addin/blob/master/LICENSE
//Product URL: https://www.codestack.net/labs/solidworks/swex/add-in/
//**********************

using CodeStack.SwEx.Common.Reflection;
using System;
using System.ComponentModel;

namespace CodeStack.SwEx.AddIn.Attributes
{
    /// <summary>
    /// Decorates the display name for the element (e.g. command)
    /// </summary>
    /// <remarks>Can be applied to can be applied to command group (defined as enumeration) and items within the group (defined as enumeration value)</remarks>
    [AttributeUsage(AttributeTargets.All)]
    public class TitleAttribute : DisplayNameAttribute
    {   
        public TitleAttribute(string dispName) : base(dispName)
        {
        }

        /// <param name="resType">Type of the static class (usually Resources)</param>
        /// <param name="masterResName">Resource name of the string for display name</param>
        public TitleAttribute(Type resType, string dispNameResName)
            : this(ResourceHelper.GetResource<string>(resType, dispNameResName))
        {
        }
    }
}

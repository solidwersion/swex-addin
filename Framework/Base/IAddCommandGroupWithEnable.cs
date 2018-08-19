﻿//**********************
//Development tools for SOLIDWORKS add-ins
//Copyright(C) 2018 www.codestack.net
//License: https://github.com/codestack-net-dev/sw-dev-tools-addin/blob/master/LICENSE
//Product URL: https://www.codestack.net/labs/solidworks/dev-tools-addin/
//**********************

using CodeStack.Dev.Sw.AddIn.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeStack.Dev.Sw.AddIn
{
    public interface IAddCommandGroupWithEnable<TCmdEnum> : IAddCommandGroup<TCmdEnum>
            where TCmdEnum : IComparable, IFormattable, IConvertible
    {
        void Enable(TCmdEnum cmd, ref CommandItemEnableState_e state);
    }
}
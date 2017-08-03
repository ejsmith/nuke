﻿// Copyright Matthias Koch 2017.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

using System;
using System.Linq;

namespace Nuke.Core.Execution
{
    internal interface IBuild
    {
        string[] Target { get; set; }

        bool NoDependencies { get; set; }
    }
}

﻿using Cake.Common.Tools.DotNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake.DotNetCoreEf
{
    /// <summary>
    /// Contains common settings used by <see cref="DotNetCoreEfTool{TSettings}" />.
    /// </summary>
    public class DotNetCoreEfSettings : DotNetCoreSettings
    {
        /// <summary>
        /// Show help information
        /// </summary>
        public bool Help { get; set; }

        /// <summary>
        /// The environment to use. If omitted, "Development" is used.
        /// </summary>
        public string Environment { get; set; }
    }
}

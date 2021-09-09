﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sels.Crypto.Chia.PlotBot.Models.Config
{
    /// <summary>
    /// Contains shared config settings 
    /// </summary>
    public abstract class SharedConfig
    {
        /// <summary>
        /// Unique name to identifiy this component.
        /// </summary>
        public string Alias { get; set; }

        /// <summary>
        /// Boolean indicating if this component is enabled and can be used by plot bot.
        /// </summary>
        public bool Enabled { get; set; } = true;

        /// <summary>
        /// How many hours before a plotting instance is considered timed out. This will cause Plot Bot to dispose the instance and raise an error.
        /// </summary>
        public int? Timeout { get; set; }

        /// <summary>
        /// How many instances this component can use.
        /// </summary>
        public int? MaxInstances { get; set; }

        /// <summary>
        /// Contains config on when a new instance is allowed to plot to a drive.
        /// </summary>
        public ComponentConfig[] Delay { get; set; }
    }
}

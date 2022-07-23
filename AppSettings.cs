/******************************************************************************
**  Copyright(c) 2022 ignackoo. All rights reserved.
**
**  Licensed under the MIT license.
**  See LICENSE file in the project root for full license information.
**
**  This file is a part of the C# Library AppSettings.
** 
**  Read Application settings parameter values
**
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public class AppSettings
    {
        /// <summary>
        /// Get AppSettings parameter value.
        /// </summary>
        /// <param name="key">Key parameter.</param>
        /// <returns>Value parameter.</returns>
        public static string Get(string key)
        { 
            return (System.Configuration.ConfigurationManager.AppSettings[key]);
        }
    }
}

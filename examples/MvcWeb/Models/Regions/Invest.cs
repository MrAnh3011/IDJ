/*
 * Copyright (c) 2017-2018 Håkan Edling
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 *
 * http://github.com/tidyui/coreweb
 *
 */

using System.Collections.Generic;
using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;

namespace MvcWeb.Models.Regions
{
    /// <summary>
    /// Simple region for a teaser.
    /// </summary>
    public class Invest
    {
        [Field(Options = FieldOption.HalfWidth)]
        public ImageField Image { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField Title { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField Description { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField Finished { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField Address { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField Shedule { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField Link { get; set; }
    }
}

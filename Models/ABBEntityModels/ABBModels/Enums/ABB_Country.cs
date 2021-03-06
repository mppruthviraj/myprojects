﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABB_Portal.Models.ABBEntityModels.ABBModels.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ABB_Country
    {
        India,
        US,
        UK,
        [Display(Name ="North Korea")]
        NorthKorea
    }
}

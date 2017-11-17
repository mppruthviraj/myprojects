using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABB_Portal.Models.ABBEntityModels.ABBModels.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ABB_SubCategory
    {
        Generation,
        Transmission,
        Distribution
    }
}

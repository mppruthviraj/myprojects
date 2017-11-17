using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ABB_Portal.Models.ABBEntityModels.ABBModels.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ABB_Category
    {
        Utilities,
        Industries,
        [Display(Name = "Transaction & Infrastructure")]
        TransactionAndInfrastructure
    }
}
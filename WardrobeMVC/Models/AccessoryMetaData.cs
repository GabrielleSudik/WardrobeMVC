using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WardrobeMVC.Models
{
    [MetadataType(typeof(Accessory.MetaData))]

    public partial class Accessory
    {

        sealed class MetaData
        {

            public int AccessoryID { get; set; }

            [Display(Name = "Flair")]
            public string AccessoryName { get; set; }
            public string Photo { get; set; }
            public string Type { get; set; }
            public string Color { get; set; }
            public string Style { get; set; }
            public string Occasion { get; set; }

        }
    }
}
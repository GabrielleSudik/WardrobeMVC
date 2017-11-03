using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WardrobeMVC.Models
{
    [MetadataType(typeof(Top.MetaData))]

    public partial class Top
    {

        sealed class MetaData
        {

            public int TopID { get; set; }

            [Display(Name = "Top")]
            public string TopName { get; set; }
            public string Photo { get; set; }
            public string Type { get; set; }
            public string Color { get; set; }
            public string Style { get; set; }
            public string Occasion { get; set; }

        }
    }
}
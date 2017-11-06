using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

//this is a metadata/buddy class. make data annotations here

namespace WardrobeMVC.Models
{
    [MetadataType(typeof(Bottom.MetaData))]

    public partial class Bottom
    {

        sealed class MetaData
        {

            public int BottomID { get; set; }

            [Display(Name = "Bottom")]
            public string TopName { get; set; }
            public string Photo { get; set; }
            public string Type { get; set; }
            public string Color { get; set; }
            public string Style { get; set; }
            public string Occasion { get; set; }

        }
    }
}
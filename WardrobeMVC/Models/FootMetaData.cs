using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

//this is the metadata class you created (buddy class)
//to make data annotations to your Foot class/model

namespace WardrobeMVC.Models
{
    [MetadataType(typeof(Foot.MetaData))]

    //the following lines created automaticall when you made the class. 
    //so you coded them out

    //public class FootMetaData
    //{
    //}

    public partial class Foot
    {

        sealed class MetaData
        {
            [Key]
            public int FeetID { get; set; }

            [Display(Name = "Feet")]
            public string ShoeName { get; set; }
            public string Photo { get; set; }
            public string Type { get; set; }
            public string Color { get; set; }
            public string Style { get; set; }
            public string Occasion { get; set; }

        }
    }
}
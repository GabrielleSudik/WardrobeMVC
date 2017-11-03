using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WardrobeMVC.Models
{
    [MetadataType(typeof(Outfit.MetaData))]

    public partial class Outfit
    {

        sealed class MetaData
        {

            public int OutfitID { get; set; }
            public int TopID { get; set; }
            public int BottomID { get; set; }
            public int FeetID { get; set; }
            public Nullable<int> AccessoryID { get; set; }
            public string OutfitName { get; set; }

            //fyi your main Outfit model includes the following virtual classes
            //but they give error messages.
            //hopefully they aren't needed here, as each one is edited in its own class
            //and the virtuals will be pulled in through the main Outfit model
            //so you will edit them out

            //public virtual Accessory Accessory { get; set; }
            //public virtual Bottom Bottom { get; set; }
            //public virtual Foot Foot { get; set; }
            //public virtual Top Top { get; set; }
        }
    }
}
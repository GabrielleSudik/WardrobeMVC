using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WardrobeMVC.Models
{
    [MetadataType(typeof(Recommendation.MetaData))]

    public partial class Recommendation
    {

        sealed class MetaData
        {

            public int RecommendationID { get; set; }
            public int FeetID { get; set; }
            public int AccessoryID { get; set; }

            //note the main Recommendation method includes some virtual classes
            //you left them out, because they'll just give an error message
            //but they should be edited themselves elsewhere, so it's ok.
        }
    }
}
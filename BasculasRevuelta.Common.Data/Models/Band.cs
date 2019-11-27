namespace BasculasRevuelta.Common.Data.Models
{
    

    // Bands
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class Band
    {
        public System.DateTime CreatedOn { get; set; } // CreatedOn
        public string CreatedBy { get; set; } // CreatedBy
        public System.DateTime UpdatedOn { get; set; } // UpdatedOn
        public string UpdatedBy { get; set; } // UpdatedBy
        public System.Guid BandId { get; set; } // BandId (Primary key)
        public string Name { get; set; } // Name (length: 250)

        // Reverse navigation

        /// <summary>
        /// Child Tours where [Tours].[BandId] point to this entity (FK_Tours_Bands_BandId)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Tour> Tours { get; set; } // Tours.FK_Tours_Bands_BandId

        public Band()
        {
            Tours = new System.Collections.Generic.List<Tour>();
        }
    }

}

namespace BasculasRevuelta.Common.Data.Models
{
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class Manager
    {
        public System.DateTime CreatedOn { get; set; } // CreatedOn
        public string CreatedBy { get; set; } // CreatedBy
        public System.DateTime UpdatedOn { get; set; } // UpdatedOn
        public string UpdatedBy { get; set; } // UpdatedBy
        public System.Guid ManagerId { get; set; } // ManagerId (Primary key)
        public string Name { get; set; } // Name

        // Reverse navigation

        /// <summary>
        /// Child Tours where [Tours].[ManagerId] point to this entity (FK_Tours_Managers_ManagerId)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Tour> Tours { get; set; } // Tours.FK_Tours_Managers_ManagerId

        public Manager()
        {
            Tours = new System.Collections.Generic.List<Tour>();
        }
    }
}
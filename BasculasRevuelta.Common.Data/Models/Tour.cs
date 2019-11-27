using System;
using System.Collections.Generic;

namespace BasculasRevuelta.Common.Data.Models
{
    public class Tour
    {
        public System.DateTime CreatedOn { get; private set; } // CreatedOn
        public string CreatedBy { get; private set; } // CreatedBy
        public System.DateTime UpdatedOn { get; set; } // UpdatedOn
        public string UpdatedBy { get; private set; } // UpdatedBy
        public System.Guid TourId { get; private set; } // TourId (Primary key)

        public string Title { get; set; } // Title (length: 200)
        public string Description { get; set; } // Description (length: 2000)
        public decimal EstimatedProfits { get; set; } // EstimatedProfits
        public System.DateTimeOffset StartDate { get; set; } // StartDate
        public System.DateTimeOffset EndDate { get; set; } // EndDate
        public System.Guid BandId { get; set; } // BandId
        public System.Guid ManagerId { get; set; } // ManagerId
        public bool Canelado { get; private set; }

        public void Canela()
        {
            Canelado = false;
        }

        // Reverse navigation

        /// <summary>
        /// Child Shows where [Shows].[TourId] point to this entity (FK_Shows_Tours_TourId)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Show> Shows { get; set; } // Shows.FK_Shows_Tours_TourId

        // Foreign keys

        /// <summary>
        /// Parent Band pointed by [Tours].([BandId]) (FK_Tours_Bands_BandId)
        /// </summary>
        public virtual Band Band { get; set; } // FK_Tours_Bands_BandId

        /// <summary>
        /// Parent Manager pointed by [Tours].([ManagerId]) (FK_Tours_Managers_ManagerId)
        /// </summary>
        public virtual Manager Manager { get; set; } // FK_Tours_Managers_ManagerId

        //protected Tour()
        //{
        //    Shows = new System.Collections.Generic.List<Show>();
        //}


        public static Tour GetCreateShow(ICollection<Show> shows)
        {
            if (shows==null)
                throw new Exception("No se vele shows nulos");

            if (shows.Count < 1)
                throw new Exception();


            return new Tour
            {
                TourId = new Guid(),
                CreatedOn = DateTime.Now,
                Shows = shows
            };
        }
    }
}
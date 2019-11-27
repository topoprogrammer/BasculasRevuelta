using System;
using BasculasRevuelta.Common.Data.ViewModel;

namespace BasculasRevuelta.Common.Data.Models
{
    public class Show
    {
        public System.DateTime CreatedOn { get; set; } // CreatedOn
        public string CreatedBy { get; set; } // CreatedBy
        public System.DateTime UpdatedOn { get; set; } // UpdatedOn
        public string UpdatedBy { get; private set; } // UpdatedBy
        public System.Guid ShowId { get; set; } // ShowId (Primary key)
        public System.DateTimeOffset Date { get; set; } // Date
        public string Venue { get; set; } // Venue (length: 150)
        public string City { get; set; } // City (length: 100)
        public string Country { get; set; } // Country (length: 100)
        public System.Guid TourId { get; set; } // TourId

        // Foreign keys

        /// <summary>
        /// Parent Tour pointed by [Shows].([TourId]) (FK_Shows_Tours_TourId)
        /// </summary>
        public virtual Tour Tour { get; set; } // FK_Shows_Tours_TourId

        /*
        protected Show()
        {
        }
        */

        public void Update()
        {
            UpdatedBy = "UsuarioQueActualizo";
        }
        /*
        public static Show GetCreateShow(ShowForCreation show)
        {
            return new Show
            {
                ShowId = new Guid(),
                CreatedOn = DateTime.Now,
            };
        }

        public static Show GetUpdatedShow()
        {
            return new Show
            {
                ShowId = new Guid(),
                CreatedOn = DateTime.Now,
            };
        }
        */
    }
}
using BasculasRevuelta.Common.Data.Models;
using BasculasRevuelta.Data.EntityFramework.Sql;
using NUnit.Framework;
using System;
using System.Linq;
using FluentAssertions;

namespace BasculasRevuelta.Data.EntityFramework.IntegrationTest
{
    [TestFixture]
    public class BandTest
    {
        [Test]
        public void Si_BandaEsGuardadaEnDb_Deberia_RegresarInstancia()
        {
            var newBand = new Band
            {
                BandId = Guid.NewGuid(),
                CreatedBy = "usuario",
                CreatedOn = DateTime.Now,
                Name = "Los Capi",
                UpdatedBy = "usuarioUpdate",
                UpdatedOn=DateTime.Now
            };

            var dbContext = new BasculasRevueltaDbContext();
            dbContext.Bands.Add(newBand);
            dbContext.SaveChanges();

            var insertedBand = dbContext.Bands.Single(x => x.BandId == newBand.BandId);

            newBand.Should().BeEquivalentTo(insertedBand);

        }

        [Test]
        public void Si_BandaEsActualizadaEnDb_Deberia_RegresarInstanciaActualizada()
        {
            var newBand = new Band
            {
                BandId = Guid.NewGuid(),
                CreatedBy = "usuario",
                CreatedOn = DateTime.Now,
                Name = "Los Capi",
                UpdatedBy = "usuarioUpdate",
                UpdatedOn = DateTime.Now
            };

            var dbContext = new BasculasRevueltaDbContext();
            dbContext.Bands.Add(newBand);
            dbContext.SaveChanges();

            var insertedBand = dbContext.Bands.Single(x => x.BandId == newBand.BandId);

            newBand.Should().BeEquivalentTo(insertedBand);

        }

    }

}

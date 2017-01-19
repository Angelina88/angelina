using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using AutoMapper;
using EFCore.Mapping;
using EFCore.Domain;
using Ploeh.AutoFixture;
using EFCore.DTO;

namespace EFCoreTests
{
    [TestClass]
    public class MapperTests
    {
        private static Fixture _fixture;

        [ClassInitialize]
        public static void SuiteSetup(TestContext context)
        {
            var assembly = Assembly.GetAssembly(typeof(EntityProfile));
            Mapper.Initialize(cfg => cfg.AddProfiles(assembly));

            _fixture = new Fixture();
        }

        [TestMethod]
        public void EntityToDtoTest()
        {
            var city = _fixture.Create<City>();
            var entityDto = Mapper.Map<EntityDto>(city);
            Assert.AreEqual(city.Id, entityDto.Id);
            Assert.AreEqual(city.Name, entityDto.Name);
            Assert.AreEqual(city.Created, entityDto.Created);
            Assert.AreEqual(city.Updated, entityDto.Updated);
        }

        [TestMethod]
        public void PlaceToDtoTest()
        {
            var place = _fixture.Create<Place>();
            var placeDto = Mapper.Map<PlaceDto>(place);

            Assert.AreEqual(place.Engine.Name, placeDto.EngineName);
            Assert.AreEqual(place.City.Name, placeDto.CityName);
        }

        [TestMethod]
        public void DtoToPlaceTest()
        {
            var placeDto = _fixture.Create<PlaceDto>();
            var place = Mapper.Map<Place>(placeDto);

            Assert.AreEqual(placeDto.Id, place.Id);
            Assert.AreEqual(placeDto.GroupName, place.GroupName);

            Assert.IsNull(place.Engine);
            Assert.IsNull(place.City);
        }
    }
}

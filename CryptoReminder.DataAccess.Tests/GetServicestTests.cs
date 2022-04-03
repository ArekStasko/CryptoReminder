using NUnit.Framework;
using CryptoReminder.DataAccess;
using FluentAssertions;

namespace CryptoReminder.DataAccess.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetCurrencies_ShouldReturn_ListOfCurrencies()
        {
            var getServices = DataAccessFactory.GetServicesInstance();
            var data = getServices.GetCurrencies();

            data.Result.Should().NotBeEmpty();
        }

        [Test]
        public void GetBTCData_ShouldReturn_DataOfBTC()
        {
            var getServices = DataAccessFactory.GetServicesInstance();
            var data = getServices.GetBTCData();

            data.Result.Should().NotBeNull();
        }

        [Test]
        public void GetETHData_ShouldReturn_DataOfETH()
        {
            var getServices = DataAccessFactory.GetServicesInstance();
            var data = getServices.GetETHData();

            data.Result.Should().NotBeNull();
        }
    }
}
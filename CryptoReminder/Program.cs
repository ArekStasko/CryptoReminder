using CryptoReminder.DataAccess;

var services = DataAccessFactory.GetServicesInstance();
var data = services.GetCurrencies().Result;

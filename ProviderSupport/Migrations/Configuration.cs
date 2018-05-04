namespace ProviderSupport.Migrations
{
    using ProviderSupport.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProviderSupport.DAL.ProviderSupportContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        // runs every time update-database command is issued -- adds if not present, updates if present
        // NOTE: *** MUST FIX - ASSUMING UNIQUE LAST NAMES see: https://blogs.msdn.microsoft.com/rickandy/2013/02/12/seeding-and-debugging-entity-framework-ef-dbs/
        protected override void Seed(ProviderSupport.DAL.ProviderSupportContext context)
        {
           /* var serviceTypes = new List<ServiceType>
            {
                new ServiceType { ServiceTypeID = 1, Desc = "Hours", DescLong ="OR955269 Attendant Care, Home or Community" },
                new ServiceType { ServiceTypeID = 2, Desc = "Relief Care", DescLong ="OR955079 Relief Care, Daily" },
                new ServiceType { ServiceTypeID = 3, Desc = "Transportation", DescLong ="OR950049 Service-Related Transportation" },
                new ServiceType { ServiceTypeID = 4, Desc = "Employment", DescLong ="Employment" },
                new ServiceType { ServiceTypeID = 5, Desc = "DSA", DescLong ="OR955429 Day Support Activity, non-work" },
                new ServiceType { ServiceTypeID = 6, Desc = "Administrative", DescLong ="Administrative" },
                new ServiceType { ServiceTypeID = 7, Desc = "Provider Training (in-home care)", DescLong ="Provider Training (in-home care)" },
                new ServiceType { ServiceTypeID = 8, Desc = "Provider Training (employment)", DescLong ="Provider Training (employment)" },
                new ServiceType { ServiceTypeID = 9, Desc = "Employee Development Training", DescLong ="Employee Development Training" },
                new ServiceType { ServiceTypeID = 10, Desc = "Sick Leave", DescLong ="Sick Leave" },
                new ServiceType { ServiceTypeID = 11, Desc = "Between-Client Mileage (or Other Unreimbursed)", DescLong ="Between-Client Mileage or Other Unreimbursed Mileage" },
                new ServiceType { ServiceTypeID = 12, Desc = "Expenses (Reimbursable)", DescLong ="Expenses (Reimbursable)" },
                };
            serviceTypes.ForEach(s => context.ServiceTypes.AddOrUpdate(p => p.ServiceTypeID, s));
            context.SaveChanges();*/

            var billToOrgs = new List<BillToOrg>
            {
                new BillToOrg { Name = "Billing Org 1", Type = 1, PhoneNum = "123.456.7890", Email = "dsf@msb.com",Address1="123 Main St.", Address2="Apt 123", Address3="Portland, OR 45678" },
                new BillToOrg { Name = "Billing Org 2", Type = 2, PhoneNum = "123.456.7890", Email = "dsf@msb.com",Address1="123 Main St.", Address2="Apt 123", Address3="Portland, OR 45678" },
                new BillToOrg { Name = "Billing Org 3", Type = 3, PhoneNum = "123.456.7890", Email = "dsf@msb.com",Address1="123 Main St.", Address2="Apt 123", Address3="Portland, OR 45678" }
            };
            billToOrgs.ForEach(s => context.BillToOrgs.AddOrUpdate(p => p.Name, s));
            context.SaveChanges();

            var counsPas = new List<CounsPa>
            {
                new CounsPa { Name = "Barbara Comfort", PhoneNum = "350.000.1239", Email ="dft@gfd.com", BillToOrgID = billToOrgs.Single( i => i.Name == "Billing Org 1").BillToOrgID },
                new CounsPa { Name = "Henry Marks", PhoneNum = "350.000.1239", Email ="dft@gfd.com", BillToOrgID = billToOrgs.Single( i => i.Name == "Billing Org 3").BillToOrgID },
                new CounsPa { Name = "Stephanie Hanks", PhoneNum = "350.000.1239", Email ="dft@gfd.com", BillToOrgID = billToOrgs.Single( i => i.Name == "Billing Org 2").BillToOrgID }
            };
            counsPas.ForEach(s => context.CounsPas.AddOrUpdate(p => p.Name, s));
            context.SaveChanges();

            var providers = new List<Provider>
            {
            new Provider{FirstName="Carson",LastName="Alexander",PhoneNum="503.332.4569",Email="testemail@msn.com",BirthDate=DateTime.Parse("2005-09-01"),PayRate=10.00,CprExpDate=DateTime.Parse("2018-01-01")},
            new Provider{FirstName="Meredith",LastName="Alonso",PhoneNum="503.332.4569",Email="testemail@msn.com",BirthDate=DateTime.Parse("2005-02-01"),PayRate=10.00,CprExpDate=DateTime.Parse("2018-01-01")},
            new Provider{FirstName="Arturo",LastName="Anand",PhoneNum="503.332.4569",Email="testemail@msn.com",BirthDate=DateTime.Parse("2005-04-01"),PayRate=10.00,CprExpDate=DateTime.Parse("2018-01-01")},
            new Provider{FirstName="Gytis",LastName="Barzdukas",PhoneNum="503.332.4569",Email="testemail@msn.com",BirthDate=DateTime.Parse("2005-05-01"),PayRate=10.00,CprExpDate=DateTime.Parse("2018-01-01")},
            new Provider{FirstName="Yan",LastName="Li",PhoneNum="503.332.4569",Email="testemail@msn.com",BirthDate=DateTime.Parse("2005-06-01"),PayRate=10.00,CprExpDate=DateTime.Parse("2018-01-01")},
            new Provider{FirstName="Peggy",LastName="Justice",PhoneNum="503.332.4569",Email="testemail@msn.com",BirthDate=DateTime.Parse("2005-03-01"),PayRate=10.00,CprExpDate=DateTime.Parse("2018-01-01")},
            new Provider{FirstName="Laura",LastName="Norman",PhoneNum="503.332.4569",Email="testemail@msn.com",BirthDate=DateTime.Parse("2005-09-01"),PayRate=10.00,CprExpDate=DateTime.Parse("2018-01-01")},
            new Provider{FirstName="Nino",LastName="Olivetto",PhoneNum="503.332.4569",Email="testemail@msn.com",BirthDate=DateTime.Parse("2005-12-01"),PayRate=10.00,CprExpDate=DateTime.Parse("2018-01-01")}
            };
            providers.ForEach(s => context.Providers.AddOrUpdate(p => p.LastName, s));
            context.SaveChanges();

            var clients = new List<Client>
            {
            new Client{PrimeNo="EW1234563",FirstName="Fred",LastName="Alexander",PhoneNum="503.332.4569",Email="testemail@msn.com",BirthDate=DateTime.Parse("2005-09-01"),EmergencyName="Ava Frederickson",EmergencyEmail="ava@test.com",EmergencyPhone="456.789.1231",CounsPaID=5},
            new Client{PrimeNo="SA4567891",FirstName="Fanny",LastName="Banks",PhoneNum="503.332.4569",Email="testemail@msn.com",BirthDate=DateTime.Parse("2005-09-01"),EmergencyName="Ava Frederickson",EmergencyEmail="ava@test.com",EmergencyPhone="456.789.1231",CounsPaID=5},
            new Client{PrimeNo="YH45678944",FirstName="Myrtle",LastName="Curry",PhoneNum="503.332.4569",Email="testemail@msn.com",BirthDate=DateTime.Parse("2005-09-01"),EmergencyName="Ava Frederickson",EmergencyEmail="ava@test.com",EmergencyPhone="456.789.1231",CounsPaID=5},
            new Client{PrimeNo="TR45645644",FirstName="Bud",LastName="Drake",PhoneNum="503.332.4569",Email="testemail@msn.com",BirthDate=DateTime.Parse("2005-09-01"),EmergencyName="Ava Frederickson",EmergencyEmail="ava@test.com",EmergencyPhone="456.789.1231",CounsPaID=5}
            };
            clients.ForEach(s => context.Clients.AddOrUpdate(p => p.LastName, s));
            context.SaveChanges();

            var transactions = new List<Transaction>
            {
            new Transaction{TimeStamp=DateTime.Now,ProviderID=1,ClientID=3,DateWorked=DateTime.Parse("4/30/2018"),ServiceTypeID=1,TimeIn=new DateTime(2001,01,01,8,00,0),TimeOut=new DateTime(2001,01,01,17,00,0),ServiceDesc="Played Baseball.",ProgressNote="Test",TravelPurpose="Test",ExpenseVendor="Test",ExpensePurpose="Test"},
            new Transaction{TimeStamp=DateTime.Now,ProviderID=2,ClientID=3,DateWorked=DateTime.Parse("4/30/2018"),ServiceTypeID=1,TimeIn=new DateTime(2001,01,01,8,00,0),TimeOut=new DateTime(2001,01,01,17,00,0),ServiceDesc="Played Baseball.",ProgressNote="Test",TravelPurpose="Test",ExpenseVendor="Test",ExpensePurpose="Test"},
            new Transaction{TimeStamp=DateTime.Now,ProviderID=2,ClientID=2,DateWorked=DateTime.Parse("4/30/2018"),ServiceTypeID=1,TimeIn=new DateTime(2001,01,01,8,00,0),TimeOut=new DateTime(2001,01,01,17,00,0),ServiceDesc="Played Baseball.",ProgressNote="Test",TravelPurpose="Test",ExpenseVendor="Test",ExpensePurpose="Test"},
            new Transaction{TimeStamp=DateTime.Now,ProviderID=4,ClientID=1,DateWorked=DateTime.Parse("4/30/2018"),ServiceTypeID=3,TimeIn=new DateTime(2001,01,01,8,00,0),TimeOut=new DateTime(2001,01,01,17,00,0),ServiceDesc="Played Baseball.",ProgressNote="Test",TravelPurpose="Test",ExpenseVendor="Test",ExpensePurpose="Test"},
            new Transaction{TimeStamp=DateTime.Now,ProviderID=5,ClientID=3,DateWorked=DateTime.Parse("4/30/2018"),ServiceTypeID=1,TimeIn=new DateTime(2001,01,01,8,00,0),TimeOut=new DateTime(2001,01,01,17,00,0),ServiceDesc="Played Baseball.",ProgressNote="Test",TravelPurpose="Test",ExpenseVendor="Test",ExpensePurpose="Test"},
            new Transaction{TimeStamp=DateTime.Now,ProviderID=6,ClientID=2,DateWorked=DateTime.Parse("4/30/2018"),ServiceTypeID=1,TimeIn=new DateTime(2001,01,01,8,00,0),TimeOut=new DateTime(2001,01,01,17,00,0),ServiceDesc="Played Baseball.",ProgressNote="Test",TravelPurpose="Test",ExpenseVendor="Test",ExpensePurpose="Test"},
            new Transaction{TimeStamp=DateTime.Now,ProviderID=7,ClientID=2,DateWorked=DateTime.Parse("4/30/2018"),ServiceTypeID=1,TimeIn=new DateTime(2001,01,01,8,00,0),TimeOut=new DateTime(2001,01,01,17,00,0),ServiceDesc="Played Baseball.",ProgressNote="Test",TravelPurpose="Test",ExpenseVendor="Test",ExpensePurpose="Test"},
            new Transaction{TimeStamp=DateTime.Now,ProviderID=3,ClientID=1,DateWorked=DateTime.Parse("4/30/2018"),ServiceTypeID=1,TimeIn=new DateTime(2001,01,01,8,00,0),TimeOut=new DateTime(2001,01,01,17,00,0),ServiceDesc="Played Baseball.",ProgressNote="Test",TravelPurpose="Test",ExpenseVendor="Test",ExpensePurpose="Test"}
            };

            foreach (Transaction e in transactions)
            {
                var transactionInDataBase = context.Transactions.Where(
                    s =>
                         s.Provider.ProviderID == e.ProviderID &&
                         s.Client.ClientID == e.Client.ClientID).SingleOrDefault();
                if (transactionInDataBase == null)
                {
                    context.Transactions.Add(e);
                }
            }
            context.SaveChanges();


        }
    }
}
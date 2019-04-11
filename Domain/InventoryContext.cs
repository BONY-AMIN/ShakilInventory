using Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class InventoryContext : DbContext
    {
        public InventoryContext() : base("InventoryDBMS")
        {
            
        }
        public DbSet<ProcurementType> Procurements { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Principle> Principles { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<District> Districts { get; set; }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<Religion> Religions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<SubSubCategory> SubSubCategories { get; set; }
        public DbSet<SubSubSubCategory> SubSubSubCategories { get; set; }
        public DbSet<SubSubSubSubCategory> SubSubSubSubCategories { get; set; }
        public DbSet<Festival> Festivals { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<ConditionOfItem> ConditionOfItems { get; set; }
        public DbSet<MaritalStatus> MaritalStatus { get; set; }
        public DbSet<SafetyStock> SafetyStockes { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Celebration> Celebrations { get; set; }


        public DbSet<Unit> Units { get; set; }
        public DbSet<Upazila> Upazilas { get; set; }
        public DbSet<Warranty> Warranties { get; set; }
        public DbSet<Weather> Weathers { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<SubStore> SubStores { get; set; }
        public DbSet<SubSubStore> SubSubStores { get; set; }
        public DbSet<SubSubSubStore> SubSubSubStores { get; set; }
        public DbSet<SubSubSubSubStore> SubSubSubSubStores { get; set; }
        public DbSet<SupplierCompany> SupplierCompanies { get; set; }
        public DbSet<SubContractCompany> SubContractCompanies { get; set; }
        public DbSet<PhoneProvider> PhoneProviders { get; set; }
        public DbSet<EmailProvider> EmailProviders { get; set; }
        public DbSet<EducationQualification> EducationQualifications { get; set; }
        public DbSet<BloodGroup> BloodGroups { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<ProfessionInformation> ProfessionInformations { get; set; }
        public DbSet<PoliceStation> PoliceStations { get; set; }
        public DbSet<PostOffice> PostOffices { get; set; }
        public DbSet<Profile> Profile { get; set; }
        public DbSet<PressentAddress> PressentAddress { get; set; }
        public DbSet<PermanentAddress> PermanentAddress { get; set; }
        public DbSet<ProfileFamilyDetails> ProfileFamilyDetailes { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemElement> ItemElements { get; set; }
        public DbSet<ProcurementHeader>ProcurementHeaders { get; set; }
        public DbSet<ProcurementDetails> ProcurementDetail { get; set; }


    }
}

namespace Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BloodGroups",
                c => new
                    {
                        BloodGroupId = c.Int(nullable: false, identity: true),
                        BloodGroupName = c.String(),
                    })
                .PrimaryKey(t => t.BloodGroupId);
            
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        BrandId = c.Int(nullable: false, identity: true),
                        BrandName = c.String(),
                        SubSubSubSubCategoryId = c.Int(),
                        SubSubSubCategoryId = c.Int(),
                        SubSubCategoryId = c.Int(),
                        SubCategoryId = c.Int(),
                        CategoryId = c.Int(),
                    })
                .PrimaryKey(t => t.BrandId)
                .ForeignKey("dbo.Categories", t => t.CategoryId)
                .ForeignKey("dbo.SubCategories", t => t.SubCategoryId)
                .ForeignKey("dbo.SubSubCategories", t => t.SubSubCategoryId)
                .ForeignKey("dbo.SubSubSubCategories", t => t.SubSubSubCategoryId)
                .ForeignKey("dbo.SubSubSubSubCategories", t => t.SubSubSubSubCategoryId)
                .Index(t => t.SubSubSubSubCategoryId)
                .Index(t => t.SubSubSubCategoryId)
                .Index(t => t.SubSubCategoryId)
                .Index(t => t.SubCategoryId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.ProcurementDetails",
                c => new
                    {
                        PO_Details_ID = c.Int(nullable: false, identity: true),
                        CurrentDate = c.DateTime(nullable: false),
                        PO_QTD = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PO_Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PO_SubTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PO_HD_ID = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        SubCategoryId = c.Int(),
                        SubSubCategoryId = c.Int(),
                        SubSubSubCategoryId = c.Int(),
                        SubSubSubSubCategoryId = c.Int(),
                        BrandId = c.Int(),
                        ModelId = c.Int(),
                        UnitId = c.Int(),
                    })
                .PrimaryKey(t => t.PO_Details_ID)
                .ForeignKey("dbo.Brands", t => t.BrandId)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Models", t => t.ModelId)
                .ForeignKey("dbo.ProcurementHeaders", t => t.PO_HD_ID, cascadeDelete: true)
                .ForeignKey("dbo.SubCategories", t => t.SubCategoryId)
                .ForeignKey("dbo.SubSubCategories", t => t.SubSubCategoryId)
                .ForeignKey("dbo.SubSubSubCategories", t => t.SubSubSubCategoryId)
                .ForeignKey("dbo.SubSubSubSubCategories", t => t.SubSubSubSubCategoryId)
                .ForeignKey("dbo.Units", t => t.UnitId)
                .Index(t => t.PO_HD_ID)
                .Index(t => t.CategoryId)
                .Index(t => t.SubCategoryId)
                .Index(t => t.SubSubCategoryId)
                .Index(t => t.SubSubSubCategoryId)
                .Index(t => t.SubSubSubSubCategoryId)
                .Index(t => t.BrandId)
                .Index(t => t.ModelId)
                .Index(t => t.UnitId);
            
            CreateTable(
                "dbo.Models",
                c => new
                    {
                        ModelId = c.Int(nullable: false, identity: true),
                        ModelName = c.String(),
                        BrandId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ModelId)
                .ForeignKey("dbo.Brands", t => t.BrandId, cascadeDelete: true)
                .Index(t => t.BrandId);
            
            CreateTable(
                "dbo.ProcurementHeaders",
                c => new
                    {
                        PO_HD_ID = c.Int(nullable: false, identity: true),
                        CurrentDate = c.DateTime(nullable: false),
                        PO_TOTAL_AMT = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PO_DIS_RATE = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PO_DIS_AMT = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PO_Tax_Rate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PO_Tax_AMT = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PO_GRAND_TOTAL = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProcurementTypeId = c.Int(nullable: false),
                        SupplierCompanyId = c.Int(nullable: false),
                        MobileNumber = c.Int(nullable: false),
                        SupplierCompanyAddress = c.String(),
                        SupplierInvoiceNo = c.Int(nullable: false),
                        StoreId = c.Int(nullable: false),
                        SubStoreId = c.Int(),
                        SubSubStoreId = c.Int(),
                        SubSubSubStoreId = c.Int(),
                        SubSubSubSubStoreId = c.Int(),
                        CreateBy = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateBy = c.Int(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PO_HD_ID)
                .ForeignKey("dbo.ProcurementTypes", t => t.ProcurementTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Stores", t => t.StoreId, cascadeDelete: true)
                .ForeignKey("dbo.SubStores", t => t.SubStoreId)
                .ForeignKey("dbo.SubSubStores", t => t.SubSubStoreId)
                .ForeignKey("dbo.SubSubSubStores", t => t.SubSubSubStoreId)
                .ForeignKey("dbo.SubSubSubSubStores", t => t.SubSubSubSubStoreId)
                .ForeignKey("dbo.SupplierCompanies", t => t.SupplierCompanyId, cascadeDelete: true)
                .Index(t => t.ProcurementTypeId)
                .Index(t => t.SupplierCompanyId)
                .Index(t => t.StoreId)
                .Index(t => t.SubStoreId)
                .Index(t => t.SubSubStoreId)
                .Index(t => t.SubSubSubStoreId)
                .Index(t => t.SubSubSubSubStoreId);
            
            CreateTable(
                "dbo.ProcurementTypes",
                c => new
                    {
                        ProcurementTypeId = c.Int(nullable: false, identity: true),
                        ProcurementTypeName = c.String(),
                    })
                .PrimaryKey(t => t.ProcurementTypeId);
            
            CreateTable(
                "dbo.Stores",
                c => new
                    {
                        StoreId = c.Int(nullable: false, identity: true),
                        StoreName = c.String(),
                    })
                .PrimaryKey(t => t.StoreId);
            
            CreateTable(
                "dbo.SubStores",
                c => new
                    {
                        SubStoreId = c.Int(nullable: false, identity: true),
                        SubStoreName = c.String(),
                        StoreId = c.Int(),
                    })
                .PrimaryKey(t => t.SubStoreId)
                .ForeignKey("dbo.Stores", t => t.StoreId)
                .Index(t => t.StoreId);
            
            CreateTable(
                "dbo.SubSubStores",
                c => new
                    {
                        SubSubStoreId = c.Int(nullable: false, identity: true),
                        SubSubStoreName = c.String(),
                        StoreId = c.Int(),
                        SubStoreId = c.Int(),
                    })
                .PrimaryKey(t => t.SubSubStoreId)
                .ForeignKey("dbo.Stores", t => t.StoreId)
                .ForeignKey("dbo.SubStores", t => t.SubStoreId)
                .Index(t => t.StoreId)
                .Index(t => t.SubStoreId);
            
            CreateTable(
                "dbo.SubSubSubStores",
                c => new
                    {
                        SubSubSubStoreId = c.Int(nullable: false, identity: true),
                        SubSubSubStoreName = c.String(),
                        StoreId = c.Int(),
                        SubStoreId = c.Int(),
                        SubSubStoreId = c.Int(),
                    })
                .PrimaryKey(t => t.SubSubSubStoreId)
                .ForeignKey("dbo.Stores", t => t.StoreId)
                .ForeignKey("dbo.SubStores", t => t.SubStoreId)
                .ForeignKey("dbo.SubSubStores", t => t.SubSubStoreId)
                .Index(t => t.StoreId)
                .Index(t => t.SubStoreId)
                .Index(t => t.SubSubStoreId);
            
            CreateTable(
                "dbo.SubSubSubSubStores",
                c => new
                    {
                        SubSubSubSubStoreId = c.Int(nullable: false, identity: true),
                        SubSubSubSubStoreName = c.String(),
                        StoreId = c.Int(),
                        SubStoreId = c.Int(),
                        SubSubStoreId = c.Int(),
                        SubSubSubStoreId = c.Int(),
                    })
                .PrimaryKey(t => t.SubSubSubSubStoreId)
                .ForeignKey("dbo.Stores", t => t.StoreId)
                .ForeignKey("dbo.SubStores", t => t.SubStoreId)
                .ForeignKey("dbo.SubSubStores", t => t.SubSubStoreId)
                .ForeignKey("dbo.SubSubSubStores", t => t.SubSubSubStoreId)
                .Index(t => t.StoreId)
                .Index(t => t.SubStoreId)
                .Index(t => t.SubSubStoreId)
                .Index(t => t.SubSubSubStoreId);
            
            CreateTable(
                "dbo.SupplierCompanies",
                c => new
                    {
                        SupplierCompanyId = c.Int(nullable: false, identity: true),
                        SupplierCompanyName = c.String(),
                        MobileNumber = c.Int(nullable: false),
                        SupplierCompanyAddress = c.String(),
                        SupplierInvoiceNo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SupplierCompanyId);
            
            CreateTable(
                "dbo.SubCategories",
                c => new
                    {
                        SubCategoryId = c.Int(nullable: false, identity: true),
                        SubCategoryName = c.String(),
                        CategoryId = c.Int(),
                    })
                .PrimaryKey(t => t.SubCategoryId)
                .ForeignKey("dbo.Categories", t => t.CategoryId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.SubSubCategories",
                c => new
                    {
                        SubSubCategoryId = c.Int(nullable: false, identity: true),
                        SubSubCategoryName = c.String(),
                        SubCategoryId = c.Int(),
                        CategoryId = c.Int(),
                    })
                .PrimaryKey(t => t.SubSubCategoryId)
                .ForeignKey("dbo.Categories", t => t.CategoryId)
                .ForeignKey("dbo.SubCategories", t => t.SubCategoryId)
                .Index(t => t.SubCategoryId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.SubSubSubCategories",
                c => new
                    {
                        SubSubSubCategoryId = c.Int(nullable: false, identity: true),
                        SubSubSubCategoryName = c.String(),
                        SubSubCategoryId = c.Int(),
                        SubCategoryId = c.Int(),
                        CategoryId = c.Int(),
                    })
                .PrimaryKey(t => t.SubSubSubCategoryId)
                .ForeignKey("dbo.Categories", t => t.CategoryId)
                .ForeignKey("dbo.SubCategories", t => t.SubCategoryId)
                .ForeignKey("dbo.SubSubCategories", t => t.SubSubCategoryId)
                .Index(t => t.SubSubCategoryId)
                .Index(t => t.SubCategoryId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.SubSubSubSubCategories",
                c => new
                    {
                        SubSubSubSubCategoryId = c.Int(nullable: false, identity: true),
                        SubSubSubSubCategoryName = c.String(),
                        SubSubSubCategoryId = c.Int(),
                        SubSubCategoryId = c.Int(),
                        SubCategoryId = c.Int(),
                        CategoryId = c.Int(),
                    })
                .PrimaryKey(t => t.SubSubSubSubCategoryId)
                .ForeignKey("dbo.Categories", t => t.CategoryId)
                .ForeignKey("dbo.SubCategories", t => t.SubCategoryId)
                .ForeignKey("dbo.SubSubCategories", t => t.SubSubCategoryId)
                .ForeignKey("dbo.SubSubSubCategories", t => t.SubSubSubCategoryId)
                .Index(t => t.SubSubSubCategoryId)
                .Index(t => t.SubSubCategoryId)
                .Index(t => t.SubCategoryId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        UnitId = c.Int(nullable: false, identity: true),
                        UnitName = c.String(),
                    })
                .PrimaryKey(t => t.UnitId);
            
            CreateTable(
                "dbo.Celebrations",
                c => new
                    {
                        CelebrationId = c.Int(nullable: false, identity: true),
                        CelebrationName = c.String(),
                        CelebrationType = c.String(),
                    })
                .PrimaryKey(t => t.CelebrationId);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        CompanyId = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                    })
                .PrimaryKey(t => t.CompanyId);
            
            CreateTable(
                "dbo.ConditionOfItems",
                c => new
                    {
                        ConditionOfItemId = c.Int(nullable: false, identity: true),
                        ConditionOfItemName = c.String(),
                    })
                .PrimaryKey(t => t.ConditionOfItemId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        CountryId = c.Int(nullable: false, identity: true),
                        CountryName = c.String(),
                    })
                .PrimaryKey(t => t.CountryId);
            
            CreateTable(
                "dbo.PermanentAddresses",
                c => new
                    {
                        ProfileId = c.Int(nullable: false, identity: true),
                        PermanentAddressFull = c.String(),
                        PerPoliceStationId = c.Int(),
                        PerPostOfficeId = c.Int(),
                        PerDistrictId = c.Int(),
                        PerDivisionId = c.Int(),
                        PerCountryId = c.Int(),
                        Country_CountryId = c.Int(),
                        District_DistrictId = c.Int(),
                        PoliceStation_PoliceStationId = c.Int(),
                        Division_DivisionId = c.Int(),
                        PostOffice_PostOfficeId = c.Int(),
                    })
                .PrimaryKey(t => t.ProfileId)
                .ForeignKey("dbo.Countries", t => t.Country_CountryId)
                .ForeignKey("dbo.Districts", t => t.District_DistrictId)
                .ForeignKey("dbo.PoliceStations", t => t.PoliceStation_PoliceStationId)
                .ForeignKey("dbo.Divisions", t => t.Division_DivisionId)
                .ForeignKey("dbo.PostOffices", t => t.PostOffice_PostOfficeId)
                .Index(t => t.Country_CountryId)
                .Index(t => t.District_DistrictId)
                .Index(t => t.PoliceStation_PoliceStationId)
                .Index(t => t.Division_DivisionId)
                .Index(t => t.PostOffice_PostOfficeId);
            
            CreateTable(
                "dbo.Districts",
                c => new
                    {
                        DistrictId = c.Int(nullable: false, identity: true),
                        DistrictName = c.String(),
                    })
                .PrimaryKey(t => t.DistrictId);
            
            CreateTable(
                "dbo.PoliceStations",
                c => new
                    {
                        PoliceStationId = c.Int(nullable: false, identity: true),
                        PoliceStationName = c.String(),
                        DistrictId = c.Int(),
                    })
                .PrimaryKey(t => t.PoliceStationId)
                .ForeignKey("dbo.Districts", t => t.DistrictId)
                .Index(t => t.DistrictId);
            
            CreateTable(
                "dbo.PressentAddresses",
                c => new
                    {
                        ProfileId = c.Int(nullable: false, identity: true),
                        PresentAddressFull = c.String(),
                        PrePoliceStationId = c.Int(),
                        PrePostOfficeId = c.Int(),
                        PreDistrictId = c.Int(),
                        PreDivisionId = c.Int(),
                        PreCountryId = c.Int(),
                        Country_CountryId = c.Int(),
                        District_DistrictId = c.Int(),
                        Division_DivisionId = c.Int(),
                        PoliceStation_PoliceStationId = c.Int(),
                        PostOffice_PostOfficeId = c.Int(),
                    })
                .PrimaryKey(t => t.ProfileId)
                .ForeignKey("dbo.Countries", t => t.Country_CountryId)
                .ForeignKey("dbo.Districts", t => t.District_DistrictId)
                .ForeignKey("dbo.Divisions", t => t.Division_DivisionId)
                .ForeignKey("dbo.PoliceStations", t => t.PoliceStation_PoliceStationId)
                .ForeignKey("dbo.PostOffices", t => t.PostOffice_PostOfficeId)
                .Index(t => t.Country_CountryId)
                .Index(t => t.District_DistrictId)
                .Index(t => t.Division_DivisionId)
                .Index(t => t.PoliceStation_PoliceStationId)
                .Index(t => t.PostOffice_PostOfficeId);
            
            CreateTable(
                "dbo.Divisions",
                c => new
                    {
                        DivisionId = c.Int(nullable: false, identity: true),
                        DivisionName = c.String(),
                    })
                .PrimaryKey(t => t.DivisionId);
            
            CreateTable(
                "dbo.PostOffices",
                c => new
                    {
                        PostOfficeId = c.Int(nullable: false, identity: true),
                        PostOfficeName = c.String(),
                        DistrictId = c.Int(),
                    })
                .PrimaryKey(t => t.PostOfficeId)
                .ForeignKey("dbo.Districts", t => t.DistrictId)
                .Index(t => t.DistrictId);
            
            CreateTable(
                "dbo.Profiles",
                c => new
                    {
                        ProfileId = c.Int(nullable: false, identity: true),
                        ProfileName = c.String(),
                        FatherName = c.String(),
                        MotherName = c.String(),
                        DateofBirth = c.DateTime(nullable: false),
                        BirthPlace = c.String(),
                        Genderid = c.Int(),
                        BloodGroupId = c.Int(),
                        NationalityID = c.Int(),
                        MaritalStatusId = c.Int(),
                        DateofMarriage = c.DateTime(nullable: false),
                        RegionId = c.Int(),
                        NID = c.Int(),
                        TIN = c.Int(),
                        SpouseName = c.String(),
                        SpouseProfession = c.String(),
                        MailAddress = c.String(),
                        ContactNumber = c.Int(nullable: false),
                        EmergencyContactNumber = c.Int(nullable: false),
                        PassportNumber = c.String(),
                        DrivingLicenceNumber = c.String(),
                        Hobby = c.String(),
                        CreateBy = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateBy = c.String(),
                        UpdateDate = c.DateTime(nullable: false),
                        ImagePath = c.String(),
                        District_DistrictId = c.Int(),
                        PermanentAddress_ProfileId = c.Int(),
                        PressentAddress_ProfileId = c.Int(),
                    })
                .PrimaryKey(t => t.ProfileId)
                .ForeignKey("dbo.BloodGroups", t => t.BloodGroupId)
                .ForeignKey("dbo.Districts", t => t.District_DistrictId)
                .ForeignKey("dbo.Genders", t => t.Genderid)
                .ForeignKey("dbo.MaritalStatus", t => t.MaritalStatusId)
                .ForeignKey("dbo.Nationalities", t => t.NationalityID)
                .ForeignKey("dbo.PermanentAddresses", t => t.PermanentAddress_ProfileId)
                .ForeignKey("dbo.PressentAddresses", t => t.PressentAddress_ProfileId)
                .ForeignKey("dbo.Regions", t => t.RegionId)
                .Index(t => t.Genderid)
                .Index(t => t.BloodGroupId)
                .Index(t => t.NationalityID)
                .Index(t => t.MaritalStatusId)
                .Index(t => t.RegionId)
                .Index(t => t.District_DistrictId)
                .Index(t => t.PermanentAddress_ProfileId)
                .Index(t => t.PressentAddress_ProfileId);
            
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        GenderID = c.Int(nullable: false, identity: true),
                        GenderName = c.String(),
                    })
                .PrimaryKey(t => t.GenderID);
            
            CreateTable(
                "dbo.MaritalStatus",
                c => new
                    {
                        MaritalStatusId = c.Int(nullable: false, identity: true),
                        MaritalStatusName = c.String(),
                    })
                .PrimaryKey(t => t.MaritalStatusId);
            
            CreateTable(
                "dbo.Nationalities",
                c => new
                    {
                        NationalityID = c.Int(nullable: false, identity: true),
                        NationalityName = c.String(),
                    })
                .PrimaryKey(t => t.NationalityID);
            
            CreateTable(
                "dbo.ProfileFamilyDetails",
                c => new
                    {
                        ProfileDetailsId = c.Int(nullable: false, identity: true),
                        ProfileId = c.Int(nullable: false),
                        SpouseName = c.String(),
                        SpouseDOB = c.DateTime(nullable: false),
                        SpouseProfession = c.String(),
                        SpouseGenderId = c.Int(nullable: false),
                        SlNoOfMarriage = c.Int(nullable: false),
                        ChildName = c.String(),
                        ChildDOB = c.DateTime(nullable: false),
                        ChildProfession = c.String(),
                        GenderID = c.Int(),
                        SlNoOfChild = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProfileDetailsId)
                .ForeignKey("dbo.Genders", t => t.GenderID)
                .ForeignKey("dbo.Profiles", t => t.ProfileId, cascadeDelete: true)
                .Index(t => t.ProfileId)
                .Index(t => t.GenderID);
            
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        RegionId = c.Int(nullable: false, identity: true),
                        RegionName = c.String(),
                    })
                .PrimaryKey(t => t.RegionId);
            
            CreateTable(
                "dbo.Principles",
                c => new
                    {
                        Principle_id = c.Int(nullable: false, identity: true),
                        Principle_name = c.String(),
                        CountryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Principle_id)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        ProvinceID = c.Int(nullable: false, identity: true),
                        ProvinceName = c.String(),
                        CountryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProvinceID)
                .ForeignKey("dbo.Countries", t => t.CountryID, cascadeDelete: true)
                .Index(t => t.CountryID);
            
            CreateTable(
                "dbo.State",
                c => new
                    {
                        StateID = c.Int(nullable: false, identity: true),
                        StateName = c.String(),
                        CountryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StateID)
                .ForeignKey("dbo.Countries", t => t.CountryID, cascadeDelete: true)
                .Index(t => t.CountryID);
            
            CreateTable(
                "dbo.EducationQualifications",
                c => new
                    {
                        EducationQualificationId = c.Int(nullable: false, identity: true),
                        EducationQualificationName = c.String(),
                    })
                .PrimaryKey(t => t.EducationQualificationId);
            
            CreateTable(
                "dbo.EmailProviders",
                c => new
                    {
                        EmailProviderId = c.Int(nullable: false, identity: true),
                        EmailProviderName = c.String(),
                    })
                .PrimaryKey(t => t.EmailProviderId);
            
            CreateTable(
                "dbo.Festivals",
                c => new
                    {
                        FestivalId = c.Int(nullable: false, identity: true),
                        FestivalName = c.String(),
                        ReligionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FestivalId)
                .ForeignKey("dbo.Religions", t => t.ReligionId, cascadeDelete: true)
                .Index(t => t.ReligionId);
            
            CreateTable(
                "dbo.Religions",
                c => new
                    {
                        ReligionId = c.Int(nullable: false, identity: true),
                        ReligionName = c.String(),
                    })
                .PrimaryKey(t => t.ReligionId);
            
            CreateTable(
                "dbo.Hobbies",
                c => new
                    {
                        HobbyId = c.Int(nullable: false, identity: true),
                        HobbyName = c.String(),
                    })
                .PrimaryKey(t => t.HobbyId);
            
            CreateTable(
                "dbo.ItemElements",
                c => new
                    {
                        ItemElementId = c.Int(nullable: false, identity: true),
                        ItemElementName = c.String(),
                        CategoryId = c.Int(nullable: false),
                        SubCategoryId = c.Int(),
                        SubSubCategoryId = c.Int(),
                        SubSubSubCategoryId = c.Int(),
                        SubSubSubSubCategoryId = c.Int(),
                    })
                .PrimaryKey(t => t.ItemElementId)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.SubCategories", t => t.SubCategoryId)
                .ForeignKey("dbo.SubSubCategories", t => t.SubSubCategoryId)
                .ForeignKey("dbo.SubSubSubCategories", t => t.SubSubSubCategoryId)
                .ForeignKey("dbo.SubSubSubSubCategories", t => t.SubSubSubSubCategoryId)
                .Index(t => t.CategoryId)
                .Index(t => t.SubCategoryId)
                .Index(t => t.SubSubCategoryId)
                .Index(t => t.SubSubSubCategoryId)
                .Index(t => t.SubSubSubSubCategoryId);
            
            CreateTable(
                "dbo.RawMaterials",
                c => new
                    {
                        RawMaterialId = c.Int(nullable: false, identity: true),
                        ItemId = c.Int(),
                        ItemElementId = c.Int(),
                    })
                .PrimaryKey(t => t.RawMaterialId)
                .ForeignKey("dbo.Items", t => t.ItemId)
                .ForeignKey("dbo.ItemElements", t => t.ItemElementId)
                .Index(t => t.ItemId)
                .Index(t => t.ItemElementId);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ItemId = c.Int(nullable: false, identity: true),
                        ItemName = c.String(),
                        CategoryId = c.Int(nullable: false),
                        SubCategoryId = c.Int(),
                        SubSubCategoryId = c.Int(),
                        SubSubSubCategoryId = c.Int(),
                        SubSubSubSubCategoryId = c.Int(),
                        UnitId = c.Int(nullable: false),
                        Height = c.Int(),
                        Width = c.Int(),
                        Weight = c.Int(),
                        Product_Image = c.String(),
                    })
                .PrimaryKey(t => t.ItemId)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.SubCategories", t => t.SubCategoryId)
                .ForeignKey("dbo.SubSubCategories", t => t.SubSubCategoryId)
                .ForeignKey("dbo.SubSubSubCategories", t => t.SubSubSubCategoryId)
                .ForeignKey("dbo.SubSubSubSubCategories", t => t.SubSubSubSubCategoryId)
                .ForeignKey("dbo.Units", t => t.UnitId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.SubCategoryId)
                .Index(t => t.SubSubCategoryId)
                .Index(t => t.SubSubSubCategoryId)
                .Index(t => t.SubSubSubSubCategoryId)
                .Index(t => t.UnitId);
            
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        LanguageId = c.Int(nullable: false, identity: true),
                        LanguageName = c.String(),
                    })
                .PrimaryKey(t => t.LanguageId);
            
            CreateTable(
                "dbo.PhoneProviders",
                c => new
                    {
                        PhoneProviderId = c.Int(nullable: false, identity: true),
                        PhoneProviderName = c.String(),
                    })
                .PrimaryKey(t => t.PhoneProviderId);
            
            CreateTable(
                "dbo.ProfessionInformations",
                c => new
                    {
                        ProfessionId = c.Int(nullable: false, identity: true),
                        ProfessionName = c.String(),
                    })
                .PrimaryKey(t => t.ProfessionId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.RoleId);
            
            CreateTable(
                "dbo.SafetyStocks",
                c => new
                    {
                        SafetyStockLimitId = c.Int(nullable: false, identity: true),
                        ItemOrProductId = c.Int(nullable: false),
                        SafetyStokLimit = c.Int(nullable: false),
                        UnitId = c.String(),
                    })
                .PrimaryKey(t => t.SafetyStockLimitId);
            
            CreateTable(
                "dbo.Seasons",
                c => new
                    {
                        SeasonId = c.Int(nullable: false, identity: true),
                        SeasonName = c.String(),
                    })
                .PrimaryKey(t => t.SeasonId);
            
            CreateTable(
                "dbo.SubContractCompanies",
                c => new
                    {
                        SubContractCompanyId = c.Int(nullable: false, identity: true),
                        SubContractCompanyName = c.String(),
                    })
                .PrimaryKey(t => t.SubContractCompanyId);
            
            CreateTable(
                "dbo.Upazilas",
                c => new
                    {
                        UpazilaId = c.Int(nullable: false, identity: true),
                        UpazilaName = c.String(),
                    })
                .PrimaryKey(t => t.UpazilaId);
            
            CreateTable(
                "dbo.Warranties",
                c => new
                    {
                        WarrantyId = c.Int(nullable: false, identity: true),
                        WarrantyName = c.String(),
                    })
                .PrimaryKey(t => t.WarrantyId);
            
            CreateTable(
                "dbo.Weathers",
                c => new
                    {
                        WeatherId = c.Int(nullable: false, identity: true),
                        WeatherName = c.String(),
                    })
                .PrimaryKey(t => t.WeatherId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemElements", "SubSubSubSubCategoryId", "dbo.SubSubSubSubCategories");
            DropForeignKey("dbo.ItemElements", "SubSubSubCategoryId", "dbo.SubSubSubCategories");
            DropForeignKey("dbo.ItemElements", "SubSubCategoryId", "dbo.SubSubCategories");
            DropForeignKey("dbo.ItemElements", "SubCategoryId", "dbo.SubCategories");
            DropForeignKey("dbo.RawMaterials", "ItemElementId", "dbo.ItemElements");
            DropForeignKey("dbo.Items", "UnitId", "dbo.Units");
            DropForeignKey("dbo.Items", "SubSubSubSubCategoryId", "dbo.SubSubSubSubCategories");
            DropForeignKey("dbo.Items", "SubSubSubCategoryId", "dbo.SubSubSubCategories");
            DropForeignKey("dbo.Items", "SubSubCategoryId", "dbo.SubSubCategories");
            DropForeignKey("dbo.Items", "SubCategoryId", "dbo.SubCategories");
            DropForeignKey("dbo.RawMaterials", "ItemId", "dbo.Items");
            DropForeignKey("dbo.Items", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.ItemElements", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Festivals", "ReligionId", "dbo.Religions");
            DropForeignKey("dbo.State", "CountryID", "dbo.Countries");
            DropForeignKey("dbo.Provinces", "CountryID", "dbo.Countries");
            DropForeignKey("dbo.Principles", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Profiles", "RegionId", "dbo.Regions");
            DropForeignKey("dbo.ProfileFamilyDetails", "ProfileId", "dbo.Profiles");
            DropForeignKey("dbo.ProfileFamilyDetails", "GenderID", "dbo.Genders");
            DropForeignKey("dbo.Profiles", "PressentAddress_ProfileId", "dbo.PressentAddresses");
            DropForeignKey("dbo.Profiles", "PermanentAddress_ProfileId", "dbo.PermanentAddresses");
            DropForeignKey("dbo.Profiles", "NationalityID", "dbo.Nationalities");
            DropForeignKey("dbo.Profiles", "MaritalStatusId", "dbo.MaritalStatus");
            DropForeignKey("dbo.Profiles", "Genderid", "dbo.Genders");
            DropForeignKey("dbo.Profiles", "District_DistrictId", "dbo.Districts");
            DropForeignKey("dbo.Profiles", "BloodGroupId", "dbo.BloodGroups");
            DropForeignKey("dbo.PressentAddresses", "PostOffice_PostOfficeId", "dbo.PostOffices");
            DropForeignKey("dbo.PermanentAddresses", "PostOffice_PostOfficeId", "dbo.PostOffices");
            DropForeignKey("dbo.PostOffices", "DistrictId", "dbo.Districts");
            DropForeignKey("dbo.PressentAddresses", "PoliceStation_PoliceStationId", "dbo.PoliceStations");
            DropForeignKey("dbo.PressentAddresses", "Division_DivisionId", "dbo.Divisions");
            DropForeignKey("dbo.PermanentAddresses", "Division_DivisionId", "dbo.Divisions");
            DropForeignKey("dbo.PressentAddresses", "District_DistrictId", "dbo.Districts");
            DropForeignKey("dbo.PressentAddresses", "Country_CountryId", "dbo.Countries");
            DropForeignKey("dbo.PermanentAddresses", "PoliceStation_PoliceStationId", "dbo.PoliceStations");
            DropForeignKey("dbo.PoliceStations", "DistrictId", "dbo.Districts");
            DropForeignKey("dbo.PermanentAddresses", "District_DistrictId", "dbo.Districts");
            DropForeignKey("dbo.PermanentAddresses", "Country_CountryId", "dbo.Countries");
            DropForeignKey("dbo.ProcurementDetails", "UnitId", "dbo.Units");
            DropForeignKey("dbo.SubSubSubSubCategories", "SubSubSubCategoryId", "dbo.SubSubSubCategories");
            DropForeignKey("dbo.SubSubSubSubCategories", "SubSubCategoryId", "dbo.SubSubCategories");
            DropForeignKey("dbo.SubSubSubSubCategories", "SubCategoryId", "dbo.SubCategories");
            DropForeignKey("dbo.ProcurementDetails", "SubSubSubSubCategoryId", "dbo.SubSubSubSubCategories");
            DropForeignKey("dbo.SubSubSubSubCategories", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Brands", "SubSubSubSubCategoryId", "dbo.SubSubSubSubCategories");
            DropForeignKey("dbo.SubSubSubCategories", "SubSubCategoryId", "dbo.SubSubCategories");
            DropForeignKey("dbo.SubSubSubCategories", "SubCategoryId", "dbo.SubCategories");
            DropForeignKey("dbo.ProcurementDetails", "SubSubSubCategoryId", "dbo.SubSubSubCategories");
            DropForeignKey("dbo.SubSubSubCategories", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Brands", "SubSubSubCategoryId", "dbo.SubSubSubCategories");
            DropForeignKey("dbo.SubSubCategories", "SubCategoryId", "dbo.SubCategories");
            DropForeignKey("dbo.ProcurementDetails", "SubSubCategoryId", "dbo.SubSubCategories");
            DropForeignKey("dbo.SubSubCategories", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Brands", "SubSubCategoryId", "dbo.SubSubCategories");
            DropForeignKey("dbo.ProcurementDetails", "SubCategoryId", "dbo.SubCategories");
            DropForeignKey("dbo.SubCategories", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Brands", "SubCategoryId", "dbo.SubCategories");
            DropForeignKey("dbo.ProcurementHeaders", "SupplierCompanyId", "dbo.SupplierCompanies");
            DropForeignKey("dbo.SubSubSubSubStores", "SubSubSubStoreId", "dbo.SubSubSubStores");
            DropForeignKey("dbo.SubSubSubSubStores", "SubSubStoreId", "dbo.SubSubStores");
            DropForeignKey("dbo.SubSubSubSubStores", "SubStoreId", "dbo.SubStores");
            DropForeignKey("dbo.SubSubSubSubStores", "StoreId", "dbo.Stores");
            DropForeignKey("dbo.ProcurementHeaders", "SubSubSubSubStoreId", "dbo.SubSubSubSubStores");
            DropForeignKey("dbo.SubSubSubStores", "SubSubStoreId", "dbo.SubSubStores");
            DropForeignKey("dbo.SubSubSubStores", "SubStoreId", "dbo.SubStores");
            DropForeignKey("dbo.SubSubSubStores", "StoreId", "dbo.Stores");
            DropForeignKey("dbo.ProcurementHeaders", "SubSubSubStoreId", "dbo.SubSubSubStores");
            DropForeignKey("dbo.SubSubStores", "SubStoreId", "dbo.SubStores");
            DropForeignKey("dbo.SubSubStores", "StoreId", "dbo.Stores");
            DropForeignKey("dbo.ProcurementHeaders", "SubSubStoreId", "dbo.SubSubStores");
            DropForeignKey("dbo.SubStores", "StoreId", "dbo.Stores");
            DropForeignKey("dbo.ProcurementHeaders", "SubStoreId", "dbo.SubStores");
            DropForeignKey("dbo.ProcurementHeaders", "StoreId", "dbo.Stores");
            DropForeignKey("dbo.ProcurementHeaders", "ProcurementTypeId", "dbo.ProcurementTypes");
            DropForeignKey("dbo.ProcurementDetails", "PO_HD_ID", "dbo.ProcurementHeaders");
            DropForeignKey("dbo.ProcurementDetails", "ModelId", "dbo.Models");
            DropForeignKey("dbo.Models", "BrandId", "dbo.Brands");
            DropForeignKey("dbo.ProcurementDetails", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.ProcurementDetails", "BrandId", "dbo.Brands");
            DropForeignKey("dbo.Brands", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Items", new[] { "UnitId" });
            DropIndex("dbo.Items", new[] { "SubSubSubSubCategoryId" });
            DropIndex("dbo.Items", new[] { "SubSubSubCategoryId" });
            DropIndex("dbo.Items", new[] { "SubSubCategoryId" });
            DropIndex("dbo.Items", new[] { "SubCategoryId" });
            DropIndex("dbo.Items", new[] { "CategoryId" });
            DropIndex("dbo.RawMaterials", new[] { "ItemElementId" });
            DropIndex("dbo.RawMaterials", new[] { "ItemId" });
            DropIndex("dbo.ItemElements", new[] { "SubSubSubSubCategoryId" });
            DropIndex("dbo.ItemElements", new[] { "SubSubSubCategoryId" });
            DropIndex("dbo.ItemElements", new[] { "SubSubCategoryId" });
            DropIndex("dbo.ItemElements", new[] { "SubCategoryId" });
            DropIndex("dbo.ItemElements", new[] { "CategoryId" });
            DropIndex("dbo.Festivals", new[] { "ReligionId" });
            DropIndex("dbo.State", new[] { "CountryID" });
            DropIndex("dbo.Provinces", new[] { "CountryID" });
            DropIndex("dbo.Principles", new[] { "CountryId" });
            DropIndex("dbo.ProfileFamilyDetails", new[] { "GenderID" });
            DropIndex("dbo.ProfileFamilyDetails", new[] { "ProfileId" });
            DropIndex("dbo.Profiles", new[] { "PressentAddress_ProfileId" });
            DropIndex("dbo.Profiles", new[] { "PermanentAddress_ProfileId" });
            DropIndex("dbo.Profiles", new[] { "District_DistrictId" });
            DropIndex("dbo.Profiles", new[] { "RegionId" });
            DropIndex("dbo.Profiles", new[] { "MaritalStatusId" });
            DropIndex("dbo.Profiles", new[] { "NationalityID" });
            DropIndex("dbo.Profiles", new[] { "BloodGroupId" });
            DropIndex("dbo.Profiles", new[] { "Genderid" });
            DropIndex("dbo.PostOffices", new[] { "DistrictId" });
            DropIndex("dbo.PressentAddresses", new[] { "PostOffice_PostOfficeId" });
            DropIndex("dbo.PressentAddresses", new[] { "PoliceStation_PoliceStationId" });
            DropIndex("dbo.PressentAddresses", new[] { "Division_DivisionId" });
            DropIndex("dbo.PressentAddresses", new[] { "District_DistrictId" });
            DropIndex("dbo.PressentAddresses", new[] { "Country_CountryId" });
            DropIndex("dbo.PoliceStations", new[] { "DistrictId" });
            DropIndex("dbo.PermanentAddresses", new[] { "PostOffice_PostOfficeId" });
            DropIndex("dbo.PermanentAddresses", new[] { "Division_DivisionId" });
            DropIndex("dbo.PermanentAddresses", new[] { "PoliceStation_PoliceStationId" });
            DropIndex("dbo.PermanentAddresses", new[] { "District_DistrictId" });
            DropIndex("dbo.PermanentAddresses", new[] { "Country_CountryId" });
            DropIndex("dbo.SubSubSubSubCategories", new[] { "CategoryId" });
            DropIndex("dbo.SubSubSubSubCategories", new[] { "SubCategoryId" });
            DropIndex("dbo.SubSubSubSubCategories", new[] { "SubSubCategoryId" });
            DropIndex("dbo.SubSubSubSubCategories", new[] { "SubSubSubCategoryId" });
            DropIndex("dbo.SubSubSubCategories", new[] { "CategoryId" });
            DropIndex("dbo.SubSubSubCategories", new[] { "SubCategoryId" });
            DropIndex("dbo.SubSubSubCategories", new[] { "SubSubCategoryId" });
            DropIndex("dbo.SubSubCategories", new[] { "CategoryId" });
            DropIndex("dbo.SubSubCategories", new[] { "SubCategoryId" });
            DropIndex("dbo.SubCategories", new[] { "CategoryId" });
            DropIndex("dbo.SubSubSubSubStores", new[] { "SubSubSubStoreId" });
            DropIndex("dbo.SubSubSubSubStores", new[] { "SubSubStoreId" });
            DropIndex("dbo.SubSubSubSubStores", new[] { "SubStoreId" });
            DropIndex("dbo.SubSubSubSubStores", new[] { "StoreId" });
            DropIndex("dbo.SubSubSubStores", new[] { "SubSubStoreId" });
            DropIndex("dbo.SubSubSubStores", new[] { "SubStoreId" });
            DropIndex("dbo.SubSubSubStores", new[] { "StoreId" });
            DropIndex("dbo.SubSubStores", new[] { "SubStoreId" });
            DropIndex("dbo.SubSubStores", new[] { "StoreId" });
            DropIndex("dbo.SubStores", new[] { "StoreId" });
            DropIndex("dbo.ProcurementHeaders", new[] { "SubSubSubSubStoreId" });
            DropIndex("dbo.ProcurementHeaders", new[] { "SubSubSubStoreId" });
            DropIndex("dbo.ProcurementHeaders", new[] { "SubSubStoreId" });
            DropIndex("dbo.ProcurementHeaders", new[] { "SubStoreId" });
            DropIndex("dbo.ProcurementHeaders", new[] { "StoreId" });
            DropIndex("dbo.ProcurementHeaders", new[] { "SupplierCompanyId" });
            DropIndex("dbo.ProcurementHeaders", new[] { "ProcurementTypeId" });
            DropIndex("dbo.Models", new[] { "BrandId" });
            DropIndex("dbo.ProcurementDetails", new[] { "UnitId" });
            DropIndex("dbo.ProcurementDetails", new[] { "ModelId" });
            DropIndex("dbo.ProcurementDetails", new[] { "BrandId" });
            DropIndex("dbo.ProcurementDetails", new[] { "SubSubSubSubCategoryId" });
            DropIndex("dbo.ProcurementDetails", new[] { "SubSubSubCategoryId" });
            DropIndex("dbo.ProcurementDetails", new[] { "SubSubCategoryId" });
            DropIndex("dbo.ProcurementDetails", new[] { "SubCategoryId" });
            DropIndex("dbo.ProcurementDetails", new[] { "CategoryId" });
            DropIndex("dbo.ProcurementDetails", new[] { "PO_HD_ID" });
            DropIndex("dbo.Brands", new[] { "CategoryId" });
            DropIndex("dbo.Brands", new[] { "SubCategoryId" });
            DropIndex("dbo.Brands", new[] { "SubSubCategoryId" });
            DropIndex("dbo.Brands", new[] { "SubSubSubCategoryId" });
            DropIndex("dbo.Brands", new[] { "SubSubSubSubCategoryId" });
            DropTable("dbo.Weathers");
            DropTable("dbo.Warranties");
            DropTable("dbo.Upazilas");
            DropTable("dbo.SubContractCompanies");
            DropTable("dbo.Seasons");
            DropTable("dbo.SafetyStocks");
            DropTable("dbo.Roles");
            DropTable("dbo.ProfessionInformations");
            DropTable("dbo.PhoneProviders");
            DropTable("dbo.Languages");
            DropTable("dbo.Items");
            DropTable("dbo.RawMaterials");
            DropTable("dbo.ItemElements");
            DropTable("dbo.Hobbies");
            DropTable("dbo.Religions");
            DropTable("dbo.Festivals");
            DropTable("dbo.EmailProviders");
            DropTable("dbo.EducationQualifications");
            DropTable("dbo.State");
            DropTable("dbo.Provinces");
            DropTable("dbo.Principles");
            DropTable("dbo.Regions");
            DropTable("dbo.ProfileFamilyDetails");
            DropTable("dbo.Nationalities");
            DropTable("dbo.MaritalStatus");
            DropTable("dbo.Genders");
            DropTable("dbo.Profiles");
            DropTable("dbo.PostOffices");
            DropTable("dbo.Divisions");
            DropTable("dbo.PressentAddresses");
            DropTable("dbo.PoliceStations");
            DropTable("dbo.Districts");
            DropTable("dbo.PermanentAddresses");
            DropTable("dbo.Countries");
            DropTable("dbo.ConditionOfItems");
            DropTable("dbo.Companies");
            DropTable("dbo.Celebrations");
            DropTable("dbo.Units");
            DropTable("dbo.SubSubSubSubCategories");
            DropTable("dbo.SubSubSubCategories");
            DropTable("dbo.SubSubCategories");
            DropTable("dbo.SubCategories");
            DropTable("dbo.SupplierCompanies");
            DropTable("dbo.SubSubSubSubStores");
            DropTable("dbo.SubSubSubStores");
            DropTable("dbo.SubSubStores");
            DropTable("dbo.SubStores");
            DropTable("dbo.Stores");
            DropTable("dbo.ProcurementTypes");
            DropTable("dbo.ProcurementHeaders");
            DropTable("dbo.Models");
            DropTable("dbo.ProcurementDetails");
            DropTable("dbo.Categories");
            DropTable("dbo.Brands");
            DropTable("dbo.BloodGroups");
        }
    }
}

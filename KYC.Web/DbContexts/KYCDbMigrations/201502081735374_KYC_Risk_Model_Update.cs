namespace KYC.Web.DbContexts.KYCDbMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KYC_Risk_Model_Update : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AgentBanks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Alpha = c.String(maxLength: 50),
                        Name = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.CCF",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustID = c.Int(nullable: false),
                        CCFType = c.String(maxLength: 50),
                        EditDate = c.DateTime(),
                        NextDate = c.DateTime(),
                        EditBy = c.String(maxLength: 50),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CUSTUniversal", t => t.CustID, cascadeDelete: true)
                .Index(t => t.CustID);
            
            CreateTable(
                "dbo.CUSTUniversal",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FullName = c.String(maxLength: 100),
                        AcctOpenDate = c.DateTime(),
                        AcctOpenBy = c.String(maxLength: 50),
                        Owner = c.String(maxLength: 50),
                        EditDate = c.DateTime(),
                        EditBy = c.String(maxLength: 50),
                        KYCStatus = c.String(maxLength: 50),
                        CreditStatus = c.String(maxLength: 50),
                        CustStatus = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.CUST",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        OFAC = c.Boolean(),
                        BPRole = c.String(maxLength: 100),
                        ZISLegalForm = c.String(maxLength: 100),
                        CountryCode = c.String(maxLength: 100),
                        UltCountryCode = c.String(maxLength: 100),
                        SpecType = c.String(maxLength: 50),
                        LegalEntity = c.String(maxLength: 50),
                        ContractPartner = c.String(maxLength: 2),
                        RiskSector = c.String(maxLength: 50),
                        SectorKey = c.String(maxLength: 10, fixedLength: true),
                        Systematic = c.String(maxLength: 100),
                        SAPIndCode = c.String(maxLength: 50),
                        StatBusRelation = c.String(maxLength: 100),
                        CustGrp = c.String(maxLength: 100),
                        Relationship = c.String(maxLength: 50),
                        BorrowerUnit = c.String(maxLength: 100),
                        IDType = c.String(maxLength: 100),
                        FaxPrintdate = c.DateTime(),
                        CustType = c.String(maxLength: 50),
                        LegalEntityType = c.String(maxLength: 50),
                        ReferredBy = c.String(maxLength: 50),
                        Purpose = c.String(),
                        IDNumber = c.String(maxLength: 50),
                        BusNature = c.String(),
                        SIC = c.String(maxLength: 100),
                        ExistingRelation = c.Boolean(),
                        TenK = c.Boolean(),
                        PrimeCertInc = c.Boolean(),
                        PrimeCertGoodStand = c.Boolean(),
                        PrimeSyndParticipant = c.Boolean(),
                        PrimeGovEntity = c.Boolean(),
                        PrimeOther = c.Boolean(),
                        PrimeDriverLic = c.Boolean(),
                        PrimePassport = c.Boolean(),
                        PrimeStateID = c.Boolean(),
                        PrimeAlienReg = c.Boolean(),
                        PrimeResidentID = c.Boolean(),
                        PrimeUSSynd = c.Boolean(),
                        SecWorldCheck = c.Boolean(),
                        SecDB = c.Boolean(),
                        SecCertGoodStand = c.Boolean(),
                        SecCreditReport = c.Boolean(),
                        SecUtilityBill = c.Boolean(),
                        SecReverseDirectory = c.Boolean(),
                        SecBankRef = c.Boolean(),
                        SecOther = c.Boolean(),
                        MissingDocsPrim = c.Boolean(),
                        MissingDocsSec = c.Boolean(),
                        MissingDocs = c.String(),
                        MissingDocDate = c.DateTime(),
                        OtherDocs = c.String(),
                        CustNotification = c.Boolean(),
                        Ownership = c.String(),
                        Directors = c.String(),
                        Owners = c.String(),
                        Involvement = c.String(),
                        NamesMgmt = c.String(),
                        Subsidiaries = c.String(),
                        Signatories = c.String(),
                        WealthSource = c.String(),
                        FundsSource = c.String(),
                        Syndications = c.Boolean(),
                        OtherLending = c.Boolean(),
                        FundsTransfer = c.Boolean(),
                        BookTransfer = c.Boolean(),
                        RevolvingCredit = c.Boolean(),
                        StandbyLC = c.Boolean(),
                        CommLC = c.Boolean(),
                        DemandDA = c.Boolean(),
                        TimeDA = c.Boolean(),
                        CommPaper = c.Boolean(),
                        FXTrading = c.Boolean(),
                        DL = c.Boolean(),
                        FXDerivatives = c.Boolean(),
                        IntRateDerivatives = c.Boolean(),
                        TradeFinance = c.Boolean(),
                        ChecksIssued = c.Boolean(),
                        ProdOther = c.Boolean(),
                        ProdOtherText = c.String(),
                        BranchActivityCoun = c.String(),
                        FundMove1 = c.Boolean(),
                        FundMove2 = c.Boolean(),
                        FundMove3 = c.Boolean(),
                        FundMove4 = c.Boolean(),
                        FundMove5 = c.Boolean(),
                        FundMove6 = c.Boolean(),
                        InitDeposit = c.Double(),
                        InitDepositSource = c.String(),
                        InitDepositTransfer = c.Boolean(),
                        InitDepositCheck = c.Boolean(),
                        PrimaryVendors = c.String(),
                        InMonthlyTransactions = c.Double(),
                        InMonthlyAmount = c.Double(),
                        InRemitters = c.String(),
                        InCoun = c.String(),
                        OutMonthlyTransactions = c.Double(),
                        OutMonthlyAmount = c.Double(),
                        OutBeneficiaries = c.String(),
                        OutCoun = c.String(),
                        FinInstType = c.String(maxLength: 50),
                        Tele = c.String(maxLength: 50),
                        FinInstFAX = c.String(maxLength: 50),
                        FinInstWeb = c.String(maxLength: 100),
                        FinInstID = c.String(maxLength: 50),
                        FinInstSWIFT = c.String(maxLength: 100),
                        FinInstExchange = c.String(maxLength: 100),
                        FinInstSub = c.Boolean(),
                        FinInstSubParent = c.String(maxLength: 100),
                        FinInstGovUN = c.String(maxLength: 50),
                        FinInstPriviate = c.Boolean(),
                        FinInstGovPercent = c.Decimal(precision: 18, scale: 4),
                        FinInstShellBank = c.Boolean(),
                        FinInstRegulator = c.String(maxLength: 100),
                        Moody = c.String(maxLength: 50),
                        MoodySL = c.String(maxLength: 50),
                        SP = c.String(maxLength: 50),
                        SPSL = c.String(maxLength: 50),
                        Fitch = c.String(maxLength: 50),
                        FitchSL = c.String(maxLength: 50),
                        SettlementUSD = c.String(),
                        SettlementEURO = c.String(),
                        SettlementGBP = c.String(),
                        SettlementJPY = c.String(),
                        FinInstPatriot = c.Boolean(),
                        PatCertDate = c.DateTime(),
                        FinInstKYC = c.Boolean(),
                        FinInstStatement = c.Boolean(),
                        FinInstBankAlmanac = c.Boolean(),
                        FinInstComments = c.String(),
                        IndvEmail = c.String(maxLength: 100),
                        IndvNationality = c.String(maxLength: 100),
                        CustOpenStatus = c.String(maxLength: 50),
                        PrintStatus = c.String(maxLength: 50),
                        CustComplianceStatus = c.String(maxLength: 50),
                        EditBy = c.String(maxLength: 50),
                        EditDate = c.DateTime(),
                        CustOpenChange = c.String(maxLength: 50),
                        OffEditBy = c.String(maxLength: 50),
                        OffEditDate = c.DateTime(),
                        CommentEditBy = c.String(maxLength: 50),
                        CommentEditDate = c.DateTime(),
                        CompEditBy = c.String(maxLength: 50),
                        CompEditdate = c.DateTime(),
                        RiskCompBy = c.String(maxLength: 50),
                        RiskCompDate = c.DateTime(),
                        TempScore = c.Double(),
                        TempRating = c.String(maxLength: 50),
                        ReviewDate = c.DateTime(),
                        Score = c.Double(),
                        Rating = c.String(maxLength: 50),
                        BusHRForBanks = c.Boolean(),
                        BusHRCollection = c.Boolean(),
                        BusHROffShore = c.Boolean(),
                        BusHRImpExp = c.Boolean(),
                        BusHRCoun = c.Boolean(),
                        BusHRPIC = c.Boolean(),
                        BusHRLuxury = c.Boolean(),
                        BusHRGambling = c.Boolean(),
                        BusHRProfessionals = c.Boolean(),
                        BusHRInsurance = c.Boolean(),
                        BusHRBrokers = c.Boolean(),
                        BusHRREIT = c.Boolean(),
                        BusMRPublic = c.Boolean(),
                        BusMRPrivate = c.Boolean(),
                        BusMRForeignInd = c.Boolean(),
                        BusMRCoun = c.Boolean(),
                        BusMRUN = c.Boolean(),
                        BusLRBanks = c.Boolean(),
                        BusLRDomInd = c.Boolean(),
                        BusLRPublic = c.Boolean(),
                        BusLRCoun = c.Boolean(),
                        BusLRFCB = c.Boolean(),
                        TranHRCorrBanks = c.Boolean(),
                        TranHRIntlWire = c.Boolean(),
                        TranHRCash = c.Boolean(),
                        TranHRTrust = c.Boolean(),
                        TranHRFOREX = c.Boolean(),
                        TranMRChecks = c.Boolean(),
                        TranMRDomWire = c.Boolean(),
                        TranLRChecks = c.Boolean(),
                        TranLRMMKT = c.Boolean(),
                        TranLRDomWire = c.Boolean(),
                        TranLRCashMGMT = c.Boolean(),
                        TranLRCommPaper = c.Boolean(),
                        TranLRFOREX = c.Boolean(),
                        TranNR = c.Boolean(),
                        CreditHRLC = c.Boolean(),
                        CreditHRCashLoan = c.Boolean(),
                        CreditLRCorpLoan = c.Boolean(),
                        CreditLRRevCredit = c.Boolean(),
                        CreditMRSyndLoan = c.Boolean(),
                        CreditLRSyndLoan = c.Boolean(),
                        CreditLRCommLC = c.Boolean(),
                        CreditLRStandbyLC = c.Boolean(),
                        CreditLRCommMTG = c.Boolean(),
                        CreditNR = c.Boolean(),
                        GeoHRFAFT = c.Boolean(),
                        GeoHROFAC = c.Boolean(),
                        GeoHROther = c.Boolean(),
                        GeoHRAML = c.Boolean(),
                        GeoMRAML = c.Boolean(),
                        GeoLRAML = c.Boolean(),
                        GeoCountry1 = c.String(maxLength: 100),
                        GeoRisk1 = c.String(maxLength: 50),
                        GeoCountry2 = c.String(maxLength: 100),
                        GeoRisk2 = c.String(maxLength: 50),
                        CustHR2 = c.Boolean(),
                        CustHRSAR = c.Boolean(),
                        CustHRBadPress = c.Boolean(),
                        CustMR2to5 = c.Boolean(),
                        CustLR5 = c.Boolean(),
                        CustLR5Parent = c.Boolean(),
                        CustHRBP = c.Boolean(),
                        CustMRBP = c.Boolean(),
                        CustLRBP = c.Boolean(),
                        CustHRSub = c.Boolean(),
                        CustNR = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CUSTUniversal", t => t.ID, cascadeDelete: true)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.KYCGeoRiskLinkTemp",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustID = c.Int(),
                        Country = c.String(maxLength: 50),
                        Rating = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CUST", t => t.CustID, cascadeDelete: true)
                .Index(t => t.CustID);
            
            CreateTable(
                "dbo.KYCLinkRisk",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustID = c.Int(),
                        RiskID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.KYCStaticRisk", t => t.RiskID)
                .ForeignKey("dbo.CUST", t => t.CustID, cascadeDelete: true)
                .Index(t => t.CustID)
                .Index(t => t.RiskID);
            
            CreateTable(
                "dbo.KYCStaticRisk",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Category = c.String(maxLength: 100),
                        Rating = c.String(maxLength: 50),
                        Score = c.Double(),
                        Description = c.String(maxLength: 200),
                        AutoTo = c.String(maxLength: 50),
                        Active = c.String(maxLength: 50),
                        EditBy = c.String(maxLength: 50),
                        EditDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.KYCLinkRiskTemp",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustID = c.Int(),
                        RiskID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CUST", t => t.CustID, cascadeDelete: true)
                .Index(t => t.CustID);
            
            CreateTable(
                "dbo.CUSTDetail",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        SName = c.String(maxLength: 100),
                        COName = c.String(maxLength: 100),
                        Street = c.String(maxLength: 100),
                        PostCode = c.String(maxLength: 50),
                        CityState = c.String(maxLength: 100),
                        Country = c.String(maxLength: 100),
                        AccountMgr = c.String(maxLength: 50),
                        CreditMgr = c.String(maxLength: 50),
                        OPICSref = c.String(maxLength: 50),
                        MUREXref = c.String(maxLength: 50),
                        CMNE = c.String(maxLength: 10),
                        SAP = c.String(maxLength: 50),
                        LName = c.String(maxLength: 100),
                        LStreet = c.String(maxLength: 100),
                        LPostCode = c.String(maxLength: 50),
                        LCityState = c.String(maxLength: 100),
                        BirthDate = c.DateTime(),
                        AcctCloseDate = c.DateTime(),
                        EditDate = c.DateTime(),
                        EditBy = c.String(maxLength: 50),
                        Comments = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CUSTUniversal", t => t.ID, cascadeDelete: true)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.CustPipelineBookingStatus",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustID = c.Int(),
                        Status = c.String(maxLength: 50),
                        CompleteBy = c.String(maxLength: 50),
                        CompleteDate = c.DateTime(),
                        BookedBy = c.String(maxLength: 50),
                        BookedDate = c.DateTime(),
                        Comments = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CUSTUniversal", t => t.CustID, cascadeDelete: true)
                .Index(t => t.CustID);
            
            CreateTable(
                "dbo.CustPipelineComments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustID = c.Int(nullable: false),
                        Status = c.String(maxLength: 50),
                        ReviewType = c.String(maxLength: 50),
                        EditBy = c.String(maxLength: 50),
                        EditDate = c.DateTime(),
                        Comment = c.String(),
                        MemoType = c.String(maxLength: 50),
                        SentBy = c.String(maxLength: 50),
                        SentDate = c.DateTime(),
                        RecBy = c.String(maxLength: 50),
                        RecDate = c.DateTime(),
                        MemoStatus = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CUSTUniversal", t => t.CustID, cascadeDelete: true)
                .Index(t => t.CustID);
            
            CreateTable(
                "dbo.CustPipelineDecisionHistory",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustID = c.Int(nullable: false),
                        RatingSegment = c.Boolean(),
                        Rating = c.String(maxLength: 50),
                        RatingDate = c.DateTime(),
                        TransactionSize = c.Double(),
                        RequiredCapital = c.Double(),
                        ApprovalLevel = c.Boolean(),
                        RequestedCommitment = c.Double(),
                        ApprovedCommitment = c.Double(),
                        PipelineSubDate = c.DateTime(),
                        PipelineNDMDate = c.DateTime(),
                        PipelineDecisionDate = c.DateTime(),
                        PipelineDecision = c.String(maxLength: 50),
                        PipelineDecisionBy = c.String(maxLength: 50),
                        PipelineDeadline = c.DateTime(),
                        CreditNYSubDate = c.DateTime(),
                        CreditNYDecisionDate = c.DateTime(),
                        CreditNYDecision = c.String(maxLength: 50),
                        CreditNYDecisionBy = c.String(maxLength: 50),
                        CreditFFKTSubDate = c.DateTime(),
                        CreditFFKTDecisionDate = c.DateTime(),
                        CreditFFKTDecision = c.String(maxLength: 50),
                        CreditFFKTDecisionBy = c.String(maxLength: 50),
                        CreditDeadline = c.DateTime(),
                        ReviewDate = c.DateTime(),
                        ReviewType = c.String(maxLength: 50),
                        Comment = c.String(),
                        ClickAction = c.String(maxLength: 300),
                        EditBy = c.String(maxLength: 50),
                        Editdate = c.DateTime(),
                        Status = c.String(maxLength: 50),
                        KYCStatus = c.String(maxLength: 50),
                        KYCRating = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CUSTUniversal", t => t.CustID, cascadeDelete: true)
                .Index(t => t.CustID);
            
            CreateTable(
                "dbo.CustPipelineFacility",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustID = c.Int(nullable: false),
                        FacilityType = c.String(maxLength: 50),
                        Currency = c.String(maxLength: 50),
                        FX = c.Double(),
                        GlobalFacility = c.Double(),
                        RequestedCommitment = c.Double(),
                        ApprovedCommitment = c.Double(),
                        Approved = c.Boolean(),
                        GlobalUSD = c.Double(),
                        RequestedUSD = c.Double(),
                        ApprovedUSD = c.Double(),
                        EditBy = c.String(maxLength: 50),
                        EditDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CUSTUniversal", t => t.CustID, cascadeDelete: true)
                .Index(t => t.CustID);
            
            CreateTable(
                "dbo.CustPipelineFacilityDetail",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FacilityID = c.Int(),
                        MultiCCy = c.Boolean(),
                        EffDate = c.DateTime(),
                        MatDate = c.DateTime(),
                        FacReduction = c.Boolean(),
                        BranchLimit = c.Boolean(),
                        OtherEligible = c.Boolean(),
                        Comm = c.Boolean(),
                        Advance = c.Boolean(),
                        PurchaseDraft = c.Boolean(),
                        LoanGuarantee = c.Boolean(),
                        StandbyLC = c.Boolean(),
                        DocLC = c.Boolean(),
                        AgentBank = c.String(maxLength: 50),
                        Syndicated = c.Boolean(),
                        Purpose = c.String(maxLength: 50),
                        Secured = c.Boolean(),
                        AdvLIBORMargin = c.Double(),
                        AdvLIBORBasis = c.String(maxLength: 50),
                        AdvLIBORIntPay = c.String(maxLength: 50),
                        AdvCOFMargin = c.Double(),
                        AdvCOFBasis = c.String(maxLength: 50),
                        AdvCOFIntPay = c.String(maxLength: 50),
                        AdvFixedMargin = c.Double(),
                        AdvFixedBasis = c.String(maxLength: 50),
                        AdvFixedIntPay = c.String(maxLength: 50),
                        AdvPrimeMargin = c.Double(),
                        AdvPrimeBasis = c.String(maxLength: 50),
                        AdvPrimeIntPay = c.String(maxLength: 50),
                        DraftType = c.String(maxLength: 50),
                        DraftMargin = c.Double(),
                        DraftBasis = c.String(maxLength: 50),
                        DraftIntPay = c.String(maxLength: 50),
                        LCMargin = c.Double(),
                        LCBasis = c.String(maxLength: 50),
                        LCIntPay = c.String(maxLength: 50),
                        LCSubLimit = c.Double(),
                        FacCommFeeMargin = c.Double(),
                        FacCommFeeBasis = c.String(maxLength: 50),
                        FacCommFeeIntPay = c.String(maxLength: 50),
                        FacFacilityFeeMargin = c.Double(),
                        FacFacilityFeeBasis = c.String(maxLength: 50),
                        FacFacilityFeeIntPay = c.String(maxLength: 50),
                        FacUpfrontFeeMargin = c.Double(),
                        FacUpfrontFeeBasis = c.String(maxLength: 50),
                        FacUpfrontFeeIntPay = c.String(maxLength: 50),
                        ProfitCenter = c.String(maxLength: 50),
                        FacilityDescription = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CustPipelineFacility", t => t.FacilityID, cascadeDelete: true)
                .Index(t => t.FacilityID);
            
            CreateTable(
                "dbo.CustPipelineLinked",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustID = c.Int(),
                        LinkedID = c.Int(),
                        LinkedBy = c.String(maxLength: 50),
                        LinkedDate = c.DateTime(),
                        WFOnly = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CUSTUniversal", t => t.CustID, cascadeDelete: true)
                .Index(t => t.CustID);
            
            CreateTable(
                "dbo.CustPipeline",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustID = c.Int(nullable: false),
                        Status = c.String(maxLength: 50),
                        StatusChangeDate = c.DateTime(),
                        SponsorID = c.Int(),
                        SectorID = c.Int(),
                        RatingSegment = c.Boolean(),
                        Rating = c.String(maxLength: 50),
                        RatingDate = c.DateTime(),
                        TransactionSize = c.Double(),
                        CapitalRequired = c.Double(),
                        ApprovalLevel = c.Boolean(),
                        PipelineSubDate = c.DateTime(),
                        PipelineNDMDate = c.DateTime(),
                        PipelineDecisionDate = c.DateTime(),
                        PipelineDecision = c.String(maxLength: 50),
                        PipelineDecisionBy = c.String(maxLength: 50),
                        PipelineDeadline = c.DateTime(),
                        CreditNYSubDate = c.DateTime(),
                        CreditNYDecisionDate = c.DateTime(),
                        CreditNYDecision = c.String(maxLength: 50),
                        CreditNYDecisionBy = c.String(maxLength: 50),
                        CreditFFKTSubDate = c.DateTime(),
                        CreditFFKTDecisionDate = c.DateTime(),
                        CreditFFKTDecision = c.String(maxLength: 50),
                        CreditFFKTDecisionBy = c.String(maxLength: 50),
                        CreditDeadline = c.DateTime(),
                        ReviewDate = c.DateTime(),
                        ReviewType = c.String(maxLength: 50),
                        Comment = c.String(),
                        LoanRef = c.String(maxLength: 50),
                        EditBy = c.String(maxLength: 50),
                        EditDate = c.DateTime(),
                        ReportValue = c.String(maxLength: 50),
                        Deadline = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CUSTUniversal", t => t.CustID, cascadeDelete: true)
                .Index(t => t.CustID);
            
            CreateTable(
                "dbo.ReferenceExternalAcct",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AcctID = c.Int(),
                        UploadDate = c.DateTime(),
                        UploadBy = c.String(maxLength: 50),
                        Description = c.String(maxLength: 100),
                        Link = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CUSTUniversal", t => t.AcctID, cascadeDelete: true)
                .Index(t => t.AcctID);
            
            CreateTable(
                "dbo.ReferenceInternalAcct",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AcctID = c.Int(),
                        UploadDate = c.DateTime(),
                        UploadBy = c.String(maxLength: 50),
                        Description = c.String(maxLength: 100),
                        Link = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CUSTUniversal", t => t.AcctID, cascadeDelete: true)
                .Index(t => t.AcctID);
            
            CreateTable(
                "dbo.ChangeInfo",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustID = c.Int(nullable: false),
                        ChangeDate = c.DateTime(nullable: false),
                        ChangeType = c.String(nullable: false, maxLength: 50),
                        Author = c.String(nullable: false, maxLength: 50),
                        OldScore = c.String(nullable: false, maxLength: 50),
                        NewScore = c.String(nullable: false, maxLength: 50),
                        Comments = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ContactLink",
                c => new
                    {
                        CustID = c.String(nullable: false, maxLength: 50),
                        ContactID = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => new { t.CustID, t.ContactID });
            
            CreateTable(
                "dbo.CustPipelineBooking",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustID = c.Int(),
                        FacilityID = c.Int(),
                        Allocation = c.Double(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.CustPipelineRatingHistory",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustID = c.Int(),
                        RatingSegment = c.Boolean(),
                        Rating = c.String(maxLength: 50),
                        RatingDate = c.DateTime(),
                        ChangeDate = c.DateTime(precision: 7, storeType: "datetime2"),
                        ChangeBy = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.CustPipelineSFLN",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Facility = c.Double(),
                        SP = c.String(maxLength: 10),
                        Moody = c.String(maxLength: 10),
                        BADate = c.DateTime(),
                        Bid = c.Double(),
                        Ask = c.Double(),
                        LWBADate = c.DateTime(),
                        LWBid = c.Double(),
                        LWAsk = c.Double(),
                        LWDiff = c.Double(),
                        LCDS3 = c.Double(),
                        LCDS5 = c.Double(),
                        CDS3 = c.Double(),
                        CDS5 = c.Double(),
                        Share = c.Double(),
                        ShareHigh = c.Double(),
                        ShareLow = c.Double(),
                        Bond = c.Double(),
                        Coupon = c.Double(),
                        Price = c.Double(),
                        Maturity = c.DateTime(),
                        CO = c.String(maxLength: 10),
                        UploadDate = c.DateTime(),
                        Commitment = c.Double(),
                        CommitmentUSD = c.Double(),
                        GroupsUSD = c.Double(),
                        UsedUSD = c.Double(),
                        UnUsedUSD = c.Double(),
                        Comments = c.String(),
                        CCY = c.String(maxLength: 10),
                        Alpha = c.String(maxLength: 50),
                        LastExec = c.DateTime(),
                        FacilityType = c.String(maxLength: 50),
                        Spread = c.Double(),
                        Name = c.String(maxLength: 100),
                        BVR2 = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.DataSync",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 5),
                        DataType = c.String(maxLength: 50),
                        SyncDate = c.DateTime(),
                        SyncBy = c.String(maxLength: 50),
                        DataVaild = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Facilities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Facility = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.FromAccessAcctstoClose",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        OPICSref = c.String(maxLength: 50),
                        SName = c.String(maxLength: 100),
                        CMNE = c.String(maxLength: 50),
                        FullName = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.FXLastUpdate",
                c => new
                    {
                        LastUpdate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.LastUpdate);
            
            CreateTable(
                "dbo.GeoRiskRatings",
                c => new
                    {
                        GeoID = c.Int(nullable: false),
                        Country = c.String(maxLength: 255),
                        RiskClassUS = c.String(maxLength: 50),
                        RatingDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.GeoID);
            
            CreateTable(
                "dbo.kyc_riskCategory",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Ordinal = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.kyc_riskClass",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 20),
                        ID = c.Int(nullable: false),
                        Score = c.Int(nullable: false),
                        Ordinal = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Name);
            
            CreateTable(
                "dbo.kyc_riskItem",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 140),
                        CategoryID = c.Int(nullable: false),
                        ClassID = c.Int(nullable: false),
                        Score = c.Int(nullable: false),
                        Ordinal = c.Int(nullable: false),
                        Class_Name = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.kyc_riskCategory", t => t.CategoryID, cascadeDelete: true)
                .ForeignKey("dbo.kyc_riskClass", t => t.Class_Name)
                .Index(t => t.CategoryID)
                .Index(t => t.Class_Name);
            
            CreateTable(
                "dbo.KYCLastUpdate",
                c => new
                    {
                        LastUpdate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.LastUpdate);
            
            CreateTable(
                "dbo.KYCStaticRiskCategories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Category = c.String(maxLength: 100),
                        Active = c.String(maxLength: 50),
                        EditBy = c.String(maxLength: 50),
                        EditDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.LoanNeuStat3SQL",
                c => new
                    {
                        OPICSRef = c.String(nullable: false, maxLength: 50),
                        FacilityID = c.String(nullable: false, maxLength: 50),
                        FacilityAmt = c.Double(),
                        FacilityUnused = c.Double(),
                        MaturityDate = c.DateTime(),
                        UploadDate = c.DateTime(),
                    })
                .PrimaryKey(t => new { t.OPICSRef, t.FacilityID });
            
            CreateTable(
                "dbo.MoodyRating",
                c => new
                    {
                        Rating = c.String(nullable: false, maxLength: 50),
                        Sort = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Rating);
            
            CreateTable(
                "dbo.OPICSCUSTLookup",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        CNO = c.String(maxLength: 11),
                        CMNE = c.String(maxLength: 50),
                        CFN1 = c.String(maxLength: 100),
                        SN = c.String(maxLength: 50),
                        BirthDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.OPICSCUST",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CNO = c.String(nullable: false, maxLength: 11),
                        CMNE = c.String(maxLength: 50),
                        Name = c.String(maxLength: 100),
                        OpenDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ReferenceExternalGeneral",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AcctID = c.Int(),
                        UploadDate = c.DateTime(),
                        UploadBy = c.String(maxLength: 50),
                        Description = c.String(maxLength: 100),
                        Link = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ReferenceInternalGeneral",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AcctID = c.Int(),
                        UploadDate = c.DateTime(),
                        UploadBy = c.String(maxLength: 50),
                        Description = c.String(maxLength: 100),
                        Link = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SAPBP",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BP = c.String(nullable: false, maxLength: 8),
                        BPName = c.String(maxLength: 100),
                        KYCID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Sector",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Sector = c.String(nullable: false, maxLength: 50),
                        Type = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SPRating",
                c => new
                    {
                        Rating = c.String(nullable: false, maxLength: 50),
                        Sort = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Rating);
            
            CreateTable(
                "dbo.sysdiagrams",
                c => new
                    {
                        diagram_id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 128),
                        principal_id = c.Int(nullable: false),
                        version = c.Int(),
                        definition = c.Binary(),
                    })
                .PrimaryKey(t => t.diagram_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.kyc_riskItem", "Class_Name", "dbo.kyc_riskClass");
            DropForeignKey("dbo.kyc_riskItem", "CategoryID", "dbo.kyc_riskCategory");
            DropForeignKey("dbo.ReferenceInternalAcct", "AcctID", "dbo.CUSTUniversal");
            DropForeignKey("dbo.ReferenceExternalAcct", "AcctID", "dbo.CUSTUniversal");
            DropForeignKey("dbo.CustPipeline", "CustID", "dbo.CUSTUniversal");
            DropForeignKey("dbo.CustPipelineLinked", "CustID", "dbo.CUSTUniversal");
            DropForeignKey("dbo.CustPipelineFacility", "CustID", "dbo.CUSTUniversal");
            DropForeignKey("dbo.CustPipelineFacilityDetail", "FacilityID", "dbo.CustPipelineFacility");
            DropForeignKey("dbo.CustPipelineDecisionHistory", "CustID", "dbo.CUSTUniversal");
            DropForeignKey("dbo.CustPipelineComments", "CustID", "dbo.CUSTUniversal");
            DropForeignKey("dbo.CustPipelineBookingStatus", "CustID", "dbo.CUSTUniversal");
            DropForeignKey("dbo.CUSTDetail", "ID", "dbo.CUSTUniversal");
            DropForeignKey("dbo.CUST", "ID", "dbo.CUSTUniversal");
            DropForeignKey("dbo.KYCLinkRiskTemp", "CustID", "dbo.CUST");
            DropForeignKey("dbo.KYCLinkRisk", "CustID", "dbo.CUST");
            DropForeignKey("dbo.KYCLinkRisk", "RiskID", "dbo.KYCStaticRisk");
            DropForeignKey("dbo.KYCGeoRiskLinkTemp", "CustID", "dbo.CUST");
            DropForeignKey("dbo.CCF", "CustID", "dbo.CUSTUniversal");
            DropIndex("dbo.kyc_riskItem", new[] { "Class_Name" });
            DropIndex("dbo.kyc_riskItem", new[] { "CategoryID" });
            DropIndex("dbo.ReferenceInternalAcct", new[] { "AcctID" });
            DropIndex("dbo.ReferenceExternalAcct", new[] { "AcctID" });
            DropIndex("dbo.CustPipeline", new[] { "CustID" });
            DropIndex("dbo.CustPipelineLinked", new[] { "CustID" });
            DropIndex("dbo.CustPipelineFacilityDetail", new[] { "FacilityID" });
            DropIndex("dbo.CustPipelineFacility", new[] { "CustID" });
            DropIndex("dbo.CustPipelineDecisionHistory", new[] { "CustID" });
            DropIndex("dbo.CustPipelineComments", new[] { "CustID" });
            DropIndex("dbo.CustPipelineBookingStatus", new[] { "CustID" });
            DropIndex("dbo.CUSTDetail", new[] { "ID" });
            DropIndex("dbo.KYCLinkRiskTemp", new[] { "CustID" });
            DropIndex("dbo.KYCLinkRisk", new[] { "RiskID" });
            DropIndex("dbo.KYCLinkRisk", new[] { "CustID" });
            DropIndex("dbo.KYCGeoRiskLinkTemp", new[] { "CustID" });
            DropIndex("dbo.CUST", new[] { "ID" });
            DropIndex("dbo.CCF", new[] { "CustID" });
            DropTable("dbo.sysdiagrams");
            DropTable("dbo.SPRating");
            DropTable("dbo.Sector");
            DropTable("dbo.SAPBP");
            DropTable("dbo.ReferenceInternalGeneral");
            DropTable("dbo.ReferenceExternalGeneral");
            DropTable("dbo.OPICSCUST");
            DropTable("dbo.OPICSCUSTLookup");
            DropTable("dbo.MoodyRating");
            DropTable("dbo.LoanNeuStat3SQL");
            DropTable("dbo.KYCStaticRiskCategories");
            DropTable("dbo.KYCLastUpdate");
            DropTable("dbo.kyc_riskItem");
            DropTable("dbo.kyc_riskClass");
            DropTable("dbo.kyc_riskCategory");
            DropTable("dbo.GeoRiskRatings");
            DropTable("dbo.FXLastUpdate");
            DropTable("dbo.FromAccessAcctstoClose");
            DropTable("dbo.Facilities");
            DropTable("dbo.DataSync");
            DropTable("dbo.CustPipelineSFLN");
            DropTable("dbo.CustPipelineRatingHistory");
            DropTable("dbo.CustPipelineBooking");
            DropTable("dbo.ContactLink");
            DropTable("dbo.ChangeInfo");
            DropTable("dbo.ReferenceInternalAcct");
            DropTable("dbo.ReferenceExternalAcct");
            DropTable("dbo.CustPipeline");
            DropTable("dbo.CustPipelineLinked");
            DropTable("dbo.CustPipelineFacilityDetail");
            DropTable("dbo.CustPipelineFacility");
            DropTable("dbo.CustPipelineDecisionHistory");
            DropTable("dbo.CustPipelineComments");
            DropTable("dbo.CustPipelineBookingStatus");
            DropTable("dbo.CUSTDetail");
            DropTable("dbo.KYCLinkRiskTemp");
            DropTable("dbo.KYCStaticRisk");
            DropTable("dbo.KYCLinkRisk");
            DropTable("dbo.KYCGeoRiskLinkTemp");
            DropTable("dbo.CUST");
            DropTable("dbo.CUSTUniversal");
            DropTable("dbo.CCF");
            DropTable("dbo.AgentBanks");
        }
    }
}

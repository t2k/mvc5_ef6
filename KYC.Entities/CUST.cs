namespace KYC.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUST")]
    public partial class CUST
    {
        public CUST()
        {

            KYCGeoRiskLinkTemps = new HashSet<KYCGeoRiskLinkTemp>();
            KYCLinkRisks = new HashSet<KYCLinkRisk>();
            KYCLinkRiskTemps = new HashSet<KYCLinkRiskTemp>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public bool? OFAC { get; set; }

        [StringLength(100)]
        public string BPRole { get; set; }

        [StringLength(100)]
        public string ZISLegalForm { get; set; }

        [StringLength(100)]
        public string CountryCode { get; set; }

        [StringLength(100)]
        public string UltCountryCode { get; set; }

        [StringLength(50)]
        public string SpecType { get; set; }

        [StringLength(50)]
        public string LegalEntity { get; set; }

        [StringLength(2)]
        public string ContractPartner { get; set; }

        [StringLength(50)]
        public string RiskSector { get; set; }

        [StringLength(10)]
        public string SectorKey { get; set; }

        [StringLength(100)]
        public string Systematic { get; set; }

        [StringLength(50)]
        public string SAPIndCode { get; set; }

        [StringLength(100)]
        public string StatBusRelation { get; set; }

        [StringLength(100)]
        public string CustGrp { get; set; }

        [StringLength(50)]
        public string Relationship { get; set; }

        [StringLength(100)]
        public string BorrowerUnit { get; set; }

        [StringLength(100)]
        public string IDType { get; set; }

        public DateTime? FaxPrintdate { get; set; }

        [StringLength(50)]
        public string CustType { get; set; }

        [StringLength(50)]
        public string LegalEntityType { get; set; }

        [StringLength(50)]
        public string ReferredBy { get; set; }

        public string Purpose { get; set; }

        [StringLength(50)]
        public string IDNumber { get; set; }

        public string BusNature { get; set; }

        [StringLength(100)]
        public string SIC { get; set; }

        public bool? ExistingRelation { get; set; }

        public bool? TenK { get; set; }

        public bool? PrimeCertInc { get; set; }

        public bool? PrimeCertGoodStand { get; set; }

        public bool? PrimeSyndParticipant { get; set; }

        public bool? PrimeGovEntity { get; set; }

        public bool? PrimeOther { get; set; }

        public bool? PrimeDriverLic { get; set; }

        public bool? PrimePassport { get; set; }

        public bool? PrimeStateID { get; set; }

        public bool? PrimeAlienReg { get; set; }

        public bool? PrimeResidentID { get; set; }

        public bool? PrimeUSSynd { get; set; }

        public bool? SecWorldCheck { get; set; }

        public bool? SecDB { get; set; }

        public bool? SecCertGoodStand { get; set; }

        public bool? SecCreditReport { get; set; }

        public bool? SecUtilityBill { get; set; }

        public bool? SecReverseDirectory { get; set; }

        public bool? SecBankRef { get; set; }

        public bool? SecOther { get; set; }

        public bool? MissingDocsPrim { get; set; }

        public bool? MissingDocsSec { get; set; }

        public string MissingDocs { get; set; }

        public DateTime? MissingDocDate { get; set; }

        public string OtherDocs { get; set; }

        public bool? CustNotification { get; set; }

        public string Ownership { get; set; }

        public string Directors { get; set; }

        public string Owners { get; set; }

        public string Involvement { get; set; }

        public string NamesMgmt { get; set; }

        public string Subsidiaries { get; set; }

        public string Signatories { get; set; }

        public string WealthSource { get; set; }

        public string FundsSource { get; set; }

        public bool? Syndications { get; set; }

        public bool? OtherLending { get; set; }

        public bool? FundsTransfer { get; set; }

        public bool? BookTransfer { get; set; }

        public bool? RevolvingCredit { get; set; }

        public bool? StandbyLC { get; set; }

        public bool? CommLC { get; set; }

        public bool? DemandDA { get; set; }

        public bool? TimeDA { get; set; }

        public bool? CommPaper { get; set; }

        public bool? FXTrading { get; set; }

        public bool? DL { get; set; }

        public bool? FXDerivatives { get; set; }

        public bool? IntRateDerivatives { get; set; }

        public bool? TradeFinance { get; set; }

        public bool? ChecksIssued { get; set; }

        public bool? ProdOther { get; set; }

        public string ProdOtherText { get; set; }

        public string BranchActivityCoun { get; set; }

        public bool? FundMove1 { get; set; }

        public bool? FundMove2 { get; set; }

        public bool? FundMove3 { get; set; }

        public bool? FundMove4 { get; set; }

        public bool? FundMove5 { get; set; }

        public bool? FundMove6 { get; set; }

        public double? InitDeposit { get; set; }

        public string InitDepositSource { get; set; }

        public bool? InitDepositTransfer { get; set; }

        public bool? InitDepositCheck { get; set; }

        public string PrimaryVendors { get; set; }

        public double? InMonthlyTransactions { get; set; }

        public double? InMonthlyAmount { get; set; }

        public string InRemitters { get; set; }

        public string InCoun { get; set; }

        public double? OutMonthlyTransactions { get; set; }

        public double? OutMonthlyAmount { get; set; }

        public string OutBeneficiaries { get; set; }

        public string OutCoun { get; set; }

        [StringLength(50)]
        public string FinInstType { get; set; }

        [StringLength(50)]
        public string Tele { get; set; }

        [StringLength(50)]
        public string FinInstFAX { get; set; }

        [StringLength(100)]
        public string FinInstWeb { get; set; }

        [StringLength(50)]
        public string FinInstID { get; set; }

        [StringLength(100)]
        public string FinInstSWIFT { get; set; }

        [StringLength(100)]
        public string FinInstExchange { get; set; }

        public bool? FinInstSub { get; set; }

        [StringLength(100)]
        public string FinInstSubParent { get; set; }

        [StringLength(50)]
        public string FinInstGovUN { get; set; }

        public bool? FinInstPriviate { get; set; }

        public decimal? FinInstGovPercent { get; set; }

        public bool? FinInstShellBank { get; set; }

        [StringLength(100)]
        public string FinInstRegulator { get; set; }

        [StringLength(50)]
        public string Moody { get; set; }

        [StringLength(50)]
        public string MoodySL { get; set; }

        [StringLength(50)]
        public string SP { get; set; }

        [StringLength(50)]
        public string SPSL { get; set; }

        [StringLength(50)]
        public string Fitch { get; set; }

        [StringLength(50)]
        public string FitchSL { get; set; }

        public string SettlementUSD { get; set; }

        public string SettlementEURO { get; set; }

        public string SettlementGBP { get; set; }

        public string SettlementJPY { get; set; }

        public bool? FinInstPatriot { get; set; }

        public DateTime? PatCertDate { get; set; }

        public bool? FinInstKYC { get; set; }

        public bool? FinInstStatement { get; set; }

        public bool? FinInstBankAlmanac { get; set; }

        public string FinInstComments { get; set; }

        [StringLength(100)]
        public string IndvEmail { get; set; }

        [StringLength(100)]
        public string IndvNationality { get; set; }

        [StringLength(50)]
        public string CustOpenStatus { get; set; }

        [StringLength(50)]
        public string PrintStatus { get; set; }

        [StringLength(50)]
        public string CustComplianceStatus { get; set; }

        [StringLength(50)]
        public string EditBy { get; set; }

        public DateTime? EditDate { get; set; }

        [StringLength(50)]
        public string CustOpenChange { get; set; }

        [StringLength(50)]
        public string OffEditBy { get; set; }

        public DateTime? OffEditDate { get; set; }

        [StringLength(50)]
        public string CommentEditBy { get; set; }

        public DateTime? CommentEditDate { get; set; }

        [StringLength(50)]
        public string CompEditBy { get; set; }

        public DateTime? CompEditdate { get; set; }

        [StringLength(50)]
        public string RiskCompBy { get; set; }

        public DateTime? RiskCompDate { get; set; }

        public double? TempScore { get; set; }

        [StringLength(50)]
        public string TempRating { get; set; }

        public DateTime? ReviewDate { get; set; }

        public double? Score { get; set; }

        [StringLength(50)]
        public string Rating { get; set; }

        public bool? BusHRForBanks { get; set; }

        public bool? BusHRCollection { get; set; }

        public bool? BusHROffShore { get; set; }

        public bool? BusHRImpExp { get; set; }

        public bool? BusHRCoun { get; set; }

        public bool? BusHRPIC { get; set; }

        public bool? BusHRLuxury { get; set; }

        public bool? BusHRGambling { get; set; }

        public bool? BusHRProfessionals { get; set; }

        public bool? BusHRInsurance { get; set; }

        public bool? BusHRBrokers { get; set; }

        public bool? BusHRREIT { get; set; }

        public bool? BusMRPublic { get; set; }

        public bool? BusMRPrivate { get; set; }

        public bool? BusMRForeignInd { get; set; }

        public bool? BusMRCoun { get; set; }

        public bool? BusMRUN { get; set; }

        public bool? BusLRBanks { get; set; }

        public bool? BusLRDomInd { get; set; }

        public bool? BusLRPublic { get; set; }

        public bool? BusLRCoun { get; set; }

        public bool? BusLRFCB { get; set; }

        public bool? TranHRCorrBanks { get; set; }

        public bool? TranHRIntlWire { get; set; }

        public bool? TranHRCash { get; set; }

        public bool? TranHRTrust { get; set; }

        public bool? TranHRFOREX { get; set; }

        public bool? TranMRChecks { get; set; }

        public bool? TranMRDomWire { get; set; }

        public bool? TranLRChecks { get; set; }

        public bool? TranLRMMKT { get; set; }

        public bool? TranLRDomWire { get; set; }

        public bool? TranLRCashMGMT { get; set; }

        public bool? TranLRCommPaper { get; set; }

        public bool? TranLRFOREX { get; set; }

        public bool? TranNR { get; set; }

        public bool? CreditHRLC { get; set; }

        public bool? CreditHRCashLoan { get; set; }

        public bool? CreditLRCorpLoan { get; set; }

        public bool? CreditLRRevCredit { get; set; }

        public bool? CreditMRSyndLoan { get; set; }

        public bool? CreditLRSyndLoan { get; set; }

        public bool? CreditLRCommLC { get; set; }

        public bool? CreditLRStandbyLC { get; set; }

        public bool? CreditLRCommMTG { get; set; }

        public bool? CreditNR { get; set; }

        public bool? GeoHRFAFT { get; set; }

        public bool? GeoHROFAC { get; set; }

        public bool? GeoHROther { get; set; }

        public bool? GeoHRAML { get; set; }

        public bool? GeoMRAML { get; set; }

        public bool? GeoLRAML { get; set; }

        [StringLength(100)]
        public string GeoCountry1 { get; set; }

        [StringLength(50)]
        public string GeoRisk1 { get; set; }

        [StringLength(100)]
        public string GeoCountry2 { get; set; }

        [StringLength(50)]
        public string GeoRisk2 { get; set; }

        public bool? CustHR2 { get; set; }

        public bool? CustHRSAR { get; set; }

        public bool? CustHRBadPress { get; set; }

        public bool? CustMR2to5 { get; set; }

        public bool? CustLR5 { get; set; }

        public bool? CustLR5Parent { get; set; }

        public bool? CustHRBP { get; set; }

        public bool? CustMRBP { get; set; }

        public bool? CustLRBP { get; set; }

        public bool? CustHRSub { get; set; }

        public bool? CustNR { get; set; }

        public virtual CUSTUniversal CUSTUniversal { get; set; }


        public virtual ICollection<KYCGeoRiskLinkTemp> KYCGeoRiskLinkTemps { get; set; }

        public virtual ICollection<KYCLinkRisk> KYCLinkRisks { get; set; }

        public virtual ICollection<KYCLinkRiskTemp> KYCLinkRiskTemps { get; set; }
    }
}

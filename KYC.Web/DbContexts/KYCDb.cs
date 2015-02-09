using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using KYC.Entities;
using System.Diagnostics;

namespace KYC.Web.DbContexts
{
    public class KYCDb : DbContext
    {

        public KYCDb()
            : base("name=KYCModel")
        {
            Database.Log = sql => Debug.Write(sql);
        }

        public virtual DbSet<CCF> CCFs { get; set; }
        public virtual DbSet<ChangeInfo> ChangeInfoes { get; set; }
        public virtual DbSet<ContactLink> ContactLinks { get; set; }
        public virtual DbSet<CUST> CUSTs { get; set; }
        public virtual DbSet<CUSTDetail> CUSTDetails { get; set; }
        public virtual DbSet<CustPipeline> CustPipelines { get; set; }
        public virtual DbSet<CustPipelineBooking> CustPipelineBookings { get; set; }
        public virtual DbSet<CustPipelineBookingStatu> CustPipelineBookingStatus { get; set; }
        public virtual DbSet<CustPipelineComment> CustPipelineComments { get; set; }
        public virtual DbSet<CustPipelineDecisionHistory> CustPipelineDecisionHistories { get; set; }
        public virtual DbSet<CustPipelineFacility> CustPipelineFacilities { get; set; }
        public virtual DbSet<CustPipelineFacilityDetail> CustPipelineFacilityDetails { get; set; }
        public virtual DbSet<CustPipelineLinked> CustPipelineLinkeds { get; set; }
        public virtual DbSet<CustPipelineRatingHistory> CustPipelineRatingHistories { get; set; }
        public virtual DbSet<CustPipelineSFLN> CustPipelineSFLNs { get; set; }
        public virtual DbSet<CUSTUniversal> CUSTUniversals { get; set; }
        public virtual DbSet<DataSync> DataSyncs { get; set; }
        public virtual DbSet<FromAccessAcctstoClose> FromAccessAcctstoCloses { get; set; }
        public virtual DbSet<FXLastUpdate> FXLastUpdates { get; set; }
        public virtual DbSet<GeoRiskRating> GeoRiskRatings { get; set; }
        public virtual DbSet<kyc_riskCategory> kyc_riskcategory { get; set; }
        public virtual DbSet<kyc_riskClass> kyc_riskclass { get; set; }
        public virtual DbSet<kyc_riskItem> kyc_riskItems { get; set; }
        public virtual DbSet<KYCGeoRiskLinkTemp> KYCGeoRiskLinkTemps { get; set; }
        public virtual DbSet<KYCLastUpdate> KYCLastUpdates { get; set; }
        public virtual DbSet<KYCLinkRisk> KYCLinkRisks { get; set; }
        public virtual DbSet<KYCLinkRiskTemp> KYCLinkRiskTemps { get; set; }
        public virtual DbSet<KYCStaticRisk> KYCStaticRisks { get; set; }
        public virtual DbSet<KYCStaticRiskCategory> KYCStaticRiskCategories { get; set; }
        public virtual DbSet<LoanNeuStat3SQL> LoanNeuStat3SQL { get; set; }
        public virtual DbSet<MoodyRating> MoodyRatings { get; set; }
        public virtual DbSet<OPICSCUST> OPICSCUSTs { get; set; }
        public virtual DbSet<OPICSCUSTLookup> OPICSCUSTLookups { get; set; }
        public virtual DbSet<ReferenceExternalAcct> ReferenceExternalAccts { get; set; }
        public virtual DbSet<ReferenceExternalGeneral> ReferenceExternalGenerals { get; set; }
        public virtual DbSet<ReferenceInternalAcct> ReferenceInternalAccts { get; set; }
        public virtual DbSet<ReferenceInternalGeneral> ReferenceInternalGenerals { get; set; }
        public virtual DbSet<SAPBP> SAPBPs { get; set; }
        public virtual DbSet<Sector> Sectors { get; set; }
        public virtual DbSet<SPRating> SPRatings { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<AgentBank> AgentBanks { get; set; }
        public virtual DbSet<Facility> Facilities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CUST>()
                .Property(e => e.SectorKey)
                .IsFixedLength();

            modelBuilder.Entity<CUST>()
                .Property(e => e.FinInstGovPercent)
                .HasPrecision(18, 4);

            modelBuilder.Entity<CUST>()
                .HasMany(e => e.KYCGeoRiskLinkTemps)
                .WithOptional(e => e.CUST)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CUST>()
                .HasMany(e => e.KYCLinkRisks)
                .WithOptional(e => e.CUST)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CUST>()
                .HasMany(e => e.KYCLinkRiskTemps)
                .WithOptional(e => e.CUST)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CustPipelineFacility>()
                .HasMany(e => e.CustPipelineFacilityDetails)
                .WithOptional(e => e.CustPipelineFacility)
                .HasForeignKey(e => e.FacilityID)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CUSTUniversal>()
                .HasMany(e => e.CCFs)
                .WithRequired(e => e.CUSTUniversal)
                .HasForeignKey(e => e.CustID);

            modelBuilder.Entity<CUSTUniversal>()
                .HasOptional(e => e.CUST)
                .WithRequired(e => e.CUSTUniversal)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CUSTUniversal>()
                .HasOptional(e => e.CUSTDetail)
                .WithRequired(e => e.CUSTUniversal)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CUSTUniversal>()
                .HasMany(e => e.CustPipelines)
                .WithRequired(e => e.CUSTUniversal)
                .HasForeignKey(e => e.CustID);

            modelBuilder.Entity<CUSTUniversal>()
                .HasMany(e => e.CustPipelineBookingStatus)
                .WithOptional(e => e.CUSTUniversal)
                .HasForeignKey(e => e.CustID)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CUSTUniversal>()
                .HasMany(e => e.CustPipelineComments)
                .WithRequired(e => e.CUSTUniversal)
                .HasForeignKey(e => e.CustID);

            modelBuilder.Entity<CUSTUniversal>()
                .HasMany(e => e.CustPipelineDecisionHistories)
                .WithRequired(e => e.CUSTUniversal)
                .HasForeignKey(e => e.CustID);

            modelBuilder.Entity<CUSTUniversal>()
                .HasMany(e => e.CustPipelineFacilities)
                .WithRequired(e => e.CUSTUniversal)
                .HasForeignKey(e => e.CustID);

            modelBuilder.Entity<CUSTUniversal>()
                .HasMany(e => e.CustPipelineLinkeds)
                .WithOptional(e => e.CUSTUniversal)
                .HasForeignKey(e => e.CustID)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CUSTUniversal>()
                .HasMany(e => e.ReferenceExternalAccts)
                .WithOptional(e => e.CUSTUniversal)
                .HasForeignKey(e => e.AcctID)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CUSTUniversal>()
                .HasMany(e => e.ReferenceInternalAccts)
                .WithOptional(e => e.CUSTUniversal)
                .HasForeignKey(e => e.AcctID)
                .WillCascadeOnDelete();



            modelBuilder.Entity<KYCStaticRisk>()
                .HasMany(e => e.KYCLinkRisks)
                .WithOptional(e => e.KYCStaticRisk)
                .HasForeignKey(e => e.RiskID);
        }

    }
}
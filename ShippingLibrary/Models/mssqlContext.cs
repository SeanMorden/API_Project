using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ShippingLibrary.Models
{
    public partial class mssqlContext : DbContext
    {
        public mssqlContext()
        {
        }

        public mssqlContext(DbContextOptions<mssqlContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DomesticExpedited> DomesticExpediteds { get; set; }
        public virtual DbSet<DomesticExpress> DomesticExpresses { get; set; }
        public virtual DbSet<DomesticExpressEarly> DomesticExpressEarlies { get; set; }
        public virtual DbSet<DomesticExpressSaver> DomesticExpressSavers { get; set; }
        public virtual DbSet<DomesticStandard> DomesticStandards { get; set; }
        public virtual DbSet<ProvinceCode> ProvinceCodes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<DomesticExpedited>(entity =>
            {
                entity.HasKey(e => e.ZoneId)
                    .HasName("PK__Domestic__80B401DF7A2EDE3D");

                entity.ToTable("DomesticExpedited");

                entity.Property(e => e.ZoneId)
                    .ValueGeneratedNever()
                    .HasColumnName("zone_id");

                entity.Property(e => e.W100lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_100lbs");

                entity.Property(e => e.W101lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_101lbs");

                entity.Property(e => e.W102lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_102lbs");

                entity.Property(e => e.W103lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_103lbs");

                entity.Property(e => e.W104lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_104lbs");

                entity.Property(e => e.W105lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_105lbs");

                entity.Property(e => e.W106lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_106lbs");

                entity.Property(e => e.W107lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_107lbs");

                entity.Property(e => e.W108lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_108lbs");

                entity.Property(e => e.W109lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_109lbs");

                entity.Property(e => e.W10lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_10lbs");

                entity.Property(e => e.W110lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_110lbs");

                entity.Property(e => e.W111lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_111lbs");

                entity.Property(e => e.W112lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_112lbs");

                entity.Property(e => e.W113lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_113lbs");

                entity.Property(e => e.W114lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_114lbs");

                entity.Property(e => e.W115lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_115lbs");

                entity.Property(e => e.W116lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_116lbs");

                entity.Property(e => e.W117lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_117lbs");

                entity.Property(e => e.W118lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_118lbs");

                entity.Property(e => e.W119lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_119lbs");

                entity.Property(e => e.W11lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_11lbs");

                entity.Property(e => e.W120lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_120lbs");

                entity.Property(e => e.W121lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_121lbs");

                entity.Property(e => e.W122lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_122lbs");

                entity.Property(e => e.W123lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_123lbs");

                entity.Property(e => e.W124lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_124lbs");

                entity.Property(e => e.W125lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_125lbs");

                entity.Property(e => e.W126lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_126lbs");

                entity.Property(e => e.W127lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_127lbs");

                entity.Property(e => e.W128lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_128lbs");

                entity.Property(e => e.W129lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_129lbs");

                entity.Property(e => e.W12lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_12lbs");

                entity.Property(e => e.W130lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_130lbs");

                entity.Property(e => e.W131lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_131lbs");

                entity.Property(e => e.W132lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_132lbs");

                entity.Property(e => e.W133lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_133lbs");

                entity.Property(e => e.W134lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_134lbs");

                entity.Property(e => e.W135lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_135lbs");

                entity.Property(e => e.W136lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_136lbs");

                entity.Property(e => e.W137lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_137lbs");

                entity.Property(e => e.W138lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_138lbs");

                entity.Property(e => e.W139lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_139lbs");

                entity.Property(e => e.W13lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_13lbs");

                entity.Property(e => e.W140lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_140lbs");

                entity.Property(e => e.W141lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_141lbs");

                entity.Property(e => e.W142lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_142lbs");

                entity.Property(e => e.W143lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_143lbs");

                entity.Property(e => e.W144lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_144lbs");

                entity.Property(e => e.W145lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_145lbs");

                entity.Property(e => e.W146lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_146lbs");

                entity.Property(e => e.W147lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_147lbs");

                entity.Property(e => e.W148lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_148lbs");

                entity.Property(e => e.W149lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_149lbs");

                entity.Property(e => e.W14lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_14lbs");

                entity.Property(e => e.W150lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_150lbs");

                entity.Property(e => e.W15lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_15lbs");

                entity.Property(e => e.W16lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_16lbs");

                entity.Property(e => e.W17lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_17lbs");

                entity.Property(e => e.W18lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_18lbs");

                entity.Property(e => e.W19lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_19lbs");

                entity.Property(e => e.W1lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_1lbs");

                entity.Property(e => e.W20lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_20lbs");

                entity.Property(e => e.W21lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_21lbs");

                entity.Property(e => e.W22lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_22lbs");

                entity.Property(e => e.W23lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_23lbs");

                entity.Property(e => e.W24lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_24lbs");

                entity.Property(e => e.W25lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_25lbs");

                entity.Property(e => e.W26lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_26lbs");

                entity.Property(e => e.W27lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_27lbs");

                entity.Property(e => e.W28lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_28lbs");

                entity.Property(e => e.W29lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_29lbs");

                entity.Property(e => e.W2lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_2lbs");

                entity.Property(e => e.W30lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_30lbs");

                entity.Property(e => e.W31lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_31lbs");

                entity.Property(e => e.W32lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_32lbs");

                entity.Property(e => e.W33lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_33lbs");

                entity.Property(e => e.W34lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_34lbs");

                entity.Property(e => e.W35lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_35lbs");

                entity.Property(e => e.W36lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_36lbs");

                entity.Property(e => e.W37lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_37lbs");

                entity.Property(e => e.W38lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_38lbs");

                entity.Property(e => e.W39lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_39lbs");

                entity.Property(e => e.W3lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_3lbs");

                entity.Property(e => e.W40lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_40lbs");

                entity.Property(e => e.W41lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_41lbs");

                entity.Property(e => e.W42lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_42lbs");

                entity.Property(e => e.W43lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_43lbs");

                entity.Property(e => e.W44lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_44lbs");

                entity.Property(e => e.W45lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_45lbs");

                entity.Property(e => e.W46lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_46lbs");

                entity.Property(e => e.W47lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_47lbs");

                entity.Property(e => e.W48lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_48lbs");

                entity.Property(e => e.W49lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_49lbs");

                entity.Property(e => e.W4lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_4lbs");

                entity.Property(e => e.W50lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_50lbs");

                entity.Property(e => e.W51lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_51lbs");

                entity.Property(e => e.W52lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_52lbs");

                entity.Property(e => e.W53lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_53lbs");

                entity.Property(e => e.W54lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_54lbs");

                entity.Property(e => e.W55lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_55lbs");

                entity.Property(e => e.W56lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_56lbs");

                entity.Property(e => e.W57lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_57lbs");

                entity.Property(e => e.W58lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_58lbs");

                entity.Property(e => e.W59lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_59lbs");

                entity.Property(e => e.W5lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_5lbs");

                entity.Property(e => e.W60lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_60lbs");

                entity.Property(e => e.W61lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_61lbs");

                entity.Property(e => e.W62lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_62lbs");

                entity.Property(e => e.W63lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_63lbs");

                entity.Property(e => e.W64lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_64lbs");

                entity.Property(e => e.W65lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_65lbs");

                entity.Property(e => e.W66lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_66lbs");

                entity.Property(e => e.W67lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_67lbs");

                entity.Property(e => e.W68lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_68lbs");

                entity.Property(e => e.W69lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_69lbs");

                entity.Property(e => e.W6lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_6lbs");

                entity.Property(e => e.W70lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_70lbs");

                entity.Property(e => e.W71lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_71lbs");

                entity.Property(e => e.W72lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_72lbs");

                entity.Property(e => e.W73lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_73lbs");

                entity.Property(e => e.W74lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_74lbs");

                entity.Property(e => e.W75lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_75lbs");

                entity.Property(e => e.W76lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_76lbs");

                entity.Property(e => e.W77lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_77lbs");

                entity.Property(e => e.W78lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_78lbs");

                entity.Property(e => e.W79lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_79lbs");

                entity.Property(e => e.W7lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_7lbs");

                entity.Property(e => e.W80lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_80lbs");

                entity.Property(e => e.W81lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_81lbs");

                entity.Property(e => e.W82lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_82lbs");

                entity.Property(e => e.W83lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_83lbs");

                entity.Property(e => e.W84lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_84lbs");

                entity.Property(e => e.W85lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_85lbs");

                entity.Property(e => e.W86lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_86lbs");

                entity.Property(e => e.W87lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_87lbs");

                entity.Property(e => e.W88lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_88lbs");

                entity.Property(e => e.W89lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_89lbs");

                entity.Property(e => e.W8lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_8lbs");

                entity.Property(e => e.W90lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_90lbs");

                entity.Property(e => e.W91lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_91lbs");

                entity.Property(e => e.W92lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_92lbs");

                entity.Property(e => e.W93lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_93lbs");

                entity.Property(e => e.W94lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_94lbs");

                entity.Property(e => e.W95lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_95lbs");

                entity.Property(e => e.W96lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_96lbs");

                entity.Property(e => e.W97lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_97lbs");

                entity.Property(e => e.W98lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_98lbs");

                entity.Property(e => e.W99lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_99lbs");

                entity.Property(e => e.W9lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_9lbs");
            });

            modelBuilder.Entity<DomesticExpress>(entity =>
            {
                entity.HasKey(e => e.ZoneId)
                    .HasName("PK__Domestic__80B401DF46628C93");

                entity.ToTable("DomesticExpress");

                entity.Property(e => e.ZoneId)
                    .ValueGeneratedNever()
                    .HasColumnName("zone_id");

                entity.Property(e => e.W100lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_100lbs");

                entity.Property(e => e.W101lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_101lbs");

                entity.Property(e => e.W102lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_102lbs");

                entity.Property(e => e.W103lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_103lbs");

                entity.Property(e => e.W104lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_104lbs");

                entity.Property(e => e.W105lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_105lbs");

                entity.Property(e => e.W106lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_106lbs");

                entity.Property(e => e.W107lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_107lbs");

                entity.Property(e => e.W108lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_108lbs");

                entity.Property(e => e.W109lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_109lbs");

                entity.Property(e => e.W10lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_10lbs");

                entity.Property(e => e.W110lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_110lbs");

                entity.Property(e => e.W111lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_111lbs");

                entity.Property(e => e.W112lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_112lbs");

                entity.Property(e => e.W113lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_113lbs");

                entity.Property(e => e.W114lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_114lbs");

                entity.Property(e => e.W115lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_115lbs");

                entity.Property(e => e.W116lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_116lbs");

                entity.Property(e => e.W117lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_117lbs");

                entity.Property(e => e.W118lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_118lbs");

                entity.Property(e => e.W119lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_119lbs");

                entity.Property(e => e.W11lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_11lbs");

                entity.Property(e => e.W120lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_120lbs");

                entity.Property(e => e.W121lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_121lbs");

                entity.Property(e => e.W122lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_122lbs");

                entity.Property(e => e.W123lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_123lbs");

                entity.Property(e => e.W124lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_124lbs");

                entity.Property(e => e.W125lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_125lbs");

                entity.Property(e => e.W126lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_126lbs");

                entity.Property(e => e.W127lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_127lbs");

                entity.Property(e => e.W128lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_128lbs");

                entity.Property(e => e.W129lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_129lbs");

                entity.Property(e => e.W12lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_12lbs");

                entity.Property(e => e.W130lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_130lbs");

                entity.Property(e => e.W131lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_131lbs");

                entity.Property(e => e.W132lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_132lbs");

                entity.Property(e => e.W133lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_133lbs");

                entity.Property(e => e.W134lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_134lbs");

                entity.Property(e => e.W135lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_135lbs");

                entity.Property(e => e.W136lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_136lbs");

                entity.Property(e => e.W137lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_137lbs");

                entity.Property(e => e.W138lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_138lbs");

                entity.Property(e => e.W139lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_139lbs");

                entity.Property(e => e.W13lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_13lbs");

                entity.Property(e => e.W140lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_140lbs");

                entity.Property(e => e.W141lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_141lbs");

                entity.Property(e => e.W142lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_142lbs");

                entity.Property(e => e.W143lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_143lbs");

                entity.Property(e => e.W144lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_144lbs");

                entity.Property(e => e.W145lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_145lbs");

                entity.Property(e => e.W146lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_146lbs");

                entity.Property(e => e.W147lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_147lbs");

                entity.Property(e => e.W148lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_148lbs");

                entity.Property(e => e.W149lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_149lbs");

                entity.Property(e => e.W14lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_14lbs");

                entity.Property(e => e.W150lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_150lbs");

                entity.Property(e => e.W15lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_15lbs");

                entity.Property(e => e.W16lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_16lbs");

                entity.Property(e => e.W17lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_17lbs");

                entity.Property(e => e.W18lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_18lbs");

                entity.Property(e => e.W19lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_19lbs");

                entity.Property(e => e.W1lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_1lbs");

                entity.Property(e => e.W20lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_20lbs");

                entity.Property(e => e.W21lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_21lbs");

                entity.Property(e => e.W22lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_22lbs");

                entity.Property(e => e.W23lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_23lbs");

                entity.Property(e => e.W24lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_24lbs");

                entity.Property(e => e.W25lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_25lbs");

                entity.Property(e => e.W26lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_26lbs");

                entity.Property(e => e.W27lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_27lbs");

                entity.Property(e => e.W28lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_28lbs");

                entity.Property(e => e.W29lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_29lbs");

                entity.Property(e => e.W2lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_2lbs");

                entity.Property(e => e.W30lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_30lbs");

                entity.Property(e => e.W31lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_31lbs");

                entity.Property(e => e.W32lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_32lbs");

                entity.Property(e => e.W33lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_33lbs");

                entity.Property(e => e.W34lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_34lbs");

                entity.Property(e => e.W35lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_35lbs");

                entity.Property(e => e.W36lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_36lbs");

                entity.Property(e => e.W37lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_37lbs");

                entity.Property(e => e.W38lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_38lbs");

                entity.Property(e => e.W39lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_39lbs");

                entity.Property(e => e.W3lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_3lbs");

                entity.Property(e => e.W40lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_40lbs");

                entity.Property(e => e.W41lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_41lbs");

                entity.Property(e => e.W42lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_42lbs");

                entity.Property(e => e.W43lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_43lbs");

                entity.Property(e => e.W44lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_44lbs");

                entity.Property(e => e.W45lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_45lbs");

                entity.Property(e => e.W46lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_46lbs");

                entity.Property(e => e.W47lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_47lbs");

                entity.Property(e => e.W48lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_48lbs");

                entity.Property(e => e.W49lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_49lbs");

                entity.Property(e => e.W4lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_4lbs");

                entity.Property(e => e.W50lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_50lbs");

                entity.Property(e => e.W51lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_51lbs");

                entity.Property(e => e.W52lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_52lbs");

                entity.Property(e => e.W53lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_53lbs");

                entity.Property(e => e.W54lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_54lbs");

                entity.Property(e => e.W55lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_55lbs");

                entity.Property(e => e.W56lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_56lbs");

                entity.Property(e => e.W57lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_57lbs");

                entity.Property(e => e.W58lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_58lbs");

                entity.Property(e => e.W59lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_59lbs");

                entity.Property(e => e.W5lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_5lbs");

                entity.Property(e => e.W60lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_60lbs");

                entity.Property(e => e.W61lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_61lbs");

                entity.Property(e => e.W62lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_62lbs");

                entity.Property(e => e.W63lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_63lbs");

                entity.Property(e => e.W64lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_64lbs");

                entity.Property(e => e.W65lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_65lbs");

                entity.Property(e => e.W66lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_66lbs");

                entity.Property(e => e.W67lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_67lbs");

                entity.Property(e => e.W68lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_68lbs");

                entity.Property(e => e.W69lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_69lbs");

                entity.Property(e => e.W6lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_6lbs");

                entity.Property(e => e.W70lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_70lbs");

                entity.Property(e => e.W71lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_71lbs");

                entity.Property(e => e.W72lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_72lbs");

                entity.Property(e => e.W73lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_73lbs");

                entity.Property(e => e.W74lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_74lbs");

                entity.Property(e => e.W75lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_75lbs");

                entity.Property(e => e.W76lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_76lbs");

                entity.Property(e => e.W77lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_77lbs");

                entity.Property(e => e.W78lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_78lbs");

                entity.Property(e => e.W79lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_79lbs");

                entity.Property(e => e.W7lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_7lbs");

                entity.Property(e => e.W80lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_80lbs");

                entity.Property(e => e.W81lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_81lbs");

                entity.Property(e => e.W82lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_82lbs");

                entity.Property(e => e.W83lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_83lbs");

                entity.Property(e => e.W84lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_84lbs");

                entity.Property(e => e.W85lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_85lbs");

                entity.Property(e => e.W86lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_86lbs");

                entity.Property(e => e.W87lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_87lbs");

                entity.Property(e => e.W88lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_88lbs");

                entity.Property(e => e.W89lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_89lbs");

                entity.Property(e => e.W8lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_8lbs");

                entity.Property(e => e.W90lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_90lbs");

                entity.Property(e => e.W91lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_91lbs");

                entity.Property(e => e.W92lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_92lbs");

                entity.Property(e => e.W93lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_93lbs");

                entity.Property(e => e.W94lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_94lbs");

                entity.Property(e => e.W95lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_95lbs");

                entity.Property(e => e.W96lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_96lbs");

                entity.Property(e => e.W97lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_97lbs");

                entity.Property(e => e.W98lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_98lbs");

                entity.Property(e => e.W99lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_99lbs");

                entity.Property(e => e.W9lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_9lbs");
            });

            modelBuilder.Entity<DomesticExpressEarly>(entity =>
            {
                entity.HasKey(e => e.ZoneId)
                    .HasName("PK__Domestic__80B401DF23293BB2");

                entity.ToTable("DomesticExpressEarly");

                entity.Property(e => e.ZoneId)
                    .ValueGeneratedNever()
                    .HasColumnName("zone_id");

                entity.Property(e => e.W100lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_100lbs");

                entity.Property(e => e.W101lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_101lbs");

                entity.Property(e => e.W102lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_102lbs");

                entity.Property(e => e.W103lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_103lbs");

                entity.Property(e => e.W104lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_104lbs");

                entity.Property(e => e.W105lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_105lbs");

                entity.Property(e => e.W106lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_106lbs");

                entity.Property(e => e.W107lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_107lbs");

                entity.Property(e => e.W108lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_108lbs");

                entity.Property(e => e.W109lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_109lbs");

                entity.Property(e => e.W10lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_10lbs");

                entity.Property(e => e.W110lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_110lbs");

                entity.Property(e => e.W111lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_111lbs");

                entity.Property(e => e.W112lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_112lbs");

                entity.Property(e => e.W113lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_113lbs");

                entity.Property(e => e.W114lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_114lbs");

                entity.Property(e => e.W115lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_115lbs");

                entity.Property(e => e.W116lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_116lbs");

                entity.Property(e => e.W117lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_117lbs");

                entity.Property(e => e.W118lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_118lbs");

                entity.Property(e => e.W119lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_119lbs");

                entity.Property(e => e.W11lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_11lbs");

                entity.Property(e => e.W120lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_120lbs");

                entity.Property(e => e.W121lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_121lbs");

                entity.Property(e => e.W122lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_122lbs");

                entity.Property(e => e.W123lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_123lbs");

                entity.Property(e => e.W124lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_124lbs");

                entity.Property(e => e.W125lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_125lbs");

                entity.Property(e => e.W126lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_126lbs");

                entity.Property(e => e.W127lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_127lbs");

                entity.Property(e => e.W128lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_128lbs");

                entity.Property(e => e.W129lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_129lbs");

                entity.Property(e => e.W12lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_12lbs");

                entity.Property(e => e.W130lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_130lbs");

                entity.Property(e => e.W131lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_131lbs");

                entity.Property(e => e.W132lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_132lbs");

                entity.Property(e => e.W133lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_133lbs");

                entity.Property(e => e.W134lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_134lbs");

                entity.Property(e => e.W135lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_135lbs");

                entity.Property(e => e.W136lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_136lbs");

                entity.Property(e => e.W137lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_137lbs");

                entity.Property(e => e.W138lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_138lbs");

                entity.Property(e => e.W139lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_139lbs");

                entity.Property(e => e.W13lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_13lbs");

                entity.Property(e => e.W140lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_140lbs");

                entity.Property(e => e.W141lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_141lbs");

                entity.Property(e => e.W142lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_142lbs");

                entity.Property(e => e.W143lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_143lbs");

                entity.Property(e => e.W144lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_144lbs");

                entity.Property(e => e.W145lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_145lbs");

                entity.Property(e => e.W146lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_146lbs");

                entity.Property(e => e.W147lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_147lbs");

                entity.Property(e => e.W148lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_148lbs");

                entity.Property(e => e.W149lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_149lbs");

                entity.Property(e => e.W14lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_14lbs");

                entity.Property(e => e.W150lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_150lbs");

                entity.Property(e => e.W15lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_15lbs");

                entity.Property(e => e.W16lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_16lbs");

                entity.Property(e => e.W17lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_17lbs");

                entity.Property(e => e.W18lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_18lbs");

                entity.Property(e => e.W19lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_19lbs");

                entity.Property(e => e.W1lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_1lbs");

                entity.Property(e => e.W20lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_20lbs");

                entity.Property(e => e.W21lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_21lbs");

                entity.Property(e => e.W22lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_22lbs");

                entity.Property(e => e.W23lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_23lbs");

                entity.Property(e => e.W24lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_24lbs");

                entity.Property(e => e.W25lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_25lbs");

                entity.Property(e => e.W26lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_26lbs");

                entity.Property(e => e.W27lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_27lbs");

                entity.Property(e => e.W28lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_28lbs");

                entity.Property(e => e.W29lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_29lbs");

                entity.Property(e => e.W2lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_2lbs");

                entity.Property(e => e.W30lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_30lbs");

                entity.Property(e => e.W31lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_31lbs");

                entity.Property(e => e.W32lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_32lbs");

                entity.Property(e => e.W33lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_33lbs");

                entity.Property(e => e.W34lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_34lbs");

                entity.Property(e => e.W35lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_35lbs");

                entity.Property(e => e.W36lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_36lbs");

                entity.Property(e => e.W37lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_37lbs");

                entity.Property(e => e.W38lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_38lbs");

                entity.Property(e => e.W39lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_39lbs");

                entity.Property(e => e.W3lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_3lbs");

                entity.Property(e => e.W40lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_40lbs");

                entity.Property(e => e.W41lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_41lbs");

                entity.Property(e => e.W42lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_42lbs");

                entity.Property(e => e.W43lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_43lbs");

                entity.Property(e => e.W44lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_44lbs");

                entity.Property(e => e.W45lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_45lbs");

                entity.Property(e => e.W46lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_46lbs");

                entity.Property(e => e.W47lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_47lbs");

                entity.Property(e => e.W48lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_48lbs");

                entity.Property(e => e.W49lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_49lbs");

                entity.Property(e => e.W4lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_4lbs");

                entity.Property(e => e.W50lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_50lbs");

                entity.Property(e => e.W51lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_51lbs");

                entity.Property(e => e.W52lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_52lbs");

                entity.Property(e => e.W53lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_53lbs");

                entity.Property(e => e.W54lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_54lbs");

                entity.Property(e => e.W55lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_55lbs");

                entity.Property(e => e.W56lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_56lbs");

                entity.Property(e => e.W57lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_57lbs");

                entity.Property(e => e.W58lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_58lbs");

                entity.Property(e => e.W59lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_59lbs");

                entity.Property(e => e.W5lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_5lbs");

                entity.Property(e => e.W60lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_60lbs");

                entity.Property(e => e.W61lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_61lbs");

                entity.Property(e => e.W62lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_62lbs");

                entity.Property(e => e.W63lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_63lbs");

                entity.Property(e => e.W64lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_64lbs");

                entity.Property(e => e.W65lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_65lbs");

                entity.Property(e => e.W66lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_66lbs");

                entity.Property(e => e.W67lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_67lbs");

                entity.Property(e => e.W68lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_68lbs");

                entity.Property(e => e.W69lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_69lbs");

                entity.Property(e => e.W6lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_6lbs");

                entity.Property(e => e.W70lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_70lbs");

                entity.Property(e => e.W71lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_71lbs");

                entity.Property(e => e.W72lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_72lbs");

                entity.Property(e => e.W73lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_73lbs");

                entity.Property(e => e.W74lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_74lbs");

                entity.Property(e => e.W75lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_75lbs");

                entity.Property(e => e.W76lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_76lbs");

                entity.Property(e => e.W77lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_77lbs");

                entity.Property(e => e.W78lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_78lbs");

                entity.Property(e => e.W79lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_79lbs");

                entity.Property(e => e.W7lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_7lbs");

                entity.Property(e => e.W80lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_80lbs");

                entity.Property(e => e.W81lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_81lbs");

                entity.Property(e => e.W82lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_82lbs");

                entity.Property(e => e.W83lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_83lbs");

                entity.Property(e => e.W84lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_84lbs");

                entity.Property(e => e.W85lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_85lbs");

                entity.Property(e => e.W86lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_86lbs");

                entity.Property(e => e.W87lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_87lbs");

                entity.Property(e => e.W88lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_88lbs");

                entity.Property(e => e.W89lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_89lbs");

                entity.Property(e => e.W8lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_8lbs");

                entity.Property(e => e.W90lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_90lbs");

                entity.Property(e => e.W91lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_91lbs");

                entity.Property(e => e.W92lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_92lbs");

                entity.Property(e => e.W93lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_93lbs");

                entity.Property(e => e.W94lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_94lbs");

                entity.Property(e => e.W95lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_95lbs");

                entity.Property(e => e.W96lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_96lbs");

                entity.Property(e => e.W97lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_97lbs");

                entity.Property(e => e.W98lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_98lbs");

                entity.Property(e => e.W99lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_99lbs");

                entity.Property(e => e.W9lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_9lbs");
            });

            modelBuilder.Entity<DomesticExpressSaver>(entity =>
            {
                entity.HasKey(e => e.ZoneId)
                    .HasName("PK__Domestic__80B401DF058C6DD6");

                entity.ToTable("DomesticExpressSaver");

                entity.Property(e => e.ZoneId)
                    .ValueGeneratedNever()
                    .HasColumnName("zone_id");

                entity.Property(e => e.W100lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_100lbs");

                entity.Property(e => e.W101lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_101lbs");

                entity.Property(e => e.W102lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_102lbs");

                entity.Property(e => e.W103lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_103lbs");

                entity.Property(e => e.W104lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_104lbs");

                entity.Property(e => e.W105lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_105lbs");

                entity.Property(e => e.W106lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_106lbs");

                entity.Property(e => e.W107lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_107lbs");

                entity.Property(e => e.W108lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_108lbs");

                entity.Property(e => e.W109lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_109lbs");

                entity.Property(e => e.W10lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_10lbs");

                entity.Property(e => e.W110lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_110lbs");

                entity.Property(e => e.W111lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_111lbs");

                entity.Property(e => e.W112lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_112lbs");

                entity.Property(e => e.W113lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_113lbs");

                entity.Property(e => e.W114lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_114lbs");

                entity.Property(e => e.W115lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_115lbs");

                entity.Property(e => e.W116lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_116lbs");

                entity.Property(e => e.W117lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_117lbs");

                entity.Property(e => e.W118lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_118lbs");

                entity.Property(e => e.W119lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_119lbs");

                entity.Property(e => e.W11lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_11lbs");

                entity.Property(e => e.W120lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_120lbs");

                entity.Property(e => e.W121lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_121lbs");

                entity.Property(e => e.W122lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_122lbs");

                entity.Property(e => e.W123lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_123lbs");

                entity.Property(e => e.W124lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_124lbs");

                entity.Property(e => e.W125lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_125lbs");

                entity.Property(e => e.W126lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_126lbs");

                entity.Property(e => e.W127lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_127lbs");

                entity.Property(e => e.W128lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_128lbs");

                entity.Property(e => e.W129lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_129lbs");

                entity.Property(e => e.W12lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_12lbs");

                entity.Property(e => e.W130lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_130lbs");

                entity.Property(e => e.W131lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_131lbs");

                entity.Property(e => e.W132lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_132lbs");

                entity.Property(e => e.W133lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_133lbs");

                entity.Property(e => e.W134lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_134lbs");

                entity.Property(e => e.W135lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_135lbs");

                entity.Property(e => e.W136lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_136lbs");

                entity.Property(e => e.W137lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_137lbs");

                entity.Property(e => e.W138lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_138lbs");

                entity.Property(e => e.W139lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_139lbs");

                entity.Property(e => e.W13lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_13lbs");

                entity.Property(e => e.W140lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_140lbs");

                entity.Property(e => e.W141lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_141lbs");

                entity.Property(e => e.W142lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_142lbs");

                entity.Property(e => e.W143lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_143lbs");

                entity.Property(e => e.W144lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_144lbs");

                entity.Property(e => e.W145lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_145lbs");

                entity.Property(e => e.W146lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_146lbs");

                entity.Property(e => e.W147lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_147lbs");

                entity.Property(e => e.W148lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_148lbs");

                entity.Property(e => e.W149lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_149lbs");

                entity.Property(e => e.W14lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_14lbs");

                entity.Property(e => e.W150lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_150lbs");

                entity.Property(e => e.W15lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_15lbs");

                entity.Property(e => e.W16lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_16lbs");

                entity.Property(e => e.W17lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_17lbs");

                entity.Property(e => e.W18lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_18lbs");

                entity.Property(e => e.W19lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_19lbs");

                entity.Property(e => e.W1lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_1lbs");

                entity.Property(e => e.W20lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_20lbs");

                entity.Property(e => e.W21lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_21lbs");

                entity.Property(e => e.W22lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_22lbs");

                entity.Property(e => e.W23lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_23lbs");

                entity.Property(e => e.W24lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_24lbs");

                entity.Property(e => e.W25lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_25lbs");

                entity.Property(e => e.W26lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_26lbs");

                entity.Property(e => e.W27lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_27lbs");

                entity.Property(e => e.W28lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_28lbs");

                entity.Property(e => e.W29lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_29lbs");

                entity.Property(e => e.W2lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_2lbs");

                entity.Property(e => e.W30lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_30lbs");

                entity.Property(e => e.W31lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_31lbs");

                entity.Property(e => e.W32lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_32lbs");

                entity.Property(e => e.W33lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_33lbs");

                entity.Property(e => e.W34lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_34lbs");

                entity.Property(e => e.W35lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_35lbs");

                entity.Property(e => e.W36lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_36lbs");

                entity.Property(e => e.W37lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_37lbs");

                entity.Property(e => e.W38lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_38lbs");

                entity.Property(e => e.W39lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_39lbs");

                entity.Property(e => e.W3lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_3lbs");

                entity.Property(e => e.W40lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_40lbs");

                entity.Property(e => e.W41lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_41lbs");

                entity.Property(e => e.W42lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_42lbs");

                entity.Property(e => e.W43lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_43lbs");

                entity.Property(e => e.W44lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_44lbs");

                entity.Property(e => e.W45lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_45lbs");

                entity.Property(e => e.W46lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_46lbs");

                entity.Property(e => e.W47lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_47lbs");

                entity.Property(e => e.W48lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_48lbs");

                entity.Property(e => e.W49lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_49lbs");

                entity.Property(e => e.W4lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_4lbs");

                entity.Property(e => e.W50lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_50lbs");

                entity.Property(e => e.W51lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_51lbs");

                entity.Property(e => e.W52lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_52lbs");

                entity.Property(e => e.W53lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_53lbs");

                entity.Property(e => e.W54lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_54lbs");

                entity.Property(e => e.W55lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_55lbs");

                entity.Property(e => e.W56lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_56lbs");

                entity.Property(e => e.W57lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_57lbs");

                entity.Property(e => e.W58lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_58lbs");

                entity.Property(e => e.W59lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_59lbs");

                entity.Property(e => e.W5lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_5lbs");

                entity.Property(e => e.W60lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_60lbs");

                entity.Property(e => e.W61lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_61lbs");

                entity.Property(e => e.W62lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_62lbs");

                entity.Property(e => e.W63lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_63lbs");

                entity.Property(e => e.W64lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_64lbs");

                entity.Property(e => e.W65lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_65lbs");

                entity.Property(e => e.W66lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_66lbs");

                entity.Property(e => e.W67lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_67lbs");

                entity.Property(e => e.W68lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_68lbs");

                entity.Property(e => e.W69lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_69lbs");

                entity.Property(e => e.W6lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_6lbs");

                entity.Property(e => e.W70lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_70lbs");

                entity.Property(e => e.W71lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_71lbs");

                entity.Property(e => e.W72lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_72lbs");

                entity.Property(e => e.W73lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_73lbs");

                entity.Property(e => e.W74lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_74lbs");

                entity.Property(e => e.W75lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_75lbs");

                entity.Property(e => e.W76lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_76lbs");

                entity.Property(e => e.W77lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_77lbs");

                entity.Property(e => e.W78lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_78lbs");

                entity.Property(e => e.W79lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_79lbs");

                entity.Property(e => e.W7lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_7lbs");

                entity.Property(e => e.W80lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_80lbs");

                entity.Property(e => e.W81lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_81lbs");

                entity.Property(e => e.W82lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_82lbs");

                entity.Property(e => e.W83lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_83lbs");

                entity.Property(e => e.W84lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_84lbs");

                entity.Property(e => e.W85lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_85lbs");

                entity.Property(e => e.W86lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_86lbs");

                entity.Property(e => e.W87lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_87lbs");

                entity.Property(e => e.W88lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_88lbs");

                entity.Property(e => e.W89lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_89lbs");

                entity.Property(e => e.W8lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_8lbs");

                entity.Property(e => e.W90lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_90lbs");

                entity.Property(e => e.W91lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_91lbs");

                entity.Property(e => e.W92lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_92lbs");

                entity.Property(e => e.W93lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_93lbs");

                entity.Property(e => e.W94lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_94lbs");

                entity.Property(e => e.W95lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_95lbs");

                entity.Property(e => e.W96lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_96lbs");

                entity.Property(e => e.W97lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_97lbs");

                entity.Property(e => e.W98lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_98lbs");

                entity.Property(e => e.W99lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_99lbs");

                entity.Property(e => e.W9lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_9lbs");
            });

            modelBuilder.Entity<DomesticStandard>(entity =>
            {
                entity.HasKey(e => e.ZoneId)
                    .HasName("PK__Domestic__80B401DFDB8EBCF1");

                entity.ToTable("DomesticStandard");

                entity.Property(e => e.ZoneId)
                    .ValueGeneratedNever()
                    .HasColumnName("zone_id");

                entity.Property(e => e.W100lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_100lbs");

                entity.Property(e => e.W101lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_101lbs");

                entity.Property(e => e.W102lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_102lbs");

                entity.Property(e => e.W103lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_103lbs");

                entity.Property(e => e.W104lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_104lbs");

                entity.Property(e => e.W105lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_105lbs");

                entity.Property(e => e.W106lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_106lbs");

                entity.Property(e => e.W107lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_107lbs");

                entity.Property(e => e.W108lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_108lbs");

                entity.Property(e => e.W109lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_109lbs");

                entity.Property(e => e.W10lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_10lbs");

                entity.Property(e => e.W110lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_110lbs");

                entity.Property(e => e.W111lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_111lbs");

                entity.Property(e => e.W112lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_112lbs");

                entity.Property(e => e.W113lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_113lbs");

                entity.Property(e => e.W114lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_114lbs");

                entity.Property(e => e.W115lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_115lbs");

                entity.Property(e => e.W116lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_116lbs");

                entity.Property(e => e.W117lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_117lbs");

                entity.Property(e => e.W118lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_118lbs");

                entity.Property(e => e.W119lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_119lbs");

                entity.Property(e => e.W11lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_11lbs");

                entity.Property(e => e.W120lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_120lbs");

                entity.Property(e => e.W121lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_121lbs");

                entity.Property(e => e.W122lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_122lbs");

                entity.Property(e => e.W123lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_123lbs");

                entity.Property(e => e.W124lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_124lbs");

                entity.Property(e => e.W125lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_125lbs");

                entity.Property(e => e.W126lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_126lbs");

                entity.Property(e => e.W127lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_127lbs");

                entity.Property(e => e.W128lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_128lbs");

                entity.Property(e => e.W129lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_129lbs");

                entity.Property(e => e.W12lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_12lbs");

                entity.Property(e => e.W130lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_130lbs");

                entity.Property(e => e.W131lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_131lbs");

                entity.Property(e => e.W132lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_132lbs");

                entity.Property(e => e.W133lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_133lbs");

                entity.Property(e => e.W134lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_134lbs");

                entity.Property(e => e.W135lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_135lbs");

                entity.Property(e => e.W136lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_136lbs");

                entity.Property(e => e.W137lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_137lbs");

                entity.Property(e => e.W138lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_138lbs");

                entity.Property(e => e.W139lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_139lbs");

                entity.Property(e => e.W13lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_13lbs");

                entity.Property(e => e.W140lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_140lbs");

                entity.Property(e => e.W141lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_141lbs");

                entity.Property(e => e.W142lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_142lbs");

                entity.Property(e => e.W143lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_143lbs");

                entity.Property(e => e.W144lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_144lbs");

                entity.Property(e => e.W145lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_145lbs");

                entity.Property(e => e.W146lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_146lbs");

                entity.Property(e => e.W147lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_147lbs");

                entity.Property(e => e.W148lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_148lbs");

                entity.Property(e => e.W149lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_149lbs");

                entity.Property(e => e.W14lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_14lbs");

                entity.Property(e => e.W150lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_150lbs");

                entity.Property(e => e.W15lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_15lbs");

                entity.Property(e => e.W16lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_16lbs");

                entity.Property(e => e.W17lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_17lbs");

                entity.Property(e => e.W18lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_18lbs");

                entity.Property(e => e.W19lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_19lbs");

                entity.Property(e => e.W1lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_1lbs");

                entity.Property(e => e.W20lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_20lbs");

                entity.Property(e => e.W21lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_21lbs");

                entity.Property(e => e.W22lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_22lbs");

                entity.Property(e => e.W23lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_23lbs");

                entity.Property(e => e.W24lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_24lbs");

                entity.Property(e => e.W25lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_25lbs");

                entity.Property(e => e.W26lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_26lbs");

                entity.Property(e => e.W27lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_27lbs");

                entity.Property(e => e.W28lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_28lbs");

                entity.Property(e => e.W29lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_29lbs");

                entity.Property(e => e.W2lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_2lbs");

                entity.Property(e => e.W30lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_30lbs");

                entity.Property(e => e.W31lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_31lbs");

                entity.Property(e => e.W32lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_32lbs");

                entity.Property(e => e.W33lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_33lbs");

                entity.Property(e => e.W34lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_34lbs");

                entity.Property(e => e.W35lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_35lbs");

                entity.Property(e => e.W36lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_36lbs");

                entity.Property(e => e.W37lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_37lbs");

                entity.Property(e => e.W38lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_38lbs");

                entity.Property(e => e.W39lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_39lbs");

                entity.Property(e => e.W3lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_3lbs");

                entity.Property(e => e.W40lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_40lbs");

                entity.Property(e => e.W41lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_41lbs");

                entity.Property(e => e.W42lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_42lbs");

                entity.Property(e => e.W43lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_43lbs");

                entity.Property(e => e.W44lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_44lbs");

                entity.Property(e => e.W45lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_45lbs");

                entity.Property(e => e.W46lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_46lbs");

                entity.Property(e => e.W47lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_47lbs");

                entity.Property(e => e.W48lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_48lbs");

                entity.Property(e => e.W49lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_49lbs");

                entity.Property(e => e.W4lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_4lbs");

                entity.Property(e => e.W50lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_50lbs");

                entity.Property(e => e.W51lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_51lbs");

                entity.Property(e => e.W52lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_52lbs");

                entity.Property(e => e.W53lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_53lbs");

                entity.Property(e => e.W54lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_54lbs");

                entity.Property(e => e.W55lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_55lbs");

                entity.Property(e => e.W56lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_56lbs");

                entity.Property(e => e.W57lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_57lbs");

                entity.Property(e => e.W58lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_58lbs");

                entity.Property(e => e.W59lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_59lbs");

                entity.Property(e => e.W5lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_5lbs");

                entity.Property(e => e.W60lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_60lbs");

                entity.Property(e => e.W61lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_61lbs");

                entity.Property(e => e.W62lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_62lbs");

                entity.Property(e => e.W63lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_63lbs");

                entity.Property(e => e.W64lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_64lbs");

                entity.Property(e => e.W65lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_65lbs");

                entity.Property(e => e.W66lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_66lbs");

                entity.Property(e => e.W67lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_67lbs");

                entity.Property(e => e.W68lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_68lbs");

                entity.Property(e => e.W69lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_69lbs");

                entity.Property(e => e.W6lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_6lbs");

                entity.Property(e => e.W70lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_70lbs");

                entity.Property(e => e.W71lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_71lbs");

                entity.Property(e => e.W72lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_72lbs");

                entity.Property(e => e.W73lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_73lbs");

                entity.Property(e => e.W74lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_74lbs");

                entity.Property(e => e.W75lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_75lbs");

                entity.Property(e => e.W76lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_76lbs");

                entity.Property(e => e.W77lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_77lbs");

                entity.Property(e => e.W78lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_78lbs");

                entity.Property(e => e.W79lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_79lbs");

                entity.Property(e => e.W7lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_7lbs");

                entity.Property(e => e.W80lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_80lbs");

                entity.Property(e => e.W81lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_81lbs");

                entity.Property(e => e.W82lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_82lbs");

                entity.Property(e => e.W83lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_83lbs");

                entity.Property(e => e.W84lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_84lbs");

                entity.Property(e => e.W85lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_85lbs");

                entity.Property(e => e.W86lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_86lbs");

                entity.Property(e => e.W87lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_87lbs");

                entity.Property(e => e.W88lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_88lbs");

                entity.Property(e => e.W89lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_89lbs");

                entity.Property(e => e.W8lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_8lbs");

                entity.Property(e => e.W90lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_90lbs");

                entity.Property(e => e.W91lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_91lbs");

                entity.Property(e => e.W92lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_92lbs");

                entity.Property(e => e.W93lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_93lbs");

                entity.Property(e => e.W94lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_94lbs");

                entity.Property(e => e.W95lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_95lbs");

                entity.Property(e => e.W96lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_96lbs");

                entity.Property(e => e.W97lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_97lbs");

                entity.Property(e => e.W98lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_98lbs");

                entity.Property(e => e.W99lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_99lbs");

                entity.Property(e => e.W9lbs)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("w_9lbs");
            });

            modelBuilder.Entity<ProvinceCode>(entity =>
            {
                entity.HasKey(e => e.Province)
                    .HasName("PK__Province__9BC8E43BB7EC03BF");

                entity.Property(e => e.Province)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ExpeditedZone).HasColumnName("Expedited_Zone");

                entity.Property(e => e.ExpressEarlyZone).HasColumnName("Express_Early_Zone");

                entity.Property(e => e.ExpressSaverZone).HasColumnName("Express_Saver_Zone");

                entity.Property(e => e.ExpressZone).HasColumnName("Express_Zone");

                entity.Property(e => e.StandardZone).HasColumnName("Standard_Zone");

                entity.HasOne(d => d.ExpeditedZoneNavigation)
                    .WithMany(p => p.ProvinceCodes)
                    .HasForeignKey(d => d.ExpeditedZone)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ProvinceC__Exped__693CA210");

                entity.HasOne(d => d.ExpressEarlyZoneNavigation)
                    .WithMany(p => p.ProvinceCodes)
                    .HasForeignKey(d => d.ExpressEarlyZone)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ProvinceC__Expre__66603565");

                entity.HasOne(d => d.ExpressSaverZoneNavigation)
                    .WithMany(p => p.ProvinceCodes)
                    .HasForeignKey(d => d.ExpressSaverZone)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ProvinceC__Expre__68487DD7");

                entity.HasOne(d => d.ExpressZoneNavigation)
                    .WithMany(p => p.ProvinceCodes)
                    .HasForeignKey(d => d.ExpressZone)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ProvinceC__Expre__6754599E");

                entity.HasOne(d => d.StandardZoneNavigation)
                    .WithMany(p => p.ProvinceCodes)
                    .HasForeignKey(d => d.StandardZone)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ProvinceC__Stand__6A30C649");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

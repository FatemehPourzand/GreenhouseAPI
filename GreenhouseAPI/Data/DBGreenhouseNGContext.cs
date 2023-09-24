using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GreenhouseAPI.Data
{
    public partial class DBGreenhouseNGContext : DbContext
    {
        public DBGreenhouseNGContext()
        {
        }

        public DBGreenhouseNGContext(DbContextOptions<DBGreenhouseNGContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbAccessRole> TbAccessRoles { get; set; } = null!;
        public virtual DbSet<TbAgent> TbAgents { get; set; } = null!;
        public virtual DbSet<TbAlarm> TbAlarms { get; set; } = null!;
        public virtual DbSet<TbAlarmGroup> TbAlarmGroups { get; set; } = null!;
        public virtual DbSet<TbAlarmPriority> TbAlarmPriorities { get; set; } = null!;
        public virtual DbSet<TbAlarmRole> TbAlarmRoles { get; set; } = null!;
        public virtual DbSet<TbAlarmTemplate> TbAlarmTemplates { get; set; } = null!;
        public virtual DbSet<TbArea> TbAreas { get; set; } = null!;
        public virtual DbSet<TbAreaEnvironment> TbAreaEnvironments { get; set; } = null!;
        public virtual DbSet<TbBattery> TbBatteries { get; set; } = null!;
        public virtual DbSet<TbCamera> TbCameras { get; set; } = null!;
        public virtual DbSet<TbCameraImageStorage> TbCameraImageStorages { get; set; } = null!;
        public virtual DbSet<TbCameraMotionDetection> TbCameraMotionDetections { get; set; } = null!;
        public virtual DbSet<TbChainCondition> TbChainConditions { get; set; } = null!;
        public virtual DbSet<TbCondition> TbConditions { get; set; } = null!;
        public virtual DbSet<TbConstTime> TbConstTimes { get; set; } = null!;
        public virtual DbSet<TbDashboard> TbDashboards { get; set; } = null!;
        public virtual DbSet<TbDevice> TbDevices { get; set; } = null!;
        public virtual DbSet<TbDeviceInputOutput> TbDeviceInputOutputs { get; set; } = null!;
        public virtual DbSet<TbDeviceIotag> TbDeviceIotags { get; set; } = null!;
        public virtual DbSet<TbDeviceLibrary> TbDeviceLibraries { get; set; } = null!;
        public virtual DbSet<TbDeviceTag> TbDeviceTags { get; set; } = null!;
        public virtual DbSet<TbFormula> TbFormulas { get; set; } = null!;
        public virtual DbSet<TbFunction> TbFunctions { get; set; } = null!;
        public virtual DbSet<TbGateway> TbGateways { get; set; } = null!;
        public virtual DbSet<TbGeofence> TbGeofences { get; set; } = null!;
        public virtual DbSet<TbHelp> TbHelps { get; set; } = null!;
        public virtual DbSet<TbInterval> TbIntervals { get; set; } = null!;
        public virtual DbSet<TbIntervalGroup> TbIntervalGroups { get; set; } = null!;
        public virtual DbSet<TbIntervalSub> TbIntervalSubs { get; set; } = null!;
        public virtual DbSet<TbLibraryDeviceInputOutput> TbLibraryDeviceInputOutputs { get; set; } = null!;
        public virtual DbSet<TbLibraryType> TbLibraryTypes { get; set; } = null!;
        public virtual DbSet<TbLicence> TbLicences { get; set; } = null!;
        public virtual DbSet<TbLogAlarm> TbLogAlarms { get; set; } = null!;
        public virtual DbSet<TbLogCallFunction> TbLogCallFunctions { get; set; } = null!;
        public virtual DbSet<TbLogDevManager> TbLogDevManagers { get; set; } = null!;
        public virtual DbSet<TbLogDevice> TbLogDevices { get; set; } = null!;
        public virtual DbSet<TbLogDeviceInputOutput> TbLogDeviceInputOutputs { get; set; } = null!;
        public virtual DbSet<TbLogFormula> TbLogFormulas { get; set; } = null!;
        public virtual DbSet<TbLogGateway> TbLogGateways { get; set; } = null!;
        public virtual DbSet<TbLogModifyFunction> TbLogModifyFunctions { get; set; } = null!;
        public virtual DbSet<TbLogUser> TbLogUsers { get; set; } = null!;
        public virtual DbSet<TbLogin> TbLogins { get; set; } = null!;
        public virtual DbSet<TbMission> TbMissions { get; set; } = null!;
        public virtual DbSet<TbOperator> TbOperators { get; set; } = null!;
        public virtual DbSet<TbOperatorType> TbOperatorTypes { get; set; } = null!;
        public virtual DbSet<TbPost> TbPosts { get; set; } = null!;
        public virtual DbSet<TbPremissionRole> TbPremissionRoles { get; set; } = null!;
        public virtual DbSet<TbPurpose> TbPurposes { get; set; } = null!;
        public virtual DbSet<TbPurposeMission> TbPurposeMissions { get; set; } = null!;
        public virtual DbSet<TbRole> TbRoles { get; set; } = null!;
        public virtual DbSet<TbSchedule> TbSchedules { get; set; } = null!;
        public virtual DbSet<TbScheduledApiCaller> TbScheduledApiCallers { get; set; } = null!;
        public virtual DbSet<TbState> TbStates { get; set; } = null!;
        public virtual DbSet<TbStateGroup> TbStateGroups { get; set; } = null!;
        public virtual DbSet<TbTempFunction> TbTempFunctions { get; set; } = null!;
        public virtual DbSet<TbThenAction> TbThenActions { get; set; } = null!;
        public virtual DbSet<TbTolerance> TbTolerances { get; set; } = null!;
        public virtual DbSet<TbTower> TbTowers { get; set; } = null!;
        public virtual DbSet<TbUnit> TbUnits { get; set; } = null!;
        public virtual DbSet<TbUser> TbUsers { get; set; } = null!;
        public virtual DbSet<TbVaribleType> TbVaribleTypes { get; set; } = null!;
        public virtual DbSet<ViewDeviceInputOutputLib> ViewDeviceInputOutputLibs { get; set; } = null!;
        public virtual DbSet<ViewSpDeviceIovaluePer24hour> ViewSpDeviceIovaluePer24hours { get; set; } = null!;
        public virtual DbSet<ViewValueIoperMonth> ViewValueIoperMonths { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=DBGreenhouseNG;Trusted_Connection=True;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbAccessRole>(entity =>
            {
                entity.ToTable("TbAccessRole");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");

                entity.HasOne(d => d.IdPremissionNavigation)
                    .WithMany(p => p.TbAccessRoles)
                    .HasForeignKey(d => d.IdPremission)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbPremissionRole_TbPremission");

                entity.HasOne(d => d.IdRoleNavigation)
                    .WithMany(p => p.TbAccessRoles)
                    .HasForeignKey(d => d.IdRole)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbPremissionRole_TbRole");
            });

            modelBuilder.Entity<TbAgent>(entity =>
            {
                entity.HasKey(e => e.IdAgent)
                    .HasName("PK_TbFLM");

                entity.ToTable("TbAgent");

                entity.Property(e => e.City).HasColumnName("city");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.Tel).HasMaxLength(11);

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");

                entity.HasOne(d => d.IdPostNavigation)
                    .WithMany(p => p.TbAgents)
                    .HasForeignKey(d => d.IdPost)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbAgent_TbPost");
            });

            modelBuilder.Entity<TbAlarm>(entity =>
            {
                entity.HasKey(e => e.IdAlarm);

                entity.ToTable("TbAlarm");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.EnAlarmName).HasMaxLength(30);

                entity.Property(e => e.FaAlarmName).HasMaxLength(30);

                entity.Property(e => e.SendSms).HasColumnName("sendSMS");

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");

                entity.HasOne(d => d.AlarmGroup)
                    .WithMany(p => p.TbAlarms)
                    .HasForeignKey(d => d.AlarmGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbAlarm_TbAlarmGroup");

                entity.HasOne(d => d.IdAreaNavigation)
                    .WithMany(p => p.TbAlarms)
                    .HasForeignKey(d => d.IdArea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbAlarm_TbArea");

                entity.HasOne(d => d.IdPriorityNavigation)
                    .WithMany(p => p.TbAlarms)
                    .HasForeignKey(d => d.IdPriority)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbAlarm_TbAlarmPriority");
            });

            modelBuilder.Entity<TbAlarmGroup>(entity =>
            {
                entity.HasKey(e => e.AlarmGroupId);

                entity.ToTable("TbAlarmGroup");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.EnName).HasMaxLength(30);

                entity.Property(e => e.FaName).HasMaxLength(50);

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<TbAlarmPriority>(entity =>
            {
                entity.HasKey(e => e.IdPriority);

                entity.ToTable("TbAlarmPriority");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.EnName).HasMaxLength(30);

                entity.Property(e => e.FaName).HasMaxLength(30);

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<TbAlarmRole>(entity =>
            {
                entity.HasKey(e => e.IdAlarmRole)
                    .HasName("PK_TbAlarmeRole");

                entity.ToTable("TbAlarmRole");

                entity.HasOne(d => d.IdAlarmNavigation)
                    .WithMany(p => p.TbAlarmRoles)
                    .HasForeignKey(d => d.IdAlarm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbAlarmRole_TbAlarm");

                entity.HasOne(d => d.IdRoleNavigation)
                    .WithMany(p => p.TbAlarmRoles)
                    .HasForeignKey(d => d.IdRole)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbAlarmRole_TbRole");
            });

            modelBuilder.Entity<TbAlarmTemplate>(entity =>
            {
                entity.HasKey(e => e.IdTemplate);

                entity.ToTable("TbAlarmTemplate");

                entity.Property(e => e.AlarmMessage).HasMaxLength(200);

                entity.Property(e => e.FaDisplayName).HasMaxLength(30);

                entity.Property(e => e.TemName).HasMaxLength(30);
            });

            modelBuilder.Entity<TbArea>(entity =>
            {
                entity.HasKey(e => e.IdArea)
                    .HasName("PK_TbFarm");

                entity.ToTable("TbArea");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.ImageArea)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ImageIcon)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NameEn).HasMaxLength(30);

                entity.Property(e => e.NameFa).HasMaxLength(30);

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<TbAreaEnvironment>(entity =>
            {
                entity.HasKey(e => e.IdEnvironment);

                entity.ToTable("TbAreaEnvironment");

                entity.HasOne(d => d.IdAreaNavigation)
                    .WithMany(p => p.TbAreaEnvironments)
                    .HasForeignKey(d => d.IdArea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbAreaEnvironment_TbArea");
            });

            modelBuilder.Entity<TbBattery>(entity =>
            {
                entity.ToTable("TbBattery");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.EnName).HasMaxLength(50);

                entity.Property(e => e.FaName).HasMaxLength(50);
            });

            modelBuilder.Entity<TbCamera>(entity =>
            {
                entity.HasKey(e => e.IdCamera);

                entity.ToTable("TbCamera");

                entity.Property(e => e.CameraIp)
                    .HasMaxLength(50)
                    .HasColumnName("CameraIP");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.EnCameraName).HasMaxLength(30);

                entity.Property(e => e.FaCameraName).HasMaxLength(30);

                entity.Property(e => e.PassCamera)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");

                entity.Property(e => e.UserCamera)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.IdDeviceNavigation)
                    .WithMany(p => p.TbCameras)
                    .HasForeignKey(d => d.IdDevice)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbCamera_TbDevice");
            });

            modelBuilder.Entity<TbCameraImageStorage>(entity =>
            {
                entity.HasKey(e => e.IdImageStorage)
                    .HasName("PK_TbImageStorageCamera");

                entity.ToTable("TbCameraImageStorage");

                entity.Property(e => e.IdImageStorage)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ImageFrame).HasColumnType("image");

                entity.Property(e => e.StorageDate).HasColumnType("datetime");

                entity.HasOne(d => d.IdCameraNavigation)
                    .WithMany(p => p.TbCameraImageStorages)
                    .HasForeignKey(d => d.IdCamera)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbImageStorageCamera_TbCamera");
            });

            modelBuilder.Entity<TbCameraMotionDetection>(entity =>
            {
                entity.HasKey(e => e.IdMotionDetection)
                    .HasName("PK_TbMotionDetectionCamera");

                entity.ToTable("TbCameraMotionDetection");

                entity.Property(e => e.IdMotionDetection)
                    .HasColumnType("numeric(10, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.IdCameraNavigation)
                    .WithMany(p => p.TbCameraMotionDetections)
                    .HasForeignKey(d => d.IdCamera)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbMotionDetectionCamera_TbCamera");
            });

            modelBuilder.Entity<TbChainCondition>(entity =>
            {
                entity.HasKey(e => e.IdChainCondition)
                    .HasName("PK_TbChain");

                entity.ToTable("TbChainCondition");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");

                entity.HasOne(d => d.IdConditionNavigation)
                    .WithMany(p => p.TbChainConditions)
                    .HasForeignKey(d => d.IdCondition)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbChainCondition_TbCondition");
            });

            modelBuilder.Entity<TbCondition>(entity =>
            {
                entity.HasKey(e => e.IdCondition);

                entity.ToTable("TbCondition");

                entity.Property(e => e.ForTime).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.IdVariableX).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdVariableY).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Value)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdFunctionNavigation)
                    .WithMany(p => p.TbConditions)
                    .HasForeignKey(d => d.IdFunction)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbCondition_TbFunction");

                entity.HasOne(d => d.IdOperatorNavigation)
                    .WithMany(p => p.TbConditions)
                    .HasForeignKey(d => d.IdOperator)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbCondition_TbOperator");

                entity.HasOne(d => d.IdVaribleTypeXNavigation)
                    .WithMany(p => p.TbConditionIdVaribleTypeXNavigations)
                    .HasForeignKey(d => d.IdVaribleTypeX)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbCondition_TbVaribleType");

                entity.HasOne(d => d.IdVaribleTypeYNavigation)
                    .WithMany(p => p.TbConditionIdVaribleTypeYNavigations)
                    .HasForeignKey(d => d.IdVaribleTypeY)
                    .HasConstraintName("FK_TbCondition_TbVaribleType1");
            });

            modelBuilder.Entity<TbConstTime>(entity =>
            {
                entity.HasKey(e => e.IdConstTime);

                entity.ToTable("TbConstTime");

                entity.Property(e => e.FinishTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.HasOne(d => d.IdScheduleNavigation)
                    .WithMany(p => p.TbConstTimes)
                    .HasForeignKey(d => d.IdSchedule)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbConstTime_TbSchedule");
            });

            modelBuilder.Entity<TbDashboard>(entity =>
            {
                entity.ToTable("TbDashboard");

                entity.Property(e => e.ItemId).HasMaxLength(10);

                entity.Property(e => e.ItemName).HasMaxLength(30);

                entity.Property(e => e.Root)
                    .HasMaxLength(100)
                    .HasColumnName("root");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TbDashboards)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbDashboard_TbUser");
            });

            modelBuilder.Entity<TbDevice>(entity =>
            {
                entity.HasKey(e => e.IdDevice)
                    .HasName("PK_TbActuatorDevice");

                entity.ToTable("TbDevice");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.EnName).HasMaxLength(30);

                entity.Property(e => e.FaName).HasMaxLength(30);

                entity.Property(e => e.Fault).HasColumnName("fault");

                entity.Property(e => e.LastPayload).HasMaxLength(250);

                entity.Property(e => e.Lat).HasColumnName("lat");

                entity.Property(e => e.Long).HasColumnName("long");

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");

                entity.HasOne(d => d.IdGatewayNavigation)
                    .WithMany(p => p.TbDevices)
                    .HasForeignKey(d => d.IdGateway)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbDevice_TbGateway");

                entity.HasOne(d => d.IdLibDeviceNavigation)
                    .WithMany(p => p.TbDevices)
                    .HasForeignKey(d => d.IdLibDevice)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbDevice_TbDeviceLibrary");
            });

            modelBuilder.Entity<TbDeviceInputOutput>(entity =>
            {
                entity.HasKey(e => e.IdDeviceIo);

                entity.ToTable("TbDeviceInputOutput");

                entity.Property(e => e.IdDeviceIo).HasColumnName("IdDeviceIO");

                entity.Property(e => e.EnNameIo)
                    .HasMaxLength(30)
                    .HasColumnName("EnNameIO");

                entity.Property(e => e.FaNameIo)
                    .HasMaxLength(30)
                    .HasColumnName("FaNameIO");

                entity.Property(e => e.GroupName).HasMaxLength(20);

                entity.Property(e => e.PortName).HasMaxLength(5);

                entity.HasOne(d => d.IdDeviceNavigation)
                    .WithMany(p => p.TbDeviceInputOutputs)
                    .HasForeignKey(d => d.IdDevice)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbDeviceInputOutput_TbDevice");

                entity.HasOne(d => d.IdLibInputOutputNavigation)
                    .WithMany(p => p.TbDeviceInputOutputs)
                    .HasForeignKey(d => d.IdLibInputOutput)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbDeviceInputOutput_TbLibraryDeviceInputOutput");
            });

            modelBuilder.Entity<TbDeviceIotag>(entity =>
            {
                entity.HasKey(e => e.IdDeviceIotag);

                entity.ToTable("TbDeviceIOTag");

                entity.Property(e => e.IdDeviceIotag).HasColumnName("IdDeviceIOTag");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.EnNameIotag)
                    .HasMaxLength(30)
                    .HasColumnName("EnNameIOTag");

                entity.Property(e => e.FaNameIotag)
                    .HasMaxLength(30)
                    .HasColumnName("FaNameIOTag");

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");

                entity.HasOne(d => d.IdDeviceTagNavigation)
                    .WithMany(p => p.TbDeviceIotags)
                    .HasForeignKey(d => d.IdDeviceTag)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbDeviceIOTag_TbDeviceTag");

                entity.HasOne(d => d.IdLibInputOutputNavigation)
                    .WithMany(p => p.TbDeviceIotags)
                    .HasForeignKey(d => d.IdLibInputOutput)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbDeviceIOTag_TbLibraryDeviceInputOutput");
            });

            modelBuilder.Entity<TbDeviceLibrary>(entity =>
            {
                entity.HasKey(e => e.IdLibDevice);

                entity.ToTable("TbDeviceLibrary");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.EnNameLib).HasMaxLength(30);

                entity.Property(e => e.FaNameLib).HasMaxLength(30);

                entity.Property(e => e.HasGsm).HasColumnName("HasGSM");

                entity.Property(e => e.ImageIcon)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<TbDeviceTag>(entity =>
            {
                entity.HasKey(e => e.IdDeviceTag);

                entity.ToTable("TbDeviceTag");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.LableTag).HasMaxLength(30);

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");

                entity.HasOne(d => d.IdDeviceNavigation)
                    .WithMany(p => p.TbDeviceTags)
                    .HasForeignKey(d => d.IdDevice)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbDeviceTag_TbDevice");
            });

            modelBuilder.Entity<TbFormula>(entity =>
            {
                entity.HasKey(e => e.IdFormula);

                entity.ToTable("TbFormula");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.EnFormulaName).HasMaxLength(30);

                entity.Property(e => e.ExpressionFormula).HasMaxLength(100);

                entity.Property(e => e.FaFormulaName).HasMaxLength(30);

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");

                entity.HasOne(d => d.IdAreaNavigation)
                    .WithMany(p => p.TbFormulas)
                    .HasForeignKey(d => d.IdArea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbFormula_TbArea");
            });

            modelBuilder.Entity<TbFunction>(entity =>
            {
                entity.HasKey(e => e.IdFunction);

                entity.ToTable("TbFunction");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.EnFunctionName).HasMaxLength(30);

                entity.Property(e => e.FaFunctionName).HasMaxLength(30);

                entity.Property(e => e.GroupFunc).HasMaxLength(20);

                entity.HasOne(d => d.IdAreaNavigation)
                    .WithMany(p => p.TbFunctions)
                    .HasForeignKey(d => d.IdArea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbFunction_TbArea");

                entity.HasOne(d => d.IdUserCreatorNavigation)
                    .WithMany(p => p.TbFunctions)
                    .HasForeignKey(d => d.IdUserCreator)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbFunction_TbUser");
            });

            modelBuilder.Entity<TbGateway>(entity =>
            {
                entity.HasKey(e => e.IdGateway);

                entity.ToTable("TbGateway");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.EnGatewayName).HasMaxLength(30);

                entity.Property(e => e.FaGatewayName).HasMaxLength(30);

                entity.Property(e => e.SimcardNumber)
                    .HasMaxLength(11)
                    .HasColumnName("SIMCardNumber")
                    .IsFixedLength();

                entity.Property(e => e.TopicGateway).HasMaxLength(50);

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");

                entity.HasOne(d => d.IdAreaNavigation)
                    .WithMany(p => p.TbGateways)
                    .HasForeignKey(d => d.IdArea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbGateway_TbArea");
            });

            modelBuilder.Entity<TbGeofence>(entity =>
            {
                entity.HasKey(e => e.IdGeofence);

                entity.ToTable("TbGeofence");

                entity.Property(e => e.EnGeofenceName).HasMaxLength(30);

                entity.Property(e => e.FaGeofenceName).HasMaxLength(30);
            });

            modelBuilder.Entity<TbHelp>(entity =>
            {
                entity.HasKey(e => e.IdPage);

                entity.ToTable("TbHelp");

                entity.Property(e => e.DescriptionH).HasMaxLength(500);

                entity.Property(e => e.IconH).HasMaxLength(50);

                entity.Property(e => e.TittleH).HasMaxLength(50);
            });

            modelBuilder.Entity<TbInterval>(entity =>
            {
                entity.HasKey(e => e.IdInterval);

                entity.ToTable("TbInterval");

                entity.HasOne(d => d.IdIntervalSubNavigation)
                    .WithMany(p => p.TbIntervals)
                    .HasForeignKey(d => d.IdIntervalSub)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbInterval_TbIntervalSub");

                entity.HasOne(d => d.IdScheduleNavigation)
                    .WithMany(p => p.TbIntervals)
                    .HasForeignKey(d => d.IdSchedule)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbInterval_TbSchedule");
            });

            modelBuilder.Entity<TbIntervalGroup>(entity =>
            {
                entity.HasKey(e => e.IdIntervalGroup)
                    .HasName("PK_TbIntervalGroup_1");

                entity.ToTable("TbIntervalGroup");

                entity.Property(e => e.EnIntervalGroupName).HasMaxLength(30);

                entity.Property(e => e.FaIntervalGroupName).HasMaxLength(30);
            });

            modelBuilder.Entity<TbIntervalSub>(entity =>
            {
                entity.HasKey(e => e.IdIntervalSub)
                    .HasName("PK_TbIntervalGroup");

                entity.ToTable("TbIntervalSub");

                entity.Property(e => e.EnTitleSub).HasMaxLength(20);

                entity.Property(e => e.FaTitleSub).HasMaxLength(20);

                entity.HasOne(d => d.IdIntervalGroupNavigation)
                    .WithMany(p => p.TbIntervalSubs)
                    .HasForeignKey(d => d.IdIntervalGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbIntervalSub_TbIntervalSub");
            });

            modelBuilder.Entity<TbLibraryDeviceInputOutput>(entity =>
            {
                entity.HasKey(e => e.IdLibInputOutput)
                    .HasName("PK_TbSensorLib");

                entity.ToTable("TbLibraryDeviceInputOutput");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.ImageIcon).HasMaxLength(50);

                entity.Property(e => e.LibNameEn).HasMaxLength(30);

                entity.Property(e => e.LibNameFa).HasMaxLength(30);

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");

                entity.HasOne(d => d.IdLibTypeNavigation)
                    .WithMany(p => p.TbLibraryDeviceInputOutputs)
                    .HasForeignKey(d => d.IdLibType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbLibrary_TbLibrary");

                entity.HasOne(d => d.IdToleranceNavigation)
                    .WithMany(p => p.TbLibraryDeviceInputOutputs)
                    .HasForeignKey(d => d.IdTolerance)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbLibrary_TbTolerance");

                entity.HasOne(d => d.IdUnitNavigation)
                    .WithMany(p => p.TbLibraryDeviceInputOutputs)
                    .HasForeignKey(d => d.IdUnit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbLibrary_TbUnit");
            });

            modelBuilder.Entity<TbLibraryType>(entity =>
            {
                entity.HasKey(e => e.IdLibType);

                entity.ToTable("TbLibraryType");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.EnTittleLibType).HasMaxLength(30);

                entity.Property(e => e.FaTittleLibType).HasMaxLength(30);

                entity.Property(e => e.ImageIcon).HasMaxLength(50);

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<TbLicence>(entity =>
            {
                entity.HasKey(e => e.IdLicence);

                entity.ToTable("TbLicence");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");

                entity.HasOne(d => d.IdAreaNavigation)
                    .WithMany(p => p.TbLicences)
                    .HasForeignKey(d => d.IdArea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbLicence_TbArea");
            });

            modelBuilder.Entity<TbLogAlarm>(entity =>
            {
                entity.HasKey(e => e.IdLogAlarm);

                entity.ToTable("TbLogAlarm");

                entity.Property(e => e.IdLogAlarm)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Token1).HasMaxLength(30);

                entity.Property(e => e.Token2).HasMaxLength(30);

                entity.Property(e => e.Token3).HasMaxLength(30);

                entity.HasOne(d => d.IdAlarmNavigation)
                    .WithMany(p => p.TbLogAlarms)
                    .HasForeignKey(d => d.IdAlarm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbLogAlarm_TbAlarm");
            });

            modelBuilder.Entity<TbLogCallFunction>(entity =>
            {
                entity.HasKey(e => e.IdLogCallFunction);

                entity.ToTable("TbLogCallFunction");

                entity.Property(e => e.IdLogCallFunction)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.RemainTimePerSecond).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TotalTimePerSecond).HasColumnType("numeric(10, 0)");

                entity.HasOne(d => d.IdCallerFunctionNavigation)
                    .WithMany(p => p.TbLogCallFunctionIdCallerFunctionNavigations)
                    .HasForeignKey(d => d.IdCallerFunction)
                    .HasConstraintName("FK_TbLogCallFunction_TbFunction2");

                entity.HasOne(d => d.IdCancellerFunctionNavigation)
                    .WithMany(p => p.TbLogCallFunctionIdCancellerFunctionNavigations)
                    .HasForeignKey(d => d.IdCancellerFunction)
                    .HasConstraintName("FK_TbLogCallFunction_TbFunction1");

                entity.HasOne(d => d.IdFunctionNavigation)
                    .WithMany(p => p.TbLogCallFunctionIdFunctionNavigations)
                    .HasForeignKey(d => d.IdFunction)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbLogCallFunction_TbFunction");
            });

            modelBuilder.Entity<TbLogDevManager>(entity =>
            {
                entity.ToTable("TbLogDevManager");

                entity.Property(e => e.AreaName).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.LogDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TbLogDevice>(entity =>
            {
                entity.HasKey(e => e.IdLog)
                    .HasName("PK_TbLogActuatorDevice");

                entity.ToTable("TbLogDevice");

                entity.Property(e => e.IdLog)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateLog).HasColumnType("datetime");

                entity.Property(e => e.Payload).HasMaxLength(250);

                entity.HasOne(d => d.IdDeviceNavigation)
                    .WithMany(p => p.TbLogDevices)
                    .HasForeignKey(d => d.IdDevice)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbLogDevice_TbDevice");
            });

            modelBuilder.Entity<TbLogDeviceInputOutput>(entity =>
            {
                entity.HasKey(e => e.IdLog);

                entity.ToTable("TbLogDeviceInputOutput");

                entity.Property(e => e.IdLog)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateLog).HasColumnType("datetime");

                entity.Property(e => e.IdDeviceIo).HasColumnName("IdDeviceIO");

                entity.HasOne(d => d.IdDeviceIoNavigation)
                    .WithMany(p => p.TbLogDeviceInputOutputs)
                    .HasForeignKey(d => d.IdDeviceIo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbLogDeviceInputOutput_TbDeviceInputOutput");
            });

            modelBuilder.Entity<TbLogFormula>(entity =>
            {
                entity.HasKey(e => e.IdLog);

                entity.ToTable("TbLogFormula");

                entity.Property(e => e.DateLog).HasColumnType("datetime");

                entity.HasOne(d => d.IdFormulaNavigation)
                    .WithMany(p => p.TbLogFormulas)
                    .HasForeignKey(d => d.IdFormula)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbLogFormula_TbFormula");
            });

            modelBuilder.Entity<TbLogGateway>(entity =>
            {
                entity.HasKey(e => e.IdLogGateway);

                entity.ToTable("TbLogGateway");

                entity.Property(e => e.IdLogGateway)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EndConnection).HasColumnType("datetime");

                entity.Property(e => e.StartConnection).HasColumnType("datetime");

                entity.HasOne(d => d.IdGatewayNavigation)
                    .WithMany(p => p.TbLogGateways)
                    .HasForeignKey(d => d.IdGateway)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbLogGateway_TbGateway");
            });

            modelBuilder.Entity<TbLogModifyFunction>(entity =>
            {
                entity.HasKey(e => e.IdLogModifyFunction)
                    .HasName("PK_TbLogModiftFunction");

                entity.ToTable("TbLogModifyFunction");

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");

                entity.HasOne(d => d.IdFunctionNavigation)
                    .WithMany(p => p.TbLogModifyFunctions)
                    .HasForeignKey(d => d.IdFunction)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbLogModiftFunction_TbFunction");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.TbLogModifyFunctions)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbLogModiftFunction_TbUser");
            });

            modelBuilder.Entity<TbLogUser>(entity =>
            {
                entity.HasKey(e => e.IdLogUser)
                    .HasName("PK_TbLogUser_1");

                entity.ToTable("TbLogUser");

                entity.Property(e => e.LastLoginTime).HasColumnType("datetime");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.TbLogUsers)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbLogUser_TbUser");
            });

            modelBuilder.Entity<TbLogin>(entity =>
            {
                entity.HasKey(e => e.LoginId);

                entity.ToTable("TbLogin");

                entity.Property(e => e.CraeteAt).HasColumnType("datetime");

                entity.Property(e => e.Designation).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FullName).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);
            });

            modelBuilder.Entity<TbMission>(entity =>
            {
                entity.HasKey(e => e.IdMission);

                entity.ToTable("TbMission");

                entity.Property(e => e.IdMission)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateMission).HasColumnType("datetime");

                entity.Property(e => e.LoginCode).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.IdAgentNavigation)
                    .WithMany(p => p.TbMissions)
                    .HasForeignKey(d => d.IdAgent)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbMission_TbAgent");

                entity.HasOne(d => d.IdTowerNavigation)
                    .WithMany(p => p.TbMissions)
                    .HasForeignKey(d => d.IdTower)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbMission_TbTower");
            });

            modelBuilder.Entity<TbOperator>(entity =>
            {
                entity.HasKey(e => e.IdOperator);

                entity.ToTable("TbOperator");

                entity.Property(e => e.EnTitleOperator).HasMaxLength(30);

                entity.Property(e => e.FaTitleOperator).HasMaxLength(30);

                entity.Property(e => e.OperatorSign).HasMaxLength(10);

                entity.HasOne(d => d.IdOperatorTypeNavigation)
                    .WithMany(p => p.TbOperators)
                    .HasForeignKey(d => d.IdOperatorType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbOperator_TbOperatorType");
            });

            modelBuilder.Entity<TbOperatorType>(entity =>
            {
                entity.HasKey(e => e.IdOperatorType);

                entity.ToTable("TbOperatorType");

                entity.Property(e => e.EnTitleOperatorType).HasMaxLength(30);

                entity.Property(e => e.FaTitleOperatorType).HasMaxLength(30);
            });

            modelBuilder.Entity<TbPost>(entity =>
            {
                entity.HasKey(e => e.IdPost)
                    .HasName("PK_TbPostOperationalUser");

                entity.ToTable("TbPost");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.TittlePost)
                    .HasMaxLength(50)
                    .HasColumnName("tittlePost");

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<TbPremissionRole>(entity =>
            {
                entity.HasKey(e => e.IdPremissionRole)
                    .HasName("PK_TbPremission");

                entity.ToTable("TbPremissionRole");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.Icon).HasMaxLength(150);

                entity.Property(e => e.Root).HasMaxLength(50);

                entity.Property(e => e.Tittle).HasMaxLength(50);

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<TbPurpose>(entity =>
            {
                entity.HasKey(e => e.IdPurpose);

                entity.ToTable("TbPurpose");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.TittlePurpose)
                    .HasMaxLength(50)
                    .HasColumnName("tittlePurpose");

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<TbPurposeMission>(entity =>
            {
                entity.HasKey(e => e.IpPurposeMission);

                entity.ToTable("TbPurposeMission");

                entity.Property(e => e.IpPurposeMission)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.IdMission).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TittlePm)
                    .HasMaxLength(50)
                    .HasColumnName("TittlePM");

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");

                entity.HasOne(d => d.IdMissionNavigation)
                    .WithMany(p => p.TbPurposeMissions)
                    .HasForeignKey(d => d.IdMission)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbPurposeMission_TbMission");

                entity.HasOne(d => d.IdPurposeNavigation)
                    .WithMany(p => p.TbPurposeMissions)
                    .HasForeignKey(d => d.IdPurpose)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbPurposeMission_TbPurpose");
            });

            modelBuilder.Entity<TbRole>(entity =>
            {
                entity.HasKey(e => e.IdRole)
                    .HasName("PK_TbRole_1");

                entity.ToTable("TbRole");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.EnTittle).HasMaxLength(50);

                entity.Property(e => e.FaTittle).HasMaxLength(50);

                entity.Property(e => e.FileStyle).HasMaxLength(50);

                entity.Property(e => e.RoleDescription).HasMaxLength(50);

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");

                entity.HasOne(d => d.IdAreaNavigation)
                    .WithMany(p => p.TbRoles)
                    .HasForeignKey(d => d.IdArea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbRole_TbArea");
            });

            modelBuilder.Entity<TbSchedule>(entity =>
            {
                entity.HasKey(e => e.IdSchedule);

                entity.ToTable("TbSchedule");

                entity.Property(e => e.TimeSchedule).HasColumnType("numeric(10, 0)");

                entity.HasOne(d => d.IdFunctionNavigation)
                    .WithMany(p => p.TbSchedules)
                    .HasForeignKey(d => d.IdFunction)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbSchedule_TbFunction");
            });

            modelBuilder.Entity<TbScheduledApiCaller>(entity =>
            {
                entity.ToTable("TbScheduledApiCaller");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<TbState>(entity =>
            {
                entity.HasKey(e => e.IdState);

                entity.ToTable("TbState");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.EnStateName).HasMaxLength(30);

                entity.Property(e => e.FaStateName).HasMaxLength(30);

                entity.Property(e => e.PriorityState).HasColumnName("priorityState");

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");

                entity.HasOne(d => d.IdStateGroupNavigation)
                    .WithMany(p => p.TbStates)
                    .HasForeignKey(d => d.IdStateGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbState_TbStateGroup");
            });

            modelBuilder.Entity<TbStateGroup>(entity =>
            {
                entity.HasKey(e => e.IdStateGroup);

                entity.ToTable("TbStateGroup");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.EnTitleGroupState).HasMaxLength(50);

                entity.Property(e => e.FaTitleGroupState).HasMaxLength(50);

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");

                entity.HasOne(d => d.IdAreaNavigation)
                    .WithMany(p => p.TbStateGroups)
                    .HasForeignKey(d => d.IdArea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbStateGroup_TbArea");
            });

            modelBuilder.Entity<TbTempFunction>(entity =>
            {
                entity.ToTable("TbTempFunction");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TbThenAction>(entity =>
            {
                entity.HasKey(e => e.IdThenAction);

                entity.ToTable("TbThenAction");

                entity.Property(e => e.ForTime).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.IdVariable).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Value)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdFunctionNavigation)
                    .WithMany(p => p.TbThenActions)
                    .HasForeignKey(d => d.IdFunction)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbThenAction_TbFunction");

                entity.HasOne(d => d.IdOperatorNavigation)
                    .WithMany(p => p.TbThenActions)
                    .HasForeignKey(d => d.IdOperator)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbThenAction_TbOperator");

                entity.HasOne(d => d.IdVaribleTypeNavigation)
                    .WithMany(p => p.TbThenActions)
                    .HasForeignKey(d => d.IdVaribleType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbThenAction_TbVaribleType");
            });

            modelBuilder.Entity<TbTolerance>(entity =>
            {
                entity.HasKey(e => e.IdTolerance);

                entity.ToTable("TbTolerance");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.TittleTolerance).HasMaxLength(50);

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<TbTower>(entity =>
            {
                entity.HasKey(e => e.IdTower)
                    .HasName("PK_TbDevice");

                entity.ToTable("TbTower");

                entity.Property(e => e.CellNumber).HasMaxLength(11);

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.EnName).HasMaxLength(50);

                entity.Property(e => e.FaName).HasMaxLength(50);

                entity.Property(e => e.SiteNumber).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<TbUnit>(entity =>
            {
                entity.HasKey(e => e.IdUnit);

                entity.ToTable("TbUnit");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.EnName).HasMaxLength(20);

                entity.Property(e => e.FaName).HasMaxLength(20);

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<TbUser>(entity =>
            {
                entity.HasKey(e => e.IdUser);

                entity.ToTable("TbUser");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName).HasMaxLength(30);

                entity.Property(e => e.LastLogin).HasColumnType("datetime");

                entity.Property(e => e.LastName).HasMaxLength(30);

                entity.Property(e => e.RegisterAt).HasColumnType("datetime");

                entity.Property(e => e.Tel)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Uname)
                    .HasMaxLength(30)
                    .HasColumnName("UName");

                entity.Property(e => e.Upass).HasMaxLength(100);

                entity.HasOne(d => d.IdRoleNavigation)
                    .WithMany(p => p.TbUsers)
                    .HasForeignKey(d => d.IdRole)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbUser_TbRole");
            });

            modelBuilder.Entity<TbVaribleType>(entity =>
            {
                entity.HasKey(e => e.IdVaribleType);

                entity.ToTable("TbVaribleType");

                entity.Property(e => e.EnTitleVaribleType).HasMaxLength(20);

                entity.Property(e => e.FaTitleVaribleType).HasMaxLength(20);

                entity.Property(e => e.FildId)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.FildName)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.ImageIcon).HasMaxLength(50);

                entity.Property(e => e.IndexType).HasMaxLength(3);

                entity.Property(e => e.TableName)
                    .HasMaxLength(30)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ViewDeviceInputOutputLib>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewDeviceInputOutputLib");

                entity.Property(e => e.EnNameIo)
                    .HasMaxLength(30)
                    .HasColumnName("EnNameIO");

                entity.Property(e => e.FaNameIo)
                    .HasMaxLength(30)
                    .HasColumnName("FaNameIO");

                entity.Property(e => e.IdDeviceIo).HasColumnName("IdDeviceIO");

                entity.Property(e => e.ImageIcon).HasMaxLength(50);

                entity.Property(e => e.LibNameEn).HasMaxLength(30);

                entity.Property(e => e.LibNameFa).HasMaxLength(30);
            });

            modelBuilder.Entity<ViewSpDeviceIovaluePer24hour>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewSpDeviceIOValuePer24hour");

                entity.Property(e => e.EnNameIo)
                    .HasMaxLength(30)
                    .HasColumnName("EnNameIO");

                entity.Property(e => e.FaNameIo)
                    .HasMaxLength(30)
                    .HasColumnName("FaNameIO");

                entity.Property(e => e.IdDeviceIo).HasColumnName("IdDeviceIO");

                entity.Property(e => e.LogMonth).HasMaxLength(4000);
            });

            modelBuilder.Entity<ViewValueIoperMonth>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewValueIOperMonth");

                entity.Property(e => e.EnNameIo)
                    .HasMaxLength(30)
                    .HasColumnName("EnNameIO");

                entity.Property(e => e.FaNameIo)
                    .HasMaxLength(30)
                    .HasColumnName("FaNameIO");

                entity.Property(e => e.IdDeviceIo).HasColumnName("IdDeviceIO");

                entity.Property(e => e.LogMonth).HasMaxLength(4000);

                entity.Property(e => e.LogYear).HasMaxLength(4000);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

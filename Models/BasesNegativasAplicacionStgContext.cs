using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ScorePromeAPI.Models;

public partial class BasesNegativasAplicacionStgContext : DbContext
{
    public BasesNegativasAplicacionStgContext()
    {
    }

    public BasesNegativasAplicacionStgContext(DbContextOptions<BasesNegativasAplicacionStgContext> options)
        : base(options)
    {
    }

    public virtual DbSet<A2180> A2180s { get; set; }

    public virtual DbSet<Accione> Acciones { get; set; }

    public virtual DbSet<Auditoria> Auditorias { get; set; }

    public virtual DbSet<Camino> Caminos { get; set; }

    public virtual DbSet<Cendeu> Cendeus { get; set; }

    public virtual DbSet<Consulta> Consultas { get; set; }

    public virtual DbSet<ConsultaNosi> ConsultaNoses { get; set; }

    public virtual DbSet<ConsultasHistorialCamino> ConsultasHistorialCaminos { get; set; }

    public virtual DbSet<DatosNosi> DatosNoses { get; set; }

    public virtual DbSet<Dmp> Dmps { get; set; }

    public virtual DbSet<Error> Errors { get; set; }

    public virtual DbSet<ErrorNosisLote> ErrorNosisLotes { get; set; }

    public virtual DbSet<EstadisticaCampania> EstadisticaCampanias { get; set; }

    public virtual DbSet<HistorialCamino> HistorialCaminos { get; set; }

    public virtual DbSet<ListaCdum> ListaCda { get; set; }

    public virtual DbSet<ListaDemandum> ListaDemanda { get; set; }

    public virtual DbSet<Mensaje> Mensajes { get; set; }

    public virtual DbSet<Metodo> Metodos { get; set; }

    public virtual DbSet<MetodosCamino> MetodosCaminos { get; set; }

    public virtual DbSet<Migration> Migrations { get; set; }

    public virtual DbSet<Morosos90> Morosos90s { get; set; }

    public virtual DbSet<MorososVigente> MorososVigentes { get; set; }

    public virtual DbSet<Motivo> Motivos { get; set; }

    public virtual DbSet<MotorpromeResult> MotorpromeResults { get; set; }

    public virtual DbSet<NosisLote> NosisLotes { get; set; }

    public virtual DbSet<Nse> Nses { get; set; }

    public virtual DbSet<Operadore> Operadores { get; set; }

    public virtual DbSet<Origene> Origenes { get; set; }

    public virtual DbSet<Ovale> Ovales { get; set; }

    public virtual DbSet<PasswordReset> PasswordResets { get; set; }

    public virtual DbSet<RechazosNosi> RechazosNoses { get; set; }

    public virtual DbSet<RefinanciacionMas2Anio> RefinanciacionMas2Anios { get; set; }

    public virtual DbSet<RefinanciacionMenos2Anio> RefinanciacionMenos2Anios { get; set; }

    public virtual DbSet<Resultado> Resultados { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<ScoresComportamiento> ScoresComportamientos { get; set; }

    public virtual DbSet<Servicio> Servicios { get; set; }

    public virtual DbSet<ServiciosCamino> ServiciosCaminos { get; set; }

    public virtual DbSet<SmvmMinMax> SmvmMinMaxes { get; set; }

    public virtual DbSet<Solicitante> Solicitantes { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Variable> Variables { get; set; }

    public virtual DbSet<VariablesCamino> VariablesCaminos { get; set; }

    public virtual DbSet<Veraz> Verazs { get; set; }

    public virtual DbSet<WpClientesPotenciale> WpClientesPotenciales { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=172.17.12.219;port=3306;database=bases_negativas_aplicacion_stg;user=prome;password=Micro2020*", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.10.6-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<A2180>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("a2180")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_unicode_ci");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Cantidad)
                .HasColumnType("int(11)")
                .HasColumnName("cantidad");
            entity.Property(e => e.CodSituacionLinea)
                .HasColumnType("smallint(6)")
                .HasColumnName("cod_situacion_linea");
        });

        modelBuilder.Entity<Accione>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("acciones")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Accion)
                .HasMaxLength(50)
                .HasColumnName("accion");
        });

        modelBuilder.Entity<Auditoria>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("auditorias")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.AccionId, "auditorias_accion_id_foreign");

            entity.HasIndex(e => e.ServicioId, "auditorias_servicio_id_foreign");

            entity.HasIndex(e => e.UsuarioEditId, "auditorias_usuario_edit_id_foreign");

            entity.HasIndex(e => e.UsuarioId, "auditorias_usuario_id_foreign");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.AccionId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("accion_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.ServicioId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("servicio_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.UsuarioEditId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("usuario_edit_id");
            entity.Property(e => e.UsuarioId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("usuario_id");

            entity.HasOne(d => d.Accion).WithMany(p => p.Auditoria)
                .HasForeignKey(d => d.AccionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auditorias_accion_id_foreign");

            entity.HasOne(d => d.Servicio).WithMany(p => p.Auditoria)
                .HasForeignKey(d => d.ServicioId)
                .HasConstraintName("auditorias_servicio_id_foreign");

            entity.HasOne(d => d.UsuarioEdit).WithMany(p => p.AuditoriaUsuarioEdits)
                .HasForeignKey(d => d.UsuarioEditId)
                .HasConstraintName("auditorias_usuario_edit_id_foreign");

            entity.HasOne(d => d.Usuario).WithMany(p => p.AuditoriaUsuarios)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auditorias_usuario_id_foreign");
        });

        modelBuilder.Entity<Camino>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("caminos")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_unicode_ci");

            entity.HasIndex(e => e.OrigenId, "caminos_origen_id_foreign");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Camino1)
                .HasMaxLength(255)
                .HasColumnName("camino");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Default).HasColumnName("default");
            entity.Property(e => e.OrigenId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("origen_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Origen).WithMany(p => p.Caminos)
                .HasForeignKey(d => d.OrigenId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("caminos_origen_id_foreign");
        });

        modelBuilder.Entity<Cendeu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("cendeu")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_unicode_ci");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Documento)
                .HasColumnType("int(11)")
                .HasColumnName("documento");
            entity.Property(e => e.FechaInformacion)
                .HasColumnType("int(11)")
                .HasColumnName("fecha_informacion");
            entity.Property(e => e.Situacion)
                .HasColumnType("smallint(6)")
                .HasColumnName("situacion");
        });

        modelBuilder.Entity<Consulta>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("consultas")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_unicode_ci");

            entity.HasIndex(e => e.OrigenId, "consultas_origen_id_foreign");

            entity.HasIndex(e => e.SolicitanteId, "consultas_solicitante_id_foreign");

            entity.HasIndex(e => e.StatusId, "consultas_status_id_foreign");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Cda)
                .HasMaxLength(255)
                .HasColumnName("cda");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.EstadoManager)
                .HasMaxLength(100)
                .HasColumnName("estado_manager");
            entity.Property(e => e.IdListaCda)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id_lista_cda");
            entity.Property(e => e.Manager)
                .HasMaxLength(100)
                .HasColumnName("manager");
            entity.Property(e => e.OrigenId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("origen_id");
            entity.Property(e => e.Path)
                .HasMaxLength(255)
                .HasColumnName("path");
            entity.Property(e => e.SolicitanteId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("solicitante_id");
            entity.Property(e => e.StatusId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("status_id");
            entity.Property(e => e.Ticket)
                .HasMaxLength(100)
                .HasColumnName("ticket");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.Veraz)
                .HasColumnType("mediumtext")
                .HasColumnName("veraz");

            entity.HasOne(d => d.Origen).WithMany(p => p.Consulta)
                .HasForeignKey(d => d.OrigenId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("consultas_origen_id_foreign");

            entity.HasOne(d => d.Solicitante).WithMany(p => p.Consulta)
                .HasForeignKey(d => d.SolicitanteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("consultas_solicitante_id_foreign");

            entity.HasOne(d => d.Status).WithMany(p => p.Consulta)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("consultas_status_id_foreign");
        });

        modelBuilder.Entity<ConsultaNosi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("consulta_nosis")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_unicode_ci");

            entity.HasIndex(e => e.IdNosisLote, "consulta_nosis_nosis_lote");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Dni)
                .HasMaxLength(8)
                .HasColumnName("dni");
            entity.Property(e => e.IdNosisLote)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id_nosis_lote");
            entity.Property(e => e.Raw)
                .HasColumnType("mediumtext")
                .HasColumnName("raw");
            entity.Property(e => e.Sexo)
                .HasMaxLength(5)
                .HasColumnName("sexo");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<ConsultasHistorialCamino>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("consultas_historial_caminos")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_unicode_ci");

            entity.HasIndex(e => e.ConsultaId, "consultas_historial_caminos_consulta_id_foreign");

            entity.HasIndex(e => e.HistorialCaminoId, "consultas_historial_caminos_historial_camino_id_foreign");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.ConsultaId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("consulta_id");
            entity.Property(e => e.HistorialCaminoId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("historial_camino_id");

            entity.HasOne(d => d.Consulta).WithMany(p => p.ConsultasHistorialCaminos)
                .HasForeignKey(d => d.ConsultaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("consultas_historial_caminos_consulta_id_foreign");

            entity.HasOne(d => d.HistorialCamino).WithMany(p => p.ConsultasHistorialCaminos)
                .HasForeignKey(d => d.HistorialCaminoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("consultas_historial_caminos_historial_camino_id_foreign");
        });

        modelBuilder.Entity<DatosNosi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("datos_nosis")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_unicode_ci");

            entity.Property(e => e.Ap12mEmpleadoFecAntigua)
                .HasMaxLength(100)
                .HasColumnName("AP_12m_Empleado_FecAntigua");
            entity.Property(e => e.Ap12mEmpleadoImpagosCant)
                .HasMaxLength(100)
                .HasColumnName("AP_12m_Empleado_Impagos_Cant");
            entity.Property(e => e.Ap12mEmpleadoPagoParcialCant)
                .HasMaxLength(100)
                .HasColumnName("AP_12m_Empleado_PagoParcial_Cant");
            entity.Property(e => e.Ap12mEmpleadoPagosCant)
                .HasMaxLength(100)
                .HasColumnName("AP_12m_Empleado_Pagos_Cant");
            entity.Property(e => e.Ap12mEmpleadorImpagosCant)
                .HasMaxLength(100)
                .HasColumnName("AP_12m_Empleador_Impagos_Cant");
            entity.Property(e => e.Ap12mEmpleadorPagoParcialCant)
                .HasMaxLength(100)
                .HasColumnName("AP_12m_Empleador_PagoParcial_Cant");
            entity.Property(e => e.Ap12mEmpleadorPagosCant)
                .HasMaxLength(100)
                .HasColumnName("AP_12m_Empleador_Pagos_Cant");
            entity.Property(e => e.Ap4mEmpleadoImpagosCant)
                .HasMaxLength(100)
                .HasColumnName("AP_4m_Empleado_Impagos_Cant");
            entity.Property(e => e.Ap4mEmpleadoPagoParcialCant)
                .HasMaxLength(100)
                .HasColumnName("AP_4m_Empleado_PagoParcial_Cant");
            entity.Property(e => e.Ap4mEmpleadoPagosCant)
                .HasMaxLength(100)
                .HasColumnName("AP_4m_Empleado_Pagos_Cant");
            entity.Property(e => e.ApVigEmpleadoDeclaracionJurada)
                .HasMaxLength(100)
                .HasColumnName("AP_Vig_Empleado_DeclaracionJurada");
            entity.Property(e => e.ApVigEmpleadoEstadoCod)
                .HasMaxLength(100)
                .HasColumnName("AP_Vig_Empleado_Estado_Cod");
            entity.Property(e => e.AsBeneficiosDetalleTxt)
                .HasMaxLength(100)
                .HasColumnName("AS_Beneficios_Detalle_Txt");
            entity.Property(e => e.BcDemCant)
                .HasMaxLength(100)
                .HasColumnName("BC_Dem_Cant");
            entity.Property(e => e.Cda)
                .HasMaxLength(100)
                .HasColumnName("CDA");
            entity.Property(e => e.CdaAf)
                .HasMaxLength(100)
                .HasColumnName("CDA_AF");
            entity.Property(e => e.CdaAp)
                .HasMaxLength(100)
                .HasColumnName("CDA_AP");
            entity.Property(e => e.CdaBc)
                .HasMaxLength(100)
                .HasColumnName("CDA_BC");
            entity.Property(e => e.CdaCi)
                .HasMaxLength(100)
                .HasColumnName("CDA_CI");
            entity.Property(e => e.CdaCompmensuales)
                .HasMaxLength(100)
                .HasColumnName("CDA_COMPMENSUALES");
            entity.Property(e => e.CdaDc)
                .HasMaxLength(100)
                .HasColumnName("CDA_DC");
            entity.Property(e => e.CdaDe)
                .HasMaxLength(100)
                .HasColumnName("CDA_DE");
            entity.Property(e => e.CdaDf)
                .HasMaxLength(100)
                .HasColumnName("CDA_DF");
            entity.Property(e => e.CdaDict)
                .HasMaxLength(100)
                .HasColumnName("CDA_DICT");
            entity.Property(e => e.CdaDp)
                .HasMaxLength(100)
                .HasColumnName("CDA_DP");
            entity.Property(e => e.CdaFa)
                .HasMaxLength(100)
                .HasColumnName("CDA_FA");
            entity.Property(e => e.CdaHc)
                .HasMaxLength(100)
                .HasColumnName("CDA_HC");
            entity.Property(e => e.CdaLd)
                .HasMaxLength(100)
                .HasColumnName("CDA_LD");
            entity.Property(e => e.CdaNse)
                .HasMaxLength(100)
                .HasColumnName("CDA_NSE");
            entity.Property(e => e.CdaOj)
                .HasMaxLength(100)
                .HasColumnName("CDA_OJ");
            entity.Property(e => e.CdaQu1)
                .HasMaxLength(100)
                .HasColumnName("CDA_QU_1");
            entity.Property(e => e.CdaQu2)
                .HasMaxLength(100)
                .HasColumnName("CDA_QU_2");
            entity.Property(e => e.CdaQu3)
                .HasMaxLength(100)
                .HasColumnName("CDA_QU_3");
            entity.Property(e => e.CdaRcP)
                .HasMaxLength(100)
                .HasColumnName("CDA_RC_P");
            entity.Property(e => e.CdaRcT)
                .HasMaxLength(100)
                .HasColumnName("CDA_RC_T");
            entity.Property(e => e.CdaSco)
                .HasMaxLength(100)
                .HasColumnName("CDA_SCO");
            entity.Property(e => e.CdaValorNse)
                .HasMaxLength(100)
                .HasColumnName("CDA_Valor_NSE");
            entity.Property(e => e.CdaValorSco)
                .HasMaxLength(100)
                .HasColumnName("CDA_Valor_SCO");
            entity.Property(e => e.CdaViAct)
                .HasMaxLength(100)
                .HasColumnName("CDA_VI_ACT");
            entity.Property(e => e.CdaViEdad)
                .HasMaxLength(100)
                .HasColumnName("CDA_VI_EDAD");
            entity.Property(e => e.CdaViFcs)
                .HasMaxLength(100)
                .HasColumnName("CDA_VI_FCS");
            entity.Property(e => e.Ci12mPeorSit)
                .HasMaxLength(100)
                .HasColumnName("CI_12m_PeorSit");
            entity.Property(e => e.Ci12mPeorSitPorc)
                .HasMaxLength(100)
                .HasColumnName("CI_12m_PeorSit_Porc");
            entity.Property(e => e.Ci24mBancarizado)
                .HasMaxLength(100)
                .HasColumnName("CI_24m_Bancarizado");
            entity.Property(e => e.Ci24mDetallePorPeriodo)
                .HasMaxLength(500)
                .HasColumnName("CI_24m_Detalle_PorPeriodo");
            entity.Property(e => e.Ci24mDetallePorPeriodoPorc)
                .HasMaxLength(100)
                .HasColumnName("CI_24m_Detalle_PorPeriodo_Porc");
            entity.Property(e => e.Ci24mPeorSit)
                .HasMaxLength(100)
                .HasColumnName("CI_24m_PeorSit");
            entity.Property(e => e.Ci24mPeorSitPorc)
                .HasMaxLength(100)
                .HasColumnName("CI_24m_PeorSit_Porc");
            entity.Property(e => e.Ci24mTotalCantBcos)
                .HasMaxLength(100)
                .HasColumnName("CI_24m_Total_CantBcos");
            entity.Property(e => e.Ci24mTotalMonto)
                .HasMaxLength(100)
                .HasColumnName("CI_24m_Total_Monto");
            entity.Property(e => e.Ci6mPeorSit)
                .HasMaxLength(100)
                .HasColumnName("CI_6m_PeorSit");
            entity.Property(e => e.CiAntiguedad)
                .HasMaxLength(100)
                .HasColumnName("CI_Antiguedad");
            entity.Property(e => e.CiBancarizado)
                .HasMaxLength(100)
                .HasColumnName("CI_Bancarizado");
            entity.Property(e => e.CiVigCancelDiferidaMonto)
                .HasMaxLength(100)
                .HasColumnName("CI_Vig_CancelDiferida_Monto");
            entity.Property(e => e.CiVigCompMensual)
                .HasMaxLength(100)
                .HasColumnName("CI_Vig_CompMensual");
            entity.Property(e => e.CiVigDetallePorEntidad)
                .HasMaxLength(100)
                .HasColumnName("CI_Vig_Detalle_PorEntidad");
            entity.Property(e => e.CiVigInteresPrestRenovables)
                .HasMaxLength(100)
                .HasColumnName("CI_Vig_Interes_PrestRenovables");
            entity.Property(e => e.CiVigLiPpMonto)
                .HasMaxLength(100)
                .HasColumnName("CI_Vig_Li_PP_Monto");
            entity.Property(e => e.CiVigPeorSit)
                .HasMaxLength(100)
                .HasColumnName("CI_Vig_PeorSit");
            entity.Property(e => e.CiVigPeorSitPorc)
                .HasMaxLength(100)
                .HasColumnName("CI_Vig_PeorSit_Porc");
            entity.Property(e => e.CiVigRatioCompMensualA6m)
                .HasMaxLength(100)
                .HasColumnName("CI_Vig_Ratio_CompMensual_a6m");
            entity.Property(e => e.CiVigRatioDeudaTotalA6m)
                .HasMaxLength(100)
                .HasColumnName("CI_Vig_Ratio_DeudaTotal_a6m");
            entity.Property(e => e.CiVigTcMonto)
                .HasMaxLength(100)
                .HasColumnName("CI_Vig_TC_Monto");
            entity.Property(e => e.CiVigTcSumaLimites)
                .HasMaxLength(100)
                .HasColumnName("CI_Vig_TC_Suma_Limites");
            entity.Property(e => e.CiVigTotalCantBcos)
                .HasMaxLength(100)
                .HasColumnName("CI_Vig_Total_CantBcos");
            entity.Property(e => e.CiVigTotalMonto)
                .HasMaxLength(100)
                .HasColumnName("CI_Vig_Total_Monto");
            entity.Property(e => e.CnDetalleTxt)
                .HasMaxLength(100)
                .HasColumnName("CN_Detalle_Txt");
            entity.Property(e => e.Co12mCant)
                .HasMaxLength(100)
                .HasColumnName("CO_12m_Cant");
            entity.Property(e => e.Co1mBancaCant)
                .HasMaxLength(100)
                .HasColumnName("CO_1m_Banca_Cant");
            entity.Property(e => e.Co1mFinanCant)
                .HasMaxLength(100)
                .HasColumnName("CO_1m_Finan_Cant");
            entity.Property(e => e.Co1mOtrosCant)
                .HasMaxLength(100)
                .HasColumnName("CO_1m_Otros_Cant");
            entity.Property(e => e.Cq60mCant)
                .HasMaxLength(100)
                .HasColumnName("CQ_60m_Cant");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.DcTiene)
                .HasMaxLength(100)
                .HasColumnName("DC_Tiene");
            entity.Property(e => e.DfTiene)
                .HasMaxLength(100)
                .HasColumnName("DF_Tiene");
            entity.Property(e => e.DxEs)
                .HasMaxLength(100)
                .HasColumnName("DX_Es");
            entity.Property(e => e.FeMaxApertura)
                .HasMaxLength(100)
                .HasColumnName("FE_MaxApertura");
            entity.Property(e => e.FexAfapFecAct)
                .HasMaxLength(100)
                .HasColumnName("FEX_AFAP_FecAct");
            entity.Property(e => e.FexAfocFecAct)
                .HasMaxLength(100)
                .HasColumnName("FEX_AFOC_FecAct");
            entity.Property(e => e.FexMnFecAct)
                .HasMaxLength(100)
                .HasColumnName("FEX_MN_FecAct");
            entity.Property(e => e.FexRdFecAct)
                .HasMaxLength(100)
                .HasColumnName("FEX_RD_FecAct");
            entity.Property(e => e.FexSipaFecAct)
                .HasMaxLength(100)
                .HasColumnName("FEX_SIPA_FecAct");
            entity.Property(e => e.FexSrtFecAct)
                .HasMaxLength(100)
                .HasColumnName("FEX_SRT_FecAct");
            entity.Property(e => e.FexSssFecAct)
                .HasMaxLength(100)
                .HasColumnName("FEX_SSS_FecAct");
            entity.Property(e => e.Hc12mSfNoPagCant)
                .HasMaxLength(100)
                .HasColumnName("HC_12m_SF_NoPag_Cant");
            entity.Property(e => e.Hc12mSfNoPagMonto)
                .HasMaxLength(100)
                .HasColumnName("HC_12m_SF_NoPag_Monto");
            entity.Property(e => e.Hc12mSfPagCant)
                .HasMaxLength(100)
                .HasColumnName("HC_12m_SF_Pag_Cant");
            entity.Property(e => e.Hc12mSfPagMonto)
                .HasMaxLength(100)
                .HasColumnName("HC_12m_SF_Pag_Monto");
            entity.Property(e => e.Hc12mSfSinPagMultaCant)
                .HasMaxLength(100)
                .HasColumnName("HC_12m_SF_SinPagMulta_Cant");
            entity.Property(e => e.Hc12mSfSinPagMultaMonto)
                .HasMaxLength(100)
                .HasColumnName("HC_12m_SF_SinPagMulta_Monto");
            entity.Property(e => e.Hc24mCant)
                .HasMaxLength(100)
                .HasColumnName("HC_24m_Cant");
            entity.Property(e => e.Hc24mSfPagCant)
                .HasMaxLength(100)
                .HasColumnName("HC_24m_SF_Pag_Cant");
            entity.Property(e => e.Hc24mSfPagMonto)
                .HasMaxLength(100)
                .HasColumnName("HC_24m_SF_Pag_Monto");
            entity.Property(e => e.Hc24mSfSinPagMultaCant)
                .HasMaxLength(100)
                .HasColumnName("HC_24m_SF_SinPagMulta_Cant");
            entity.Property(e => e.Hc24mSfSinPagMultaMonto)
                .HasMaxLength(100)
                .HasColumnName("HC_24m_SF_SinPagMulta_Monto");
            entity.Property(e => e.Hc3mSfSinPagMultaCant)
                .HasMaxLength(100)
                .HasColumnName("HC_3m_SF_SinPagMulta_Cant");
            entity.Property(e => e.Hc3mSfSinPagMultaMonto)
                .HasMaxLength(100)
                .HasColumnName("HC_3m_SF_SinPagMulta_Monto");
            entity.Property(e => e.Hc60mSfCant)
                .HasMaxLength(100)
                .HasColumnName("HC_60m_SF_Cant");
            entity.Property(e => e.Hc60mSfMonto)
                .HasMaxLength(100)
                .HasColumnName("HC_60m_SF_Monto");
            entity.Property(e => e.Hc60mSfSinPagMultaCant)
                .HasMaxLength(100)
                .HasColumnName("HC_60m_SF_SinPagMulta_Cant");
            entity.Property(e => e.Hc60mSfSinPagMultaMonto)
                .HasMaxLength(100)
                .HasColumnName("HC_60m_SF_SinPagMulta_Monto");
            entity.Property(e => e.HcVigDetalle30)
                .HasMaxLength(100)
                .HasColumnName("HC_Vig_Detalle_30");
            entity.Property(e => e.Hg12mCant)
                .HasMaxLength(100)
                .HasColumnName("HG_12m_Cant");
            entity.Property(e => e.Hg12mCantRedondos)
                .HasMaxLength(100)
                .HasColumnName("HG_12m_Cant_Redondos");
            entity.Property(e => e.Hg13a24mCantPositivos)
                .HasMaxLength(100)
                .HasColumnName("HG_13a24m_Cant_Positivos");
            entity.Property(e => e.Hg13a24mMontoPositivos)
                .HasMaxLength(100)
                .HasColumnName("HG_13a24m_Monto_Positivos");
            entity.Property(e => e.Hg6mCantPositivos)
                .HasMaxLength(100)
                .HasColumnName("HG_6m_Cant_Positivos");
            entity.Property(e => e.Hg6mMontoPositivos)
                .HasMaxLength(100)
                .HasColumnName("HG_6m_Monto_Positivos");
            entity.Property(e => e.Hg7a12mCantPositivos)
                .HasMaxLength(100)
                .HasColumnName("HG_7a12m_Cant_Positivos");
            entity.Property(e => e.Hg7a12mMontoPositivos)
                .HasMaxLength(100)
                .HasColumnName("HG_7a12m_Monto_Positivos");
            entity.Property(e => e.IdConsultaNosis)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id_consulta_nosis");
            entity.Property(e => e.Ju60mCant)
                .HasMaxLength(100)
                .HasColumnName("JU_60m_Cant");
            entity.Property(e => e.Mn12mCant)
                .HasMaxLength(100)
                .HasColumnName("MN_12m_Cant");
            entity.Property(e => e.Mn3mCant)
                .HasMaxLength(100)
                .HasColumnName("MN_3m_Cant");
            entity.Property(e => e.Nse)
                .HasMaxLength(100)
                .HasColumnName("NSE");
            entity.Property(e => e.Pq60mCant)
                .HasMaxLength(100)
                .HasColumnName("PQ_60m_Cant");
            entity.Property(e => e.Rc12mCant)
                .HasMaxLength(100)
                .HasColumnName("RC_12m_Cant");
            entity.Property(e => e.Rc12mFuente)
                .HasMaxLength(100)
                .HasColumnName("RC_12m_Fuente");
            entity.Property(e => e.RcVigCant)
                .HasMaxLength(100)
                .HasColumnName("RC_Vig_Cant");
            entity.Property(e => e.RcVigFuente)
                .HasMaxLength(100)
                .HasColumnName("RC_Vig_Fuente");
            entity.Property(e => e.Sco12m)
                .HasMaxLength(100)
                .HasColumnName("SCO_12m");
            entity.Property(e => e.Sco6mTendencia)
                .HasMaxLength(100)
                .HasColumnName("SCO_6m_Tendencia");
            entity.Property(e => e.ScoVig)
                .HasMaxLength(100)
                .HasColumnName("SCO_Vig");
            entity.Property(e => e.SrtEstado)
                .HasMaxLength(100)
                .HasColumnName("SRT_Estado");
            entity.Property(e => e.SssOsCod)
                .HasMaxLength(100)
                .HasColumnName("SSS_OS_Cod");
            entity.Property(e => e.SssOsFecDesde)
                .HasMaxLength(100)
                .HasColumnName("SSS_OS_FecDesde");
            entity.Property(e => e.SssOsTitularCondicion)
                .HasMaxLength(100)
                .HasColumnName("SSS_OS_Titular_Condicion");
            entity.Property(e => e.SssOsTitularParentesco)
                .HasMaxLength(100)
                .HasColumnName("SSS_OS_Titular_Parentesco");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.ViAct01Cod)
                .HasMaxLength(100)
                .HasColumnName("VI_Act01_Cod");
            entity.Property(e => e.ViAct01FecInicio)
                .HasMaxLength(100)
                .HasColumnName("VI_Act01_FecInicio");
            entity.Property(e => e.ViActividadesListado)
                .HasMaxLength(100)
                .HasColumnName("VI_Actividades_Listado");
            entity.Property(e => e.ViAntiguedadLaboralEmpleadorActual)
                .HasMaxLength(100)
                .HasColumnName("VI_AntiguedadLaboral_EmpleadorActual");
            entity.Property(e => e.ViContratoSocialFec)
                .HasMaxLength(100)
                .HasColumnName("VI_ContratoSocial_Fec");
            entity.Property(e => e.ViDni)
                .HasMaxLength(100)
                .HasColumnName("VI_DNI");
            entity.Property(e => e.ViDniVersion)
                .HasMaxLength(100)
                .HasColumnName("VI_DNI_Version");
            entity.Property(e => e.ViDocumentoReemplazo)
                .HasMaxLength(100)
                .HasColumnName("VI_DocumentoReemplazo");
            entity.Property(e => e.ViDomAfCalle)
                .HasMaxLength(100)
                .HasColumnName("VI_DomAF_Calle");
            entity.Property(e => e.ViDomAfCp)
                .HasMaxLength(100)
                .HasColumnName("VI_DomAF_CP");
            entity.Property(e => e.ViDomAfDto)
                .HasMaxLength(100)
                .HasColumnName("VI_DomAF_Dto");
            entity.Property(e => e.ViDomAfLoc)
                .HasMaxLength(100)
                .HasColumnName("VI_DomAF_Loc");
            entity.Property(e => e.ViDomAfNro)
                .HasMaxLength(100)
                .HasColumnName("VI_DomAF_Nro");
            entity.Property(e => e.ViDomAfPiso)
                .HasMaxLength(100)
                .HasColumnName("VI_DomAF_Piso");
            entity.Property(e => e.ViDomAfProv)
                .HasMaxLength(100)
                .HasColumnName("VI_DomAF_Prov");
            entity.Property(e => e.ViEmpleadoDomesticoEs)
                .HasMaxLength(100)
                .HasColumnName("VI_EmpleadoDomestico_Es");
            entity.Property(e => e.ViEmpleadoEs)
                .HasMaxLength(100)
                .HasColumnName("VI_Empleado_Es");
            entity.Property(e => e.ViEmpleadoEsUltFecha)
                .HasMaxLength(100)
                .HasColumnName("VI_Empleado_Es_UltFecha");
            entity.Property(e => e.ViEmpleadorAct01Cod)
                .HasMaxLength(100)
                .HasColumnName("VI_Empleador_Act01_Cod");
            entity.Property(e => e.ViEmpleadorCuit)
                .HasMaxLength(100)
                .HasColumnName("VI_Empleador_CUIT");
            entity.Property(e => e.ViEmpleadorDomicilio)
                .HasMaxLength(100)
                .HasColumnName("VI_Empleador_Domicilio");
            entity.Property(e => e.ViEmpleadorEs)
                .HasMaxLength(100)
                .HasColumnName("VI_Empleador_Es");
            entity.Property(e => e.ViEmpleadorRz)
                .HasMaxLength(100)
                .HasColumnName("VI_Empleador_RZ");
            entity.Property(e => e.ViEmpleadorTelCodArea)
                .HasMaxLength(100)
                .HasColumnName("VI_Empleador_TelCodArea");
            entity.Property(e => e.ViEmpleadorTelNro)
                .HasMaxLength(100)
                .HasColumnName("VI_Empleador_TelNro");
            entity.Property(e => e.ViEmpleadosCant)
                .HasMaxLength(100)
                .HasColumnName("VI_Empleados_Cant");
            entity.Property(e => e.ViFallecidoEs)
                .HasMaxLength(100)
                .HasColumnName("VI_Fallecido_Es");
            entity.Property(e => e.ViFecNacimiento)
                .HasMaxLength(100)
                .HasColumnName("VI_FecNacimiento");
            entity.Property(e => e.ViIdentificacion)
                .HasMaxLength(100)
                .HasColumnName("VI_Identificacion");
            entity.Property(e => e.ViIdentificacionesAnteriores)
                .HasMaxLength(100)
                .HasColumnName("VI_Identificaciones_Anteriores");
            entity.Property(e => e.ViInscripAfipAntiguedad)
                .HasMaxLength(100)
                .HasColumnName("VI_Inscrip_Afip_Antiguedad");
            entity.Property(e => e.ViInscripAutonomoEs)
                .HasMaxLength(100)
                .HasColumnName("VI_Inscrip_Autonomo_Es");
            entity.Property(e => e.ViInscripAutonomoFec)
                .HasMaxLength(100)
                .HasColumnName("VI_Inscrip_Autonomo_Fec");
            entity.Property(e => e.ViInscripGciaFec)
                .HasMaxLength(100)
                .HasColumnName("VI_Inscrip_Gcia_Fec");
            entity.Property(e => e.ViInscripIvaFec)
                .HasMaxLength(100)
                .HasColumnName("VI_Inscrip_IVA_Fec");
            entity.Property(e => e.ViInscripMonotributo)
                .HasMaxLength(100)
                .HasColumnName("VI_Inscrip_Monotributo");
            entity.Property(e => e.ViInscripMonotributoAct)
                .HasMaxLength(100)
                .HasColumnName("VI_Inscrip_Monotributo_Act");
            entity.Property(e => e.ViInscripMonotributoEs)
                .HasMaxLength(100)
                .HasColumnName("VI_Inscrip_Monotributo_Es");
            entity.Property(e => e.ViInscripMonotributoFec)
                .HasMaxLength(100)
                .HasColumnName("VI_Inscrip_Monotributo_Fec");
            entity.Property(e => e.ViIntegranteSociedadEs)
                .HasMaxLength(100)
                .HasColumnName("VI_IntegranteSociedad_Es");
            entity.Property(e => e.ViJubiladoEs)
                .HasMaxLength(100)
                .HasColumnName("VI_Jubilado_Es");
            entity.Property(e => e.ViRazonSocial)
                .HasMaxLength(100)
                .HasColumnName("VI_RazonSocial");
            entity.Property(e => e.ViRazonSocialPorcCoinc)
                .HasMaxLength(100)
                .HasColumnName("VI_RazonSocial_PorcCoinc");
            entity.Property(e => e.ViSexo)
                .HasMaxLength(100)
                .HasColumnName("VI_Sexo");
            entity.Property(e => e.ViTel1CodArea)
                .HasMaxLength(100)
                .HasColumnName("VI_Tel1_CodArea");
            entity.Property(e => e.ViTel1Nro)
                .HasMaxLength(100)
                .HasColumnName("VI_Tel1_Nro");
            entity.Property(e => e.ViTel2CodArea)
                .HasMaxLength(100)
                .HasColumnName("VI_Tel2_CodArea");
            entity.Property(e => e.ViTel2Nro)
                .HasMaxLength(100)
                .HasColumnName("VI_Tel2_Nro");
            entity.Property(e => e.ViTipoSocietario)
                .HasMaxLength(100)
                .HasColumnName("VI_TipoSocietario");
            entity.Property(e => e.VrRelacionesDetalle)
                .HasMaxLength(100)
                .HasColumnName("VR_Relaciones_Detalle");
        });

        modelBuilder.Entity<Dmp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("dmp")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_unicode_ci");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Bancarizado)
                .HasMaxLength(2)
                .HasColumnName("bancarizado");
            entity.Property(e => e.PorcentEndeudamiento)
                .HasColumnType("int(11)")
                .HasColumnName("porcent_endeudamiento");
            entity.Property(e => e.ScoreMax)
                .HasColumnType("int(11)")
                .HasColumnName("score_max");
            entity.Property(e => e.ScoreMin)
                .HasColumnType("int(11)")
                .HasColumnName("score_min");
        });

        modelBuilder.Entity<Error>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("errors")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_unicode_ci");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Error1)
                .HasMaxLength(255)
                .HasColumnName("error");
        });

        modelBuilder.Entity<ErrorNosisLote>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("error_nosis_lote")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_unicode_ci");

            entity.HasIndex(e => e.IdNosisLote, "error_nosis_lote_id_nosis_lote_foreign");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Dni)
                .HasMaxLength(30)
                .HasColumnName("dni");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .HasColumnName("estado");
            entity.Property(e => e.IdNosisLote)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id_nosis_lote");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Novedad)
                .HasMaxLength(255)
                .HasColumnName("novedad");
            entity.Property(e => e.Sexo)
                .HasMaxLength(10)
                .HasColumnName("sexo");
            entity.Property(e => e.Transaccion)
                .HasMaxLength(255)
                .HasColumnName("transaccion");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.IdNosisLoteNavigation).WithMany(p => p.ErrorNosisLotes)
                .HasForeignKey(d => d.IdNosisLote)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("error_nosis_lote_id_nosis_lote_foreign");
        });

        modelBuilder.Entity<EstadisticaCampania>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("estadistica_campanias")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_unicode_ci");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Documento)
                .HasColumnType("int(11)")
                .HasColumnName("documento");
            entity.Property(e => e.Solicitud)
                .HasColumnType("int(11)")
                .HasColumnName("solicitud");
            entity.Property(e => e.Subtipo)
                .HasMaxLength(500)
                .HasColumnName("subtipo");
            entity.Property(e => e.Tipo)
                .HasMaxLength(500)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<HistorialCamino>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("historial_caminos")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_unicode_ci");

            entity.HasIndex(e => e.CaminoId, "historial_caminos_camino_id_foreign");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.CaminoId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("camino_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Camino).WithMany(p => p.HistorialCaminos)
                .HasForeignKey(d => d.CaminoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("historial_caminos_camino_id_foreign");
        });

        modelBuilder.Entity<ListaCdum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("lista_cda")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_unicode_ci");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Cda)
                .HasMaxLength(100)
                .HasColumnName("cda");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("'1'")
                .HasColumnType("enum('1','0')")
                .HasColumnName("estado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .HasColumnName("nombre");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<ListaDemandum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("lista_demanda")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_unicode_ci");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.Valor)
                .HasMaxLength(100)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<Mensaje>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mensajes")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_unicode_ci");

            entity.HasIndex(e => e.MotivoId, "mensajes_motivo_id_foreign");

            entity.HasIndex(e => e.OrigenId, "mensajes_origen_id_foreign");

            entity.HasIndex(e => e.StatusId, "mensajes_status_id_foreign");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Mensaje1).HasColumnName("mensaje");
            entity.Property(e => e.MensajeMail).HasColumnName("mensaje_mail");
            entity.Property(e => e.MotivoId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("motivo_id");
            entity.Property(e => e.OrigenId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("origen_id");
            entity.Property(e => e.StatusId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("status_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Motivo).WithMany(p => p.Mensajes)
                .HasForeignKey(d => d.MotivoId)
                .HasConstraintName("mensajes_motivo_id_foreign");

            entity.HasOne(d => d.Origen).WithMany(p => p.Mensajes)
                .HasForeignKey(d => d.OrigenId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("mensajes_origen_id_foreign");

            entity.HasOne(d => d.Status).WithMany(p => p.Mensajes)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("mensajes_status_id_foreign");
        });

        modelBuilder.Entity<Metodo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("metodos")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_unicode_ci");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .HasColumnName("descripcion");
            entity.Property(e => e.Metodo1)
                .HasMaxLength(255)
                .HasColumnName("metodo");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<MetodosCamino>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("metodos_caminos")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_unicode_ci");

            entity.HasIndex(e => e.CaminoId, "metodos_caminos_camino_id_foreign");

            entity.HasIndex(e => e.MetodoId, "metodos_caminos_metodo_id_foreign");

            entity.HasIndex(e => e.ServicioId, "metodos_caminos_servicio_id_foreign");

            entity.HasIndex(e => e.StatusId, "metodos_caminos_status_id_foreign");

            entity.Property(e => e.CaminoId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("camino_id");
            entity.Property(e => e.Final).HasColumnName("final");
            entity.Property(e => e.MetodoId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("metodo_id");
            entity.Property(e => e.ServicioId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("servicio_id");
            entity.Property(e => e.StatusId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("status_id");

            entity.HasOne(d => d.Camino).WithMany()
                .HasForeignKey(d => d.CaminoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("metodos_caminos_camino_id_foreign");

            entity.HasOne(d => d.Metodo).WithMany()
                .HasForeignKey(d => d.MetodoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("metodos_caminos_metodo_id_foreign");

            entity.HasOne(d => d.Servicio).WithMany()
                .HasForeignKey(d => d.ServicioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("metodos_caminos_servicio_id_foreign");

            entity.HasOne(d => d.Status).WithMany()
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("metodos_caminos_status_id_foreign");
        });

        modelBuilder.Entity<Migration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("migrations")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_unicode_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Batch)
                .HasColumnType("int(11)")
                .HasColumnName("batch");
            entity.Property(e => e.Migration1)
                .HasMaxLength(255)
                .HasColumnName("migration");
        });

        modelBuilder.Entity<Morosos90>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("morosos_90")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_unicode_ci");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Documento)
                .HasColumnType("int(11)")
                .HasColumnName("documento");
            entity.Property(e => e.FechaProceso).HasColumnName("fecha_proceso");
            entity.Property(e => e.MaxDiasAtr)
                .HasColumnType("int(11)")
                .HasColumnName("max_dias_atr");
            entity.Property(e => e.TmcmMeses)
                .HasColumnType("int(11)")
                .HasColumnName("tmcm_meses");
        });

        modelBuilder.Entity<MorososVigente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("morosos_vigentes")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_unicode_ci");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.AcumPagosTarjeta)
                .HasPrecision(10, 2)
                .HasColumnName("acum_pagos_tarjeta");
            entity.Property(e => e.CantidadCuotas)
                .HasColumnType("smallint(6)")
                .HasColumnName("cantidad_cuotas");
            entity.Property(e => e.DeudaCubierta)
                .HasPrecision(10, 2)
                .HasColumnName("deuda_cubierta");
            entity.Property(e => e.DeudaExigible)
                .HasPrecision(10, 2)
                .HasColumnName("deuda_exigible");
            entity.Property(e => e.DiasAtraso)
                .HasColumnType("smallint(6)")
                .HasColumnName("dias_atraso");
            entity.Property(e => e.DocEcAdmin)
                .HasColumnType("int(11)")
                .HasColumnName("doc_ec_admin");
            entity.Property(e => e.DocEcAsigna)
                .HasColumnType("int(11)")
                .HasColumnName("doc_ec_asigna");
            entity.Property(e => e.DocEcEval)
                .HasColumnType("int(11)")
                .HasColumnName("doc_ec_eval");
            entity.Property(e => e.FechaApertura).HasColumnName("fecha_apertura");
            entity.Property(e => e.FechaCompromiso)
                .HasColumnType("smallint(6)")
                .HasColumnName("fecha_compromiso");
            entity.Property(e => e.FechaOtorgamiento).HasColumnName("fecha_otorgamiento");
            entity.Property(e => e.FechaProxLiq).HasColumnName("fecha_prox_liq");
            entity.Property(e => e.FechaUltimoMov).HasColumnName("fecha_ultimo_mov");
            entity.Property(e => e.FechaVencimiento).HasColumnName("fecha_vencimiento");
            entity.Property(e => e.FechaVtaTarjeta).HasColumnName("fecha_vta_tarjeta");
            entity.Property(e => e.FilialBpba)
                .HasColumnType("smallint(6)")
                .HasColumnName("filial_bpba");
            entity.Property(e => e.FilialProme)
                .HasColumnType("int(11)")
                .HasColumnName("filial_prome");
            entity.Property(e => e.ImporteMinTarjeta)
                .HasPrecision(10, 2)
                .HasColumnName("importe_min_tarjeta");
            entity.Property(e => e.MontoOtorgado)
                .HasPrecision(15, 2)
                .HasColumnName("monto_otorgado");
            entity.Property(e => e.NombreCliente)
                .HasMaxLength(50)
                .HasColumnName("nombre_cliente");
            entity.Property(e => e.NombreEcAdmin)
                .HasMaxLength(50)
                .HasColumnName("nombre_ec_admin");
            entity.Property(e => e.NombreEcAsigna)
                .HasMaxLength(50)
                .HasColumnName("nombre_ec_asigna");
            entity.Property(e => e.NombreEcEval)
                .HasMaxLength(50)
                .HasColumnName("nombre_ec_eval");
            entity.Property(e => e.NroCtaSur)
                .HasColumnType("bigint(20)")
                .HasColumnName("nro_cta_sur");
            entity.Property(e => e.NroDocCliente)
                .HasColumnType("int(11)")
                .HasColumnName("nro_doc_cliente");
            entity.Property(e => e.Plazo)
                .HasColumnType("smallint(6)")
                .HasColumnName("plazo");
            entity.Property(e => e.SaldoCuenta)
                .HasPrecision(10, 2)
                .HasColumnName("saldo_cuenta");
            entity.Property(e => e.SaldoDeudaTarjeta)
                .HasPrecision(10, 2)
                .HasColumnName("saldo_deuda_tarjeta");
            entity.Property(e => e.SaldoPrestamo)
                .HasPrecision(10, 2)
                .HasColumnName("saldo_prestamo");
            entity.Property(e => e.Solicitud)
                .HasColumnType("int(11)")
                .HasColumnName("solicitud");
            entity.Property(e => e.SubTipoCredito)
                .HasMaxLength(50)
                .HasColumnName("sub_tipo_credito");
            entity.Property(e => e.Sucursal)
                .HasMaxLength(50)
                .HasColumnName("sucursal");
            entity.Property(e => e.Tasa)
                .HasPrecision(10, 2)
                .HasColumnName("tasa");
            entity.Property(e => e.TelefonoBpba)
                .HasMaxLength(50)
                .HasColumnName("telefono_bpba");
            entity.Property(e => e.TelefonoCrm)
                .HasMaxLength(50)
                .HasColumnName("telefono_crm");
            entity.Property(e => e.TipCtaSur)
                .HasColumnType("smallint(6)")
                .HasColumnName("tip_cta_sur");
            entity.Property(e => e.TipoCredito)
                .HasMaxLength(50)
                .HasColumnName("tipo_credito");
            entity.Property(e => e.TotalCuota)
                .HasPrecision(10, 2)
                .HasColumnName("total_cuota");
            entity.Property(e => e.Zona)
                .HasMaxLength(50)
                .HasColumnName("zona");
        });

        modelBuilder.Entity<Motivo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("motivos")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_unicode_ci");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Motivo1)
                .HasMaxLength(50)
                .HasColumnName("motivo");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<MotorpromeResult>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("motorprome_results");

            entity.Property(e => e.Id)
                .HasColumnType("int(20)")
                .HasColumnName("id");
            entity.Property(e => e.CampaignFile)
                .HasMaxLength(1)
                .HasColumnName("campaign_file");
            entity.Property(e => e.Code)
                .HasColumnType("int(20)")
                .HasColumnName("code");
            entity.Property(e => e.ConsultaId)
                .HasColumnType("int(11)")
                .HasColumnName("consulta_id");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("created_on");
            entity.Property(e => e.Cuota)
                .HasColumnType("int(20)")
                .HasColumnName("cuota");
            entity.Property(e => e.Dni)
                .HasColumnType("int(11)")
                .HasColumnName("dni");
            entity.Property(e => e.Mensaje).HasColumnName("mensaje");
            entity.Property(e => e.MensajeMail).HasColumnName("mensaje_mail");
            entity.Property(e => e.Message)
                .HasMaxLength(100)
                .HasColumnName("message");
            entity.Property(e => e.Motivo)
                .HasMaxLength(100)
                .HasColumnName("motivo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Oferta)
                .HasColumnType("int(20)")
                .HasColumnName("oferta");
            entity.Property(e => e.PrestamoMaximo)
                .HasColumnType("int(20)")
                .HasColumnName("prestamo_maximo");
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .HasColumnName("sexo");
            entity.Property(e => e.Status)
                .HasMaxLength(100)
                .HasColumnName("status");
            entity.Property(e => e.Visita)
                .HasMaxLength(100)
                .HasColumnName("visita");
        });

        modelBuilder.Entity<NosisLote>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("nosis_lote")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_unicode_ci");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Documento)
                .HasMaxLength(255)
                .HasColumnName("documento");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .HasColumnName("url");
        });

        modelBuilder.Entity<Nse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("nse")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_unicode_ci");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Habilitado)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("habilitado");
            entity.Property(e => e.IngresoMaximo)
                .HasColumnType("double(10,2)")
                .HasColumnName("ingreso_maximo");
            entity.Property(e => e.IngresoMin)
                .HasColumnType("double(10,2)")
                .HasColumnName("ingreso_min");
            entity.Property(e => e.IngresoPromedio)
                .HasColumnType("double(10,2)")
                .HasColumnName("ingreso_promedio");
            entity.Property(e => e.Nivel)
                .HasMaxLength(2)
                .HasColumnName("nivel");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Operadore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("operadores")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Origene>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("origenes")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_unicode_ci");

            entity.HasIndex(e => e.RoleId, "origenes_role_id_foreign");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Origen)
                .HasMaxLength(50)
                .HasColumnName("origen");
            entity.Property(e => e.RoleId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("role_id");
            entity.Property(e => e.Token)
                .HasMaxLength(255)
                .HasColumnName("token");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Role).WithMany(p => p.Origenes)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("origenes_role_id_foreign");
        });

        modelBuilder.Entity<Ovale>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("ovales")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_unicode_ci");

            entity.HasIndex(e => e.ConsultaId, "ovales_consulta_id_foreign");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Actividad)
                .HasMaxLength(255)
                .HasColumnName("actividad");
            entity.Property(e => e.Categoria)
                .HasMaxLength(50)
                .HasColumnName("categoria");
            entity.Property(e => e.CodigoArea)
                .HasMaxLength(255)
                .HasColumnName("codigo_area");
            entity.Property(e => e.ConsultaId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("consulta_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Crm)
                .HasMaxLength(1)
                .HasColumnName("crm");
            entity.Property(e => e.Cuota)
                .HasPrecision(10, 2)
                .HasColumnName("cuota");
            entity.Property(e => e.Dni)
                .HasColumnType("int(11)")
                .HasColumnName("dni");
            entity.Property(e => e.HorarioLlamada)
                .HasMaxLength(255)
                .HasColumnName("horario_llamada");
            entity.Property(e => e.Localidad)
                .HasMaxLength(255)
                .HasColumnName("localidad");
            entity.Property(e => e.Mail)
                .HasMaxLength(255)
                .HasColumnName("mail");
            entity.Property(e => e.Monto)
                .HasPrecision(10, 2)
                .HasColumnName("monto");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .HasColumnName("nombre");
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .HasColumnName("sexo");
            entity.Property(e => e.Telefono)
                .HasMaxLength(255)
                .HasColumnName("telefono");
            entity.Property(e => e.TipoTelefono)
                .HasMaxLength(255)
                .HasColumnName("tipo_telefono");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Consulta).WithMany(p => p.Ovales)
                .HasForeignKey(d => d.ConsultaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ovales_consulta_id_foreign");
        });

        modelBuilder.Entity<PasswordReset>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("password_resets")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Email, "password_resets_email_index");

            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasMaxLength(191)
                .HasColumnName("email");
            entity.Property(e => e.Token)
                .HasMaxLength(191)
                .HasColumnName("token");
        });

        modelBuilder.Entity<RechazosNosi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("rechazos_nosis")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_unicode_ci");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.ActividadSector)
                .HasMaxLength(255)
                .HasColumnName("actividad_sector");
            entity.Property(e => e.Documento)
                .HasColumnType("int(11)")
                .HasColumnName("documento");
            entity.Property(e => e.DocumentoAfip)
                .HasColumnType("int(11)")
                .HasColumnName("documento_afip");
            entity.Property(e => e.EsBancarizado).HasColumnName("es_bancarizado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .HasColumnName("nombre");
            entity.Property(e => e.Periodo1)
                .HasColumnType("double(8,2)")
                .HasColumnName("periodo_1");
            entity.Property(e => e.Periodo10)
                .HasColumnType("double(8,2)")
                .HasColumnName("periodo_10");
            entity.Property(e => e.Periodo11)
                .HasColumnType("double(8,2)")
                .HasColumnName("periodo_11");
            entity.Property(e => e.Periodo12)
                .HasColumnType("double(8,2)")
                .HasColumnName("periodo_12");
            entity.Property(e => e.Periodo13)
                .HasColumnType("double(8,2)")
                .HasColumnName("periodo_13");
            entity.Property(e => e.Periodo14)
                .HasColumnType("double(8,2)")
                .HasColumnName("periodo_14");
            entity.Property(e => e.Periodo15)
                .HasColumnType("double(8,2)")
                .HasColumnName("periodo_15");
            entity.Property(e => e.Periodo16)
                .HasColumnType("double(8,2)")
                .HasColumnName("periodo_16");
            entity.Property(e => e.Periodo17)
                .HasColumnType("double(8,2)")
                .HasColumnName("periodo_17");
            entity.Property(e => e.Periodo18)
                .HasColumnType("double(8,2)")
                .HasColumnName("periodo_18");
            entity.Property(e => e.Periodo19)
                .HasColumnType("double(8,2)")
                .HasColumnName("periodo_19");
            entity.Property(e => e.Periodo2)
                .HasColumnType("double(8,2)")
                .HasColumnName("periodo_2");
            entity.Property(e => e.Periodo20)
                .HasColumnType("double(8,2)")
                .HasColumnName("periodo_20");
            entity.Property(e => e.Periodo21)
                .HasColumnType("double(8,2)")
                .HasColumnName("periodo_21");
            entity.Property(e => e.Periodo22)
                .HasColumnType("double(8,2)")
                .HasColumnName("periodo_22");
            entity.Property(e => e.Periodo23)
                .HasColumnType("double(8,2)")
                .HasColumnName("periodo_23");
            entity.Property(e => e.Periodo24)
                .HasColumnType("double(8,2)")
                .HasColumnName("periodo_24");
            entity.Property(e => e.Periodo3)
                .HasColumnType("double(8,2)")
                .HasColumnName("periodo_3");
            entity.Property(e => e.Periodo4)
                .HasColumnType("double(8,2)")
                .HasColumnName("periodo_4");
            entity.Property(e => e.Periodo5)
                .HasColumnType("double(8,2)")
                .HasColumnName("periodo_5");
            entity.Property(e => e.Periodo6)
                .HasColumnType("double(8,2)")
                .HasColumnName("periodo_6");
            entity.Property(e => e.Periodo7)
                .HasColumnType("double(8,2)")
                .HasColumnName("periodo_7");
            entity.Property(e => e.Periodo8)
                .HasColumnType("double(8,2)")
                .HasColumnName("periodo_8");
            entity.Property(e => e.Periodo9)
                .HasColumnType("double(8,2)")
                .HasColumnName("periodo_9");
            entity.Property(e => e.PeriodoCampaña)
                .HasColumnType("int(11)")
                .HasColumnName("periodo_campaña");
            entity.Property(e => e.PeriodoConsulta)
                .HasColumnType("int(11)")
                .HasColumnName("periodo_consulta");
            entity.Property(e => e.QCheques)
                .HasMaxLength(3)
                .HasColumnName("q_cheques");
            entity.Property(e => e.QChequesRechazados)
                .HasColumnType("double(8,2)")
                .HasColumnName("q_cheques_rechazados");
            entity.Property(e => e.QChequesSinPagoMulta)
                .HasColumnType("double(8,2)")
                .HasColumnName("q_cheques_sin_pago_multa");
            entity.Property(e => e.RazonSocialAfip)
                .HasMaxLength(255)
                .HasColumnName("razon_social_afip");
            entity.Property(e => e.ScoreNosis)
                .HasColumnType("double(8,2)")
                .HasColumnName("score_nosis");
            entity.Property(e => e.Ult2Meses)
                .HasMaxLength(3)
                .HasColumnName("ult_2_meses");
        });

        modelBuilder.Entity<RefinanciacionMas2Anio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("refinanciacion_mas_2_anios")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_unicode_ci");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Documento)
                .HasColumnType("int(11)")
                .HasColumnName("documento");
            entity.Property(e => e.FechaLiquidacion)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fecha_liquidacion");
            entity.Property(e => e.Solicitud)
                .HasColumnType("int(11)")
                .HasColumnName("solicitud");
            entity.Property(e => e.Subtipo)
                .HasMaxLength(500)
                .HasColumnName("subtipo");
            entity.Property(e => e.Tipo)
                .HasMaxLength(500)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<RefinanciacionMenos2Anio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("refinanciacion_menos_2_anios")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_unicode_ci");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Documento)
                .HasColumnType("int(11)")
                .HasColumnName("documento");
            entity.Property(e => e.Solicitud)
                .HasColumnType("int(11)")
                .HasColumnName("solicitud");
            entity.Property(e => e.Subtipo)
                .HasMaxLength(500)
                .HasColumnName("subtipo");
            entity.Property(e => e.Tipo)
                .HasMaxLength(500)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<Resultado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("resultados")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_unicode_ci");

            entity.HasIndex(e => e.ConsultaId, "resultados_consulta_id_foreign");

            entity.HasIndex(e => e.ErrorId, "resultados_error_id_foreign");

            entity.HasIndex(e => e.ServicioId, "resultados_servicio_id_foreign");

            entity.HasIndex(e => e.StatusId, "resultados_status_id_foreign");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.ConsultaId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("consulta_id");
            entity.Property(e => e.ErrorId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("error_id");
            entity.Property(e => e.Motivo)
                .HasMaxLength(255)
                .HasColumnName("motivo");
            entity.Property(e => e.ServicioId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("servicio_id");
            entity.Property(e => e.StatusId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("status_id");
            entity.Property(e => e.Valor)
                .HasMaxLength(100)
                .HasColumnName("valor");

            entity.HasOne(d => d.Consulta).WithMany(p => p.Resultados)
                .HasForeignKey(d => d.ConsultaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("resultados_consulta_id_foreign");

            entity.HasOne(d => d.Error).WithMany(p => p.Resultados)
                .HasForeignKey(d => d.ErrorId)
                .HasConstraintName("resultados_error_id_foreign");

            entity.HasOne(d => d.Servicio).WithMany(p => p.Resultados)
                .HasForeignKey(d => d.ServicioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("resultados_servicio_id_foreign");

            entity.HasOne(d => d.Status).WithMany(p => p.Resultados)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("resultados_status_id_foreign");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("roles")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_unicode_ci");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Role1)
                .HasMaxLength(255)
                .HasColumnName("role");
        });

        modelBuilder.Entity<ScoresComportamiento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("scores_comportamiento")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_unicode_ci");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.AvancePromedioPonderada)
                .HasPrecision(15, 6)
                .HasColumnName("avance_promedio_ponderada");
            entity.Property(e => e.CantTdaL4m)
                .HasColumnType("smallint(6)")
                .HasColumnName("cant_tda_l4m");
            entity.Property(e => e.Cuota)
                .HasPrecision(15, 6)
                .HasColumnName("cuota");
            entity.Property(e => e.Documento)
                .HasColumnType("int(11)")
                .HasColumnName("documento");
            entity.Property(e => e.EstadoCivil)
                .HasMaxLength(50)
                .HasColumnName("estado_civil");
            entity.Property(e => e.M0)
                .HasColumnType("smallint(6)")
                .HasColumnName("m0");
            entity.Property(e => e.MaxDiasAtraM42)
                .HasColumnType("smallint(6)")
                .HasColumnName("max_dias_atra_m_4_2");
            entity.Property(e => e.MesPivot).HasColumnName("mes_pivot");
            entity.Property(e => e.MesesAntCliente3)
                .HasColumnType("smallint(6)")
                .HasColumnName("meses_ant_cliente_3");
            entity.Property(e => e.MesesAntiguedadL4)
                .HasColumnType("smallint(6)")
                .HasColumnName("meses_antiguedad_l4");
            entity.Property(e => e.MinFechaOtorgamiento).HasColumnName("min_fecha_otorgamiento");
            entity.Property(e => e.NivelRiesgo)
                .HasMaxLength(20)
                .HasColumnName("nivel_riesgo");
            entity.Property(e => e.PlazoT)
                .HasColumnType("smallint(6)")
                .HasColumnName("plazo_t");
            entity.Property(e => e.PorcPlazoPonderado3)
                .HasColumnType("smallint(6)")
                .HasColumnName("porc_plazo_ponderado_3");
            entity.Property(e => e.PropCuotaCahSm2)
                .HasColumnType("smallint(6)")
                .HasColumnName("prop_cuota_cah_sm_2");
            entity.Property(e => e.SaldoFinalCah)
                .HasPrecision(15, 6)
                .HasColumnName("saldo_final_cah");
            entity.Property(e => e.SaldoMedioCah)
                .HasPrecision(15, 6)
                .HasColumnName("saldo_medio_cah");
            entity.Property(e => e.Score)
                .HasPrecision(15, 6)
                .HasColumnName("score");
            entity.Property(e => e.ScoreExcl)
                .HasColumnType("smallint(6)")
                .HasColumnName("score_excl");
            entity.Property(e => e.TempPondPorcAvance)
                .HasPrecision(15, 6)
                .HasColumnName("temp_pond_porc_avance");
            entity.Property(e => e.VecesTmvNotmcL4m3)
                .HasColumnType("smallint(6)")
                .HasColumnName("veces_tmv_notmc_l4m_3");
        });

        modelBuilder.Entity<Servicio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("servicios")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_unicode_ci");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Color)
                .HasMaxLength(25)
                .HasColumnName("color");
            entity.Property(e => e.Icon)
                .HasMaxLength(25)
                .HasColumnName("icon");
            entity.Property(e => e.Servicio1)
                .HasMaxLength(50)
                .HasColumnName("servicio");
        });

        modelBuilder.Entity<ServiciosCamino>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("servicios_caminos")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_unicode_ci");

            entity.HasIndex(e => e.CaminoId, "servicios_caminos_camino_id_foreign");

            entity.HasIndex(e => e.ServicioId, "servicios_caminos_servicio_id_foreign");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Bloqueante).HasColumnName("bloqueante");
            entity.Property(e => e.CaminoId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("camino_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Orden)
                .HasColumnType("int(11)")
                .HasColumnName("orden");
            entity.Property(e => e.ServicioId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("servicio_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Camino).WithMany(p => p.ServiciosCaminos)
                .HasForeignKey(d => d.CaminoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("servicios_caminos_camino_id_foreign");

            entity.HasOne(d => d.Servicio).WithMany(p => p.ServiciosCaminos)
                .HasForeignKey(d => d.ServicioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("servicios_caminos_servicio_id_foreign");
        });

        modelBuilder.Entity<SmvmMinMax>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("smvm_min_max")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_unicode_ci");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Bancarizado)
                .HasMaxLength(2)
                .HasColumnName("bancarizado");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.NSmvmMax)
                .HasColumnType("double(10,2)")
                .HasColumnName("n_smvm_max");
            entity.Property(e => e.NSmvmMin)
                .HasColumnType("double(10,2)")
                .HasColumnName("n_smvm_min");
            entity.Property(e => e.ScoreMax)
                .HasColumnType("int(11)")
                .HasColumnName("score_max");
            entity.Property(e => e.ScoreMin)
                .HasColumnType("int(11)")
                .HasColumnName("score_min");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Solicitante>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("solicitantes")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_unicode_ci");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Dni)
                .HasColumnType("int(11)")
                .HasColumnName("dni");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("status")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_unicode_ci");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.ActivoConsulta).HasColumnName("activo_consulta");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("usuarios")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Email, "usuarios_email_unique").IsUnique();

            entity.HasIndex(e => e.RoleId, "usuarios_role_id_foreign");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Dni)
                .HasColumnType("int(11)")
                .HasColumnName("dni");
            entity.Property(e => e.Email)
                .HasMaxLength(191)
                .HasColumnName("email");
            entity.Property(e => e.EmailVerifiedAt)
                .HasColumnType("timestamp")
                .HasColumnName("email_verified_at");
            entity.Property(e => e.Name)
                .HasMaxLength(191)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(191)
                .HasColumnName("password");
            entity.Property(e => e.RememberToken)
                .HasMaxLength(100)
                .HasColumnName("remember_token");
            entity.Property(e => e.RoleId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("role_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Role).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("usuarios_role_id_foreign");
        });

        modelBuilder.Entity<Variable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("variables")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_unicode_ci");

            entity.HasIndex(e => e.ServicioId, "variables_servicio_id_foreign");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Referencia)
                .HasMaxLength(50)
                .HasColumnName("referencia");
            entity.Property(e => e.ServicioId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("servicio_id");
            entity.Property(e => e.Variable1)
                .HasMaxLength(100)
                .HasColumnName("variable");

            entity.HasOne(d => d.Servicio).WithMany(p => p.Variables)
                .HasForeignKey(d => d.ServicioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("variables_servicio_id_foreign");
        });

        modelBuilder.Entity<VariablesCamino>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("variables_caminos")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_unicode_ci");

            entity.HasIndex(e => e.CaminoId, "variables_caminos_camino_id_foreign");

            entity.HasIndex(e => e.VariableId, "variables_caminos_variable_id_foreign");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Activa)
                .HasMaxLength(255)
                .HasColumnName("activa");
            entity.Property(e => e.CaminoId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("camino_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Operador)
                .HasMaxLength(5)
                .HasColumnName("operador");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .HasColumnName("valor");
            entity.Property(e => e.VariableId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("variable_id");

            entity.HasOne(d => d.Camino).WithMany(p => p.VariablesCaminos)
                .HasForeignKey(d => d.CaminoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("variables_caminos_camino_id_foreign");

            entity.HasOne(d => d.Variable).WithMany(p => p.VariablesCaminos)
                .HasForeignKey(d => d.VariableId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("variables_caminos_variable_id_foreign");
        });

        modelBuilder.Entity<Veraz>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("veraz")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_unicode_ci");

            entity.HasIndex(e => e.ConsultaId, "veraz_consulta_id_foreign");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Categoria)
                .HasMaxLength(255)
                .HasColumnName("categoria");
            entity.Property(e => e.ConsultaId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("consulta_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Cuota)
                .HasColumnType("double(8,2)")
                .HasColumnName("cuota");
            entity.Property(e => e.Documento)
                .HasColumnType("int(11)")
                .HasColumnName("documento");
            entity.Property(e => e.Html).HasColumnName("html");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .HasColumnName("nombre");
            entity.Property(e => e.Oferta)
                .HasColumnType("double(8,2)")
                .HasColumnName("oferta");
            entity.Property(e => e.PathHtml)
                .HasMaxLength(255)
                .HasColumnName("path_html");
            entity.Property(e => e.PathPdf)
                .HasMaxLength(255)
                .HasColumnName("path_pdf");
            entity.Property(e => e.PrestamoMaximo)
                .HasColumnType("double(8,2)")
                .HasColumnName("prestamo_maximo");
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .HasColumnName("sexo");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.Visita)
                .HasMaxLength(255)
                .HasColumnName("visita");
            entity.Property(e => e.Xml).HasColumnName("xml");

            entity.HasOne(d => d.Consulta).WithMany(p => p.Verazs)
                .HasForeignKey(d => d.ConsultaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("veraz_consulta_id_foreign");
        });

        modelBuilder.Entity<WpClientesPotenciale>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("wp_clientes_potenciales");

            entity.Property(e => e.ClienteApellido)
                .HasColumnType("text")
                .HasColumnName("cliente_apellido");
            entity.Property(e => e.ClienteDedicacion)
                .HasColumnType("text")
                .HasColumnName("cliente_dedicacion");
            entity.Property(e => e.ClienteDni)
                .HasColumnType("text")
                .HasColumnName("cliente_dni");
            entity.Property(e => e.ClienteEmail)
                .HasColumnType("text")
                .HasColumnName("cliente_email");
            entity.Property(e => e.ClienteFechaAlta)
                .HasColumnType("text")
                .HasColumnName("cliente_fecha_alta");
            entity.Property(e => e.ClienteId)
                .HasColumnType("text")
                .HasColumnName("cliente_id");
            entity.Property(e => e.ClienteLocalidad)
                .HasColumnType("text")
                .HasColumnName("cliente_localidad");
            entity.Property(e => e.ClienteNombre)
                .HasColumnType("text")
                .HasColumnName("cliente_nombre");
            entity.Property(e => e.ClienteSexo)
                .HasColumnType("text")
                .HasColumnName("cliente_sexo");
            entity.Property(e => e.ClienteTelAlternativoCodigo)
                .HasColumnType("text")
                .HasColumnName("cliente_tel_alternativo_codigo");
            entity.Property(e => e.ClienteTelAlternativoNumero)
                .HasColumnType("text")
                .HasColumnName("cliente_tel_alternativo_numero");
            entity.Property(e => e.ClienteTelAlternativoTipo)
                .HasColumnType("text")
                .HasColumnName("cliente_tel_alternativo_tipo");
            entity.Property(e => e.ClienteTelefonoCodigo)
                .HasColumnType("text")
                .HasColumnName("cliente_telefono_codigo");
            entity.Property(e => e.ClienteTelefonoNumero)
                .HasColumnType("text")
                .HasColumnName("cliente_telefono_numero");
            entity.Property(e => e.ClienteTelefonoTipo)
                .HasColumnType("text")
                .HasColumnName("cliente_telefono_tipo");
            entity.Property(e => e.ClienteTiempo)
                .HasColumnType("text")
                .HasColumnName("cliente_tiempo");
            entity.Property(e => e.ClienteUbicacionLocalBarrio)
                .HasColumnType("text")
                .HasColumnName("cliente_ubicacion_local_barrio");
            entity.Property(e => e.InstanceId)
                .HasColumnType("text")
                .HasColumnName("instanceId");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

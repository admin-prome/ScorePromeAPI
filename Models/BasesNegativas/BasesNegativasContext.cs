using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ScorePromeAPI.Models.BasesNegativas;

public partial class BasesNegativasContext : DbContext
{
    public BasesNegativasContext()
    {
    }

    public BasesNegativasContext(DbContextOptions<BasesNegativasContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DatosNosi> DatosNoses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=172.17.12.202;database=bases_negativas_aplicacion_prod;user=prome;password=Micro2020*", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.1.41-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<DatosNosi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("datos_nosis")
                .HasCharSet("utf8")
                .UseCollation("utf8_unicode_ci");

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
            entity.Property(e => e.Ap24mEmpleadorImpagosCant)
                .HasColumnType("mediumtext")
                .HasColumnName("AP_24m_Empleador_Impagos_Cant");
            entity.Property(e => e.Ap24mEmpleadorPagoParcialCant)
                .HasColumnType("mediumtext")
                .HasColumnName("AP_24m_Empleador_PagoParcial_Cant");
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
            entity.Property(e => e.Ci12mSit4CantBcos)
                .HasColumnType("mediumtext")
                .HasColumnName("CI_12m_Sit4_CantBcos");
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
            entity.Property(e => e.CiVigCortoPlazo)
                .HasColumnType("mediumtext")
                .HasColumnName("CI_Vig_CortoPlazo");
            entity.Property(e => e.CiVigDetallePorEntidad)
                .HasMaxLength(100)
                .HasColumnName("CI_Vig_Detalle_PorEntidad");
            entity.Property(e => e.CiVigInteresPrestRenovables)
                .HasMaxLength(100)
                .HasColumnName("CI_Vig_Interes_PrestRenovables");
            entity.Property(e => e.CiVigLargoPlazo)
                .HasColumnType("mediumtext")
                .HasColumnName("CI_Vig_LargoPlazo");
            entity.Property(e => e.CiVigLiCcMonto)
                .HasColumnType("mediumtext")
                .HasColumnName("CI_Vig_Li_CC_Monto");
            entity.Property(e => e.CiVigLiHiMonto)
                .HasColumnType("mediumtext")
                .HasColumnName("CI_Vig_Li_HI_Monto");
            entity.Property(e => e.CiVigLiHiUvaMonto)
                .HasColumnType("mediumtext")
                .HasColumnName("CI_Vig_Li_HI_UVA_Monto");
            entity.Property(e => e.CiVigLiOprUvaMonto)
                .HasColumnType("mediumtext")
                .HasColumnName("CI_Vig_Li_OPR_UVA_Monto");
            entity.Property(e => e.CiVigLiOtMonto)
                .HasColumnType("mediumtext")
                .HasColumnName("CI_Vig_Li_OT_Monto");
            entity.Property(e => e.CiVigLiOtUvaMonto)
                .HasColumnType("mediumtext")
                .HasColumnName("CI_Vig_Li_OT_UVA_Monto");
            entity.Property(e => e.CiVigLiPpMonto)
                .HasMaxLength(100)
                .HasColumnName("CI_Vig_Li_PP_Monto");
            entity.Property(e => e.CiVigLiPpMontoTotal)
                .HasColumnType("mediumtext")
                .HasColumnName("CI_Vig_Li_PP_Monto_Total");
            entity.Property(e => e.CiVigLiPpMontoTotalV2)
                .HasColumnType("mediumtext")
                .HasColumnName("CI_Vig_Li_PP_Monto_Total_v2");
            entity.Property(e => e.CiVigLiPpUvaCant)
                .HasColumnType("mediumtext")
                .HasColumnName("CI_Vig_Li_PP_UVA_Cant");
            entity.Property(e => e.CiVigLiPpUvaMonto)
                .HasColumnType("mediumtext")
                .HasColumnName("CI_Vig_Li_PP_UVA_Monto");
            entity.Property(e => e.CiVigLiPrMonto)
                .HasColumnType("mediumtext")
                .HasColumnName("CI_Vig_Li_PR_Monto");
            entity.Property(e => e.CiVigLiPrMontoTotal)
                .HasColumnType("mediumtext")
                .HasColumnName("CI_Vig_Li_PR_Monto_Total");
            entity.Property(e => e.CiVigMontoSit3oMas)
                .HasColumnType("mediumtext")
                .HasColumnName("CI_Vig_Monto_Sit3oMas");
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
            entity.Property(e => e.CiVigSit1CantBcos)
                .HasColumnType("mediumtext")
                .HasColumnName("CI_Vig_Sit1_CantBcos");
            entity.Property(e => e.CiVigSit1Monto)
                .HasColumnType("mediumtext")
                .HasColumnName("CI_Vig_Sit1_Monto");
            entity.Property(e => e.CiVigSit2CantBcos)
                .HasColumnType("mediumtext")
                .HasColumnName("CI_Vig_Sit2_CantBcos");
            entity.Property(e => e.CiVigSit2Monto)
                .HasColumnType("mediumtext")
                .HasColumnName("CI_Vig_Sit2_Monto");
            entity.Property(e => e.CiVigSit3CantBcos)
                .HasColumnType("mediumtext")
                .HasColumnName("CI_Vig_Sit3_CantBcos");
            entity.Property(e => e.CiVigSit3Monto)
                .HasColumnType("mediumtext")
                .HasColumnName("CI_Vig_Sit3_Monto");
            entity.Property(e => e.CiVigSit4CantBcos)
                .HasColumnType("mediumtext")
                .HasColumnName("CI_Vig_Sit4_CantBcos");
            entity.Property(e => e.CiVigSit4Monto)
                .HasColumnType("mediumtext")
                .HasColumnName("CI_Vig_Sit4_Monto");
            entity.Property(e => e.CiVigSit5CantBcos)
                .HasColumnType("mediumtext")
                .HasColumnName("CI_Vig_Sit5_CantBcos");
            entity.Property(e => e.CiVigSit5Monto)
                .HasColumnType("mediumtext")
                .HasColumnName("CI_Vig_Sit5_Monto");
            entity.Property(e => e.CiVigSit6CantBcos)
                .HasColumnType("mediumtext")
                .HasColumnName("CI_Vig_Sit6_CantBcos");
            entity.Property(e => e.CiVigSit6Monto)
                .HasColumnType("mediumtext")
                .HasColumnName("CI_Vig_Sit6_Monto");
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
            entity.Property(e => e.ComSoEs)
                .HasColumnType("mediumtext")
                .HasColumnName("Com_SO_Es");
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
            entity.Property(e => e.DpDeudorPrevEs)
                .HasColumnType("mediumtext")
                .HasColumnName("DP_DeudorPrev_Es");
            entity.Property(e => e.DxEs)
                .HasMaxLength(100)
                .HasColumnName("DX_Es");
            entity.Property(e => e.FaTiene)
                .HasColumnType("mediumtext")
                .HasColumnName("FA_Tiene");
            entity.Property(e => e.FeMaxApertura)
                .HasMaxLength(100)
                .HasColumnName("FE_MaxApertura");
            entity.Property(e => e.FexAfapFecAct)
                .HasMaxLength(100)
                .HasColumnName("FEX_AFAP_FecAct");
            entity.Property(e => e.FexAfocFecAct)
                .HasMaxLength(100)
                .HasColumnName("FEX_AFOC_FecAct");
            entity.Property(e => e.FexBcraFecAct)
                .HasColumnType("mediumtext")
                .HasColumnName("FEX_BCRA_FecAct");
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
            entity.Property(e => e.Hc12mOtNoPagCant)
                .HasColumnType("mediumtext")
                .HasColumnName("HC_12m_OT_NoPag_Cant");
            entity.Property(e => e.Hc12mOtNoPagMonto)
                .HasColumnType("mediumtext")
                .HasColumnName("HC_12m_OT_NoPag_Monto");
            entity.Property(e => e.Hc12mOtPagMonto)
                .HasColumnType("mediumtext")
                .HasColumnName("HC_12m_OT_Pag_Monto");
            entity.Property(e => e.Hc12mSfMonto)
                .HasColumnType("mediumtext")
                .HasColumnName("HC_12m_SF_Monto");
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
            entity.Property(e => e.Hc1mSfNoPagMonto)
                .HasColumnType("mediumtext")
                .HasColumnName("HC_1m_SF_NoPag_Monto");
            entity.Property(e => e.Hc24mCant)
                .HasMaxLength(100)
                .HasColumnName("HC_24m_Cant");
            entity.Property(e => e.Hc24mNoPagCant)
                .HasColumnType("mediumtext")
                .HasColumnName("HC_24m_NoPag_Cant");
            entity.Property(e => e.Hc24mSfNoPagCant)
                .HasColumnType("mediumtext")
                .HasColumnName("HC_24m_SF_NoPag_Cant");
            entity.Property(e => e.Hc24mSfNoPagMonto)
                .HasColumnType("mediumtext")
                .HasColumnName("HC_24m_SF_NoPag_Monto");
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
            entity.Property(e => e.Hc3mSfMonto)
                .HasColumnType("mediumtext")
                .HasColumnName("HC_3m_SF_Monto");
            entity.Property(e => e.Hc3mSfNoPagMonto)
                .HasColumnType("mediumtext")
                .HasColumnName("HC_3m_SF_NoPag_Monto");
            entity.Property(e => e.Hc3mSfPagMonto)
                .HasColumnType("mediumtext")
                .HasColumnName("HC_3m_SF_Pag_Monto");
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
            entity.Property(e => e.Hc6mOtNoPagCant)
                .HasColumnType("mediumtext")
                .HasColumnName("HC_6m_OT_NoPag_Cant");
            entity.Property(e => e.Hc6mOtNoPagMonto)
                .HasColumnType("mediumtext")
                .HasColumnName("HC_6m_OT_NoPag_Monto");
            entity.Property(e => e.Hc6mSfMonto)
                .HasColumnType("mediumtext")
                .HasColumnName("HC_6m_SF_Monto");
            entity.Property(e => e.Hc6mSfNoPagMonto)
                .HasColumnType("mediumtext")
                .HasColumnName("HC_6m_SF_NoPag_Monto");
            entity.Property(e => e.Hc6mSfPagCant)
                .HasColumnType("mediumtext")
                .HasColumnName("HC_6m_SF_Pag_Cant");
            entity.Property(e => e.Hc6mSfPagMonto)
                .HasColumnType("mediumtext")
                .HasColumnName("HC_6m_SF_Pag_Monto");
            entity.Property(e => e.Hc6mSfSinPagMultaMonto)
                .HasColumnType("mediumtext")
                .HasColumnName("HC_6m_SF_SinPagMulta_Monto");
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
            entity.Property(e => e.In24mPagoMultaTiene)
                .HasColumnType("mediumtext")
                .HasColumnName("IN_24m_PagoMulta_Tiene");
            entity.Property(e => e.InVigPagoMulta6mTiene)
                .HasColumnType("mediumtext")
                .HasColumnName("IN_Vig_PagoMulta_6m_Tiene");
            entity.Property(e => e.InVigPagoMultaTiene)
                .HasColumnType("mediumtext")
                .HasColumnName("IN_Vig_PagoMulta_Tiene");
            entity.Property(e => e.Ju60mCant)
                .HasMaxLength(100)
                .HasColumnName("JU_60m_Cant");
            entity.Property(e => e.Ju60mTotalCantidad)
                .HasColumnType("mediumtext")
                .HasColumnName("JU_60m_TotalCantidad");
            entity.Property(e => e.Mn12mCant)
                .HasMaxLength(100)
                .HasColumnName("MN_12m_Cant");
            entity.Property(e => e.Mn3mCant)
                .HasMaxLength(100)
                .HasColumnName("MN_3m_Cant");
            entity.Property(e => e.Nse)
                .HasMaxLength(100)
                .HasColumnName("NSE");
            entity.Property(e => e.Oj12mLevCant)
                .HasColumnType("mediumtext")
                .HasColumnName("OJ_12m_Lev_Cant");
            entity.Property(e => e.Oj24mLevCant)
                .HasColumnType("mediumtext")
                .HasColumnName("OJ_24m_Lev_Cant");
            entity.Property(e => e.Oj24mNoLevCant)
                .HasColumnType("mediumtext")
                .HasColumnName("OJ_24m_NoLev_Cant");
            entity.Property(e => e.Oj60mLevCant)
                .HasColumnType("mediumtext")
                .HasColumnName("OJ_60m_Lev_Cant");
            entity.Property(e => e.Oj60mNoLevCant)
                .HasColumnType("mediumtext")
                .HasColumnName("OJ_60m_NoLev_Cant");
            entity.Property(e => e.Oj60mNoLevMonto)
                .HasColumnType("mediumtext")
                .HasColumnName("OJ_60m_NoLev_Monto");
            entity.Property(e => e.OjVigEmbCant)
                .HasColumnType("mediumtext")
                .HasColumnName("OJ_Vig_Emb_Cant");
            entity.Property(e => e.OjVigEmbMonto)
                .HasColumnType("mediumtext")
                .HasColumnName("OJ_Vig_Emb_Monto");
            entity.Property(e => e.Pq60mCant)
                .HasMaxLength(100)
                .HasColumnName("PQ_60m_Cant");
            entity.Property(e => e.Pq60mRzCant)
                .HasColumnType("mediumtext")
                .HasColumnName("PQ_60m_RZ_Cant");
            entity.Property(e => e.Rc12mCant)
                .HasMaxLength(100)
                .HasColumnName("RC_12m_Cant");
            entity.Property(e => e.Rc12mFuente)
                .HasMaxLength(100)
                .HasColumnName("RC_12m_Fuente");
            entity.Property(e => e.RcVigCant)
                .HasMaxLength(100)
                .HasColumnName("RC_Vig_Cant");
            entity.Property(e => e.RcVigComercioVentaHogarCant)
                .HasColumnType("mediumtext")
                .HasColumnName("RC_Vig_ComercioVentaHogar_Cant");
            entity.Property(e => e.RcVigComercioVentaOtrosCant)
                .HasColumnType("mediumtext")
                .HasColumnName("RC_Vig_ComercioVentaOtros_Cant");
            entity.Property(e => e.RcVigComercioVentaUtilCant)
                .HasColumnType("mediumtext")
                .HasColumnName("RC_Vig_ComercioVentaUtil_Cant");
            entity.Property(e => e.RcVigDetalle)
                .HasColumnType("mediumtext")
                .HasColumnName("RC_Vig_Detalle");
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
            entity.Property(e => e.ViAct01Descrip)
                .HasColumnType("mediumtext")
                .HasColumnName("VI_Act01_Descrip");
            entity.Property(e => e.ViAct01FecInicio)
                .HasMaxLength(100)
                .HasColumnName("VI_Act01_FecInicio");
            entity.Property(e => e.ViAct01Sector)
                .HasColumnType("mediumtext")
                .HasColumnName("VI_Act01_Sector");
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
            entity.Property(e => e.ViEdadMenorEs)
                .HasColumnType("mediumtext")
                .HasColumnName("VI_EdadMenor_Es");
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

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

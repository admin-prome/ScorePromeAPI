using System;
using System.Collections.Generic;

namespace ScorePromeAPI.Models;

public partial class DatosNosi
{
    public ulong IdConsultaNosis { get; set; }

    public string? ViRazonSocial { get; set; }

    public string? ViDni { get; set; }

    public string? ViIdentificacion { get; set; }

    public string? ViDniVersion { get; set; }

    public string? ViRazonSocialPorcCoinc { get; set; }

    public string? ViFallecidoEs { get; set; }

    public string? ViFecNacimiento { get; set; }

    public string? ViSexo { get; set; }

    public string? ViDomAfCalle { get; set; }

    public string? ViDomAfNro { get; set; }

    public string? ViDomAfPiso { get; set; }

    public string? ViDomAfDto { get; set; }

    public string? ViDomAfLoc { get; set; }

    public string? ViDomAfCp { get; set; }

    public string? ViDomAfProv { get; set; }

    public string? ViTel1CodArea { get; set; }

    public string? ViTel1Nro { get; set; }

    public string? ViTel2CodArea { get; set; }

    public string? ViTel2Nro { get; set; }

    public string? ViInscripMonotributo { get; set; }

    public string? ViInscripMonotributoAct { get; set; }

    public string? ViInscripMonotributoFec { get; set; }

    public string? ViInscripAutonomoFec { get; set; }

    public string? ViIntegranteSociedadEs { get; set; }

    public string? ViEmpleadorEs { get; set; }

    public string? ViContratoSocialFec { get; set; }

    public string? ViInscripAfipAntiguedad { get; set; }

    public string? ViEmpleadosCant { get; set; }

    public string? ViJubiladoEs { get; set; }

    public string? ViEmpleadoEs { get; set; }

    public string? ViEmpleadorRz { get; set; }

    public string? ViEmpleadorCuit { get; set; }

    public string? ViEmpleadorDomicilio { get; set; }

    public string? ViEmpleadorTelCodArea { get; set; }

    public string? ViEmpleadorTelNro { get; set; }

    public string? ViInscripIvaFec { get; set; }

    public string? ViInscripGciaFec { get; set; }

    public string? Ap12mEmpleadoImpagosCant { get; set; }

    public string? Ap12mEmpleadoPagosCant { get; set; }

    public string? Ap12mEmpleadoPagoParcialCant { get; set; }

    public string? Ap12mEmpleadorImpagosCant { get; set; }

    public string? Ap12mEmpleadorPagosCant { get; set; }

    public string? Ap12mEmpleadorPagoParcialCant { get; set; }

    public string? ViAct01Cod { get; set; }

    public string? ViAct01FecInicio { get; set; }

    public string? SssOsCod { get; set; }

    public string? SssOsFecDesde { get; set; }

    public string? SssOsTitularCondicion { get; set; }

    public string? SssOsTitularParentesco { get; set; }

    public string? CiVigPeorSit { get; set; }

    public string? CiVigTotalCantBcos { get; set; }

    public string? CiVigTotalMonto { get; set; }

    public string? CiAntiguedad { get; set; }

    public string? Ci6mPeorSit { get; set; }

    public string? Ci12mPeorSit { get; set; }

    public string? Ci24mPeorSit { get; set; }

    public string? Ci24mTotalCantBcos { get; set; }

    public string? Ci24mTotalMonto { get; set; }

    public string? CiVigLiPpMonto { get; set; }

    public string? CiVigTcMonto { get; set; }

    public string? CiVigTcSumaLimites { get; set; }

    public string? CiVigCompMensual { get; set; }

    public string? CiVigRatioDeudaTotalA6m { get; set; }

    public string? CiVigRatioCompMensualA6m { get; set; }

    public string? CiVigInteresPrestRenovables { get; set; }

    public string? DxEs { get; set; }

    public string? Hc12mSfNoPagCant { get; set; }

    public string? Hc12mSfNoPagMonto { get; set; }

    public string? Hc12mSfPagCant { get; set; }

    public string? Hc12mSfPagMonto { get; set; }

    public string? Hc12mSfSinPagMultaCant { get; set; }

    public string? Hc12mSfSinPagMultaMonto { get; set; }

    public string? Hc24mSfPagCant { get; set; }

    public string? Hc24mSfPagMonto { get; set; }

    public string? Hc24mSfSinPagMultaCant { get; set; }

    public string? Hc24mSfSinPagMultaMonto { get; set; }

    public string? Hc60mSfSinPagMultaCant { get; set; }

    public string? Hc60mSfSinPagMultaMonto { get; set; }

    public string? Ju60mCant { get; set; }

    public string? Cq60mCant { get; set; }

    public string? Rc12mCant { get; set; }

    public string? Rc12mFuente { get; set; }

    public string? Hg12mCant { get; set; }

    public string? Co1mFinanCant { get; set; }

    public string? Co1mBancaCant { get; set; }

    public string? Co1mOtrosCant { get; set; }

    public string? ScoVig { get; set; }

    public string? Sco12m { get; set; }

    public string? Sco6mTendencia { get; set; }

    public string? Nse { get; set; }

    public string? Cda { get; set; }

    public string? CdaDict { get; set; }

    public string? CdaAf { get; set; }

    public string? CdaViEdad { get; set; }

    public string? CdaViFcs { get; set; }

    public string? CdaViAct { get; set; }

    public string? CdaAp { get; set; }

    public string? CdaCi { get; set; }

    public string? CdaOj { get; set; }

    public string? CdaHc { get; set; }

    public string? CdaDe { get; set; }

    public string? CdaQu1 { get; set; }

    public string? CdaQu2 { get; set; }

    public string? CdaQu3 { get; set; }

    public string? CdaBc { get; set; }

    public string? CdaRcP { get; set; }

    public string? CdaRcT { get; set; }

    public string? CdaFa { get; set; }

    public string? CdaLd { get; set; }

    public string? CdaDf { get; set; }

    public string? CdaDc { get; set; }

    public string? CdaDp { get; set; }

    public string? CdaSco { get; set; }

    public string? CdaValorSco { get; set; }

    public string? CdaNse { get; set; }

    public string? CdaValorNse { get; set; }

    public string? CdaCompmensuales { get; set; }

    public string? DfTiene { get; set; }

    public string? SrtEstado { get; set; }

    public string? Co12mCant { get; set; }

    public string? Pq60mCant { get; set; }

    public string? Ap12mEmpleadoFecAntigua { get; set; }

    public string? CiVigPeorSitPorc { get; set; }

    public string? Ci24mPeorSitPorc { get; set; }

    public string? Ci12mPeorSitPorc { get; set; }

    public string? CiVigCancelDiferidaMonto { get; set; }

    public string? Hc24mCant { get; set; }

    public string? Hg12mCantRedondos { get; set; }

    public string? Hg6mCantPositivos { get; set; }

    public string? Hg6mMontoPositivos { get; set; }

    public string? Hg7a12mCantPositivos { get; set; }

    public string? Hg7a12mMontoPositivos { get; set; }

    public string? Hg13a24mCantPositivos { get; set; }

    public string? Hg13a24mMontoPositivos { get; set; }

    public string? DcTiene { get; set; }

    public string? ViTipoSocietario { get; set; }

    public string? CiBancarizado { get; set; }

    public string? HcVigDetalle30 { get; set; }

    public string? ViEmpleadorAct01Cod { get; set; }

    public string? ViInscripMonotributoEs { get; set; }

    public string? ViInscripAutonomoEs { get; set; }

    public string? ViEmpleadoDomesticoEs { get; set; }

    public string? ViIdentificacionesAnteriores { get; set; }

    public string? ViDocumentoReemplazo { get; set; }

    public string? Hc60mSfCant { get; set; }

    public string? Hc60mSfMonto { get; set; }

    public string? Hc3mSfSinPagMultaCant { get; set; }

    public string? Hc3mSfSinPagMultaMonto { get; set; }

    public string? BcDemCant { get; set; }

    public string? CiVigDetallePorEntidad { get; set; }

    public string? Ci24mDetallePorPeriodo { get; set; }

    public string? Ci24mDetallePorPeriodoPorc { get; set; }

    public string? FexRdFecAct { get; set; }

    public string? FexSrtFecAct { get; set; }

    public string? FexSssFecAct { get; set; }

    public string? FexAfapFecAct { get; set; }

    public string? FexSipaFecAct { get; set; }

    public string? FexAfocFecAct { get; set; }

    public string? FexMnFecAct { get; set; }

    public string? Ci24mBancarizado { get; set; }

    public string? FeMaxApertura { get; set; }

    public string? RcVigCant { get; set; }

    public string? RcVigFuente { get; set; }

    public string? Mn3mCant { get; set; }

    public string? Mn12mCant { get; set; }

    public string? Ap4mEmpleadoPagosCant { get; set; }

    public string? Ap4mEmpleadoPagoParcialCant { get; set; }

    public string? Ap4mEmpleadoImpagosCant { get; set; }

    public string? ViAntiguedadLaboralEmpleadorActual { get; set; }

    public string? VrRelacionesDetalle { get; set; }

    public string? ApVigEmpleadoDeclaracionJurada { get; set; }

    public string? ApVigEmpleadoEstadoCod { get; set; }

    public string? ViEmpleadoEsUltFecha { get; set; }

    public string? ViActividadesListado { get; set; }

    public string? CnDetalleTxt { get; set; }

    public string? AsBeneficiosDetalleTxt { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

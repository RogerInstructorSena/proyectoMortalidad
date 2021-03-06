//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace proyectoMortalidad.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Variable
    {
        public int ID { get; set; }
        public decimal codDptoPreguntaId { get; set; }
        public decimal codMunicPreguntaId { get; set; }
        public decimal aDefunPreguntaId { get; set; }
        public decimal sitDefunPreguntaId { get; set; }
        public string OTRSITIODE { get; set; }
        public string COD_INST { get; set; }
        public string NOM_INST { get; set; }
        public string TIPO_DEFUN { get; set; }
        public decimal ANO { get; set; }
        public decimal mesPreguntaId { get; set; }
        public decimal horaPreguntaId { get; set; }
        public decimal minutosPreguntaId { get; set; }
        public decimal sexoPreguntaId { get; set; }
        public decimal estCivilPreguntaId { get; set; }
        public decimal gruEd1PreguntaId { get; set; }
        public decimal gruEd2PreguntaId { get; set; }
        public decimal nivelEduPreguntaId { get; set; }
        public decimal ultcurfalPreguntaId { get; set; }
        public decimal muerteporoPreguntaId { get; set; }
        public decimal simuertepoPreguntaId { get; set; }
        public string OCUPACION { get; set; }
        public decimal idepertetPreguntaId { get; set; }
        public decimal codpresPreguntaId { get; set; }
        public decimal codptorePreguntaId { get; set; }
        public decimal codmunrePreguntaId { get; set; }
        public decimal areaResPreguntaId { get; set; }
        public decimal segSocialPreguntaId { get; set; }
        public decimal idadmisaluPreguntaId { get; set; }
        public string IDCLASADMI { get; set; }
        public decimal pmanMuerPreguntaId { get; set; }
        public decimal consExpPreguntaId { get; set; }
        public decimal muPartoPreguntaId { get; set; }
        public decimal tPartoPreguntaId { get; set; }
        public decimal tipoEmbPreguntaId { get; set; }
        public decimal tGesPreguntaId { get; set; }
        public decimal pesoNacPreguntaId { get; set; }
        public decimal edadMadrePreguntaId { get; set; }
        public decimal nHijosvPreguntaId { get; set; }
        public decimal nHijosmPreguntaId { get; set; }
        public decimal estCivmPreguntaId { get; set; }
        public decimal nivEdumPreguntaId { get; set; }
        public decimal ultcurmadPreguntaId { get; set; }
        public decimal embFalPreguntaId { get; set; }
        public decimal embSemPreguntaId { get; set; }
        public decimal embMesPreguntaId { get; set; }
        public decimal manMuerPreguntaId { get; set; }
        public decimal codocurPreguntaId { get; set; }
        public decimal codmunocPreguntaId { get; set; }
        public decimal cMuertePreguntaId { get; set; }
        public decimal cMuertebPreguntaId { get; set; }
        public decimal cMuertecPreguntaId { get; set; }
        public decimal cMuertedPreguntaId { get; set; }
        public decimal cMuerteePreguntaId { get; set; }
        public decimal asisMedPreguntaId { get; set; }
        public string cDir1PreguntaId { get; set; }
        public string cDir12PreguntaId { get; set; }
        public string cAnt1PreguntaId { get; set; }
        public string cAnt12PreguntaId { get; set; }
        public string cAnt2PreguntaId { get; set; }
        public string cAnt22PreguntaId { get; set; }
        public string cAnt3PreguntaId { get; set; }
        public string cAnt32PreguntaId { get; set; }
        public string cPat1PreguntaId { get; set; }
        public string cPat2PreguntaId { get; set; }
        public string cBas1PreguntaId { get; set; }
        public string cMcm1PreguntaId { get; set; }
        public decimal causa666PreguntaId { get; set; }
        public decimal idprofcerPreguntaId { get; set; }
        public decimal cauHomolPreguntaId { get; set; }
    
        public virtual A_DEFUN_PREGUNTA A_DEFUN_PREGUNTA { get; set; }
        public virtual AREA_RES_PREGUNTA AREA_RES_PREGUNTA { get; set; }
        public virtual ASIS_MED_PREGUNTA ASIS_MED_PREGUNTA { get; set; }
        public virtual C_ANT1_PREGUNTA C_ANT1_PREGUNTA { get; set; }
        public virtual C_ANT12_PREGUNTA C_ANT12_PREGUNTA { get; set; }
        public virtual C_ANT2_PREGUNTA C_ANT2_PREGUNTA { get; set; }
        public virtual C_ANT22_PREGUNTA C_ANT22_PREGUNTA { get; set; }
        public virtual C_ANT3_PREGUNTA C_ANT3_PREGUNTA { get; set; }
        public virtual C_ANT32_PREGUNTA C_ANT32_PREGUNTA { get; set; }
        public virtual C_BAS1_PREGUNTA C_BAS1_PREGUNTA { get; set; }
        public virtual C_DIR1_PREGUNTA C_DIR1_PREGUNTA { get; set; }
        public virtual C_DIR12_PREGUNTA C_DIR12_PREGUNTA { get; set; }
        public virtual C_MCM1_PREGUNTA C_MCM1_PREGUNTA { get; set; }
        public virtual C_MUERTE_PREGUNTA C_MUERTE_PREGUNTA { get; set; }
        public virtual C_MUERTEB_PREGUNTA C_MUERTEB_PREGUNTA { get; set; }
        public virtual C_MUERTEC_PREGUNTA C_MUERTEC_PREGUNTA { get; set; }
        public virtual C_MUERTED_PREGUNTA C_MUERTED_PREGUNTA { get; set; }
        public virtual C_MUERTEE_PREGUNTA C_MUERTEE_PREGUNTA { get; set; }
        public virtual C_PAT1_PREGUNTA C_PAT1_PREGUNTA { get; set; }
        public virtual C_PAT2_PREGUNTA C_PAT2_PREGUNTA { get; set; }
        public virtual CAU_HOMOL_PREGUNTA CAU_HOMOL_PREGUNTA { get; set; }
        public virtual CAUSA_666_PREGUNTA CAUSA_666_PREGUNTA { get; set; }
        public virtual COD_DPTO_PREGUNTA COD_DPTO_PREGUNTA { get; set; }
        public virtual COD_MUNIC_PREGUNTA COD_MUNIC_PREGUNTA { get; set; }
        public virtual CODMUNOC_PREGUNTA CODMUNOC_PREGUNTA { get; set; }
        public virtual CODMUNRE_PREGUNTA CODMUNRE_PREGUNTA { get; set; }
        public virtual CODOCUR_PREGUNTA CODOCUR_PREGUNTA { get; set; }
        public virtual CODPRES_PREGUNTA CODPRES_PREGUNTA { get; set; }
        public virtual CODPTORE_PREGUNTA CODPTORE_PREGUNTA { get; set; }
        public virtual CONS_EXP_PREGUNTA CONS_EXP_PREGUNTA { get; set; }
        public virtual EDAD_MADRE_PREGUNTA EDAD_MADRE_PREGUNTA { get; set; }
        public virtual EMB_FAL_PREGUNTA EMB_FAL_PREGUNTA { get; set; }
        public virtual EMB_MES_PREGUNTA EMB_MES_PREGUNTA { get; set; }
        public virtual EMB_SEM_PREGUNTA EMB_SEM_PREGUNTA { get; set; }
        public virtual EST_CIVIL_PREGUNTA EST_CIVIL_PREGUNTA { get; set; }
        public virtual EST_CIVM_PREGUNTA EST_CIVM_PREGUNTA { get; set; }
        public virtual GRU_ED1_PREGUNTA GRU_ED1_PREGUNTA { get; set; }
        public virtual GRU_ED2_PREGUNTA GRU_ED2_PREGUNTA { get; set; }
        public virtual HORA_PREGUNTA HORA_PREGUNTA { get; set; }
        public virtual IDADMISALU_PREGUNTA IDADMISALU_PREGUNTA { get; set; }
        public virtual IDPERTET_PREGUNTA IDPERTET_PREGUNTA { get; set; }
        public virtual IDPROFCER_PREGUNTA IDPROFCER_PREGUNTA { get; set; }
        public virtual MAN_MUER_PREGUNTA MAN_MUER_PREGUNTA { get; set; }
        public virtual MES_PREGUNTA MES_PREGUNTA { get; set; }
        public virtual MINUTOS_PREGUNTA MINUTOS_PREGUNTA { get; set; }
        public virtual MU_PARTO_PREGUNTA MU_PARTO_PREGUNTA { get; set; }
        public virtual MUERTEPORO_PREGUNTA MUERTEPORO_PREGUNTA { get; set; }
        public virtual N_HIJOSM_PREGUNTA N_HIJOSM_PREGUNTA { get; set; }
        public virtual N_HIJOSV_PREGUNTA N_HIJOSV_PREGUNTA { get; set; }
        public virtual NIV_EDUM_PREGUNTA NIV_EDUM_PREGUNTA { get; set; }
        public virtual NIVEL_EDU_PREGUNTA NIVEL_EDU_PREGUNTA { get; set; }
        public virtual PESO_NAC_PREGUNTA PESO_NAC_PREGUNTA { get; set; }
        public virtual PMAN_MUER_PREGUNTA PMAN_MUER_PREGUNTA { get; set; }
        public virtual SEG_SOCIAL_PREGUNTA SEG_SOCIAL_PREGUNTA { get; set; }
        public virtual SEXO_PREGUNTA SEXO_PREGUNTA { get; set; }
        public virtual SIMUERTEPO_PREGUNTA SIMUERTEPO_PREGUNTA { get; set; }
        public virtual SIT_DEFUN_PREGUNTA SIT_DEFUN_PREGUNTA { get; set; }
        public virtual T_GES_PREGUNTA T_GES_PREGUNTA { get; set; }
        public virtual T_PARTO_PREGUNTA T_PARTO_PREGUNTA { get; set; }
        public virtual TIPO_EMB_PREGUNTA TIPO_EMB_PREGUNTA { get; set; }
        public virtual ULTCURFAL_PREGUNTA ULTCURFAL_PREGUNTA { get; set; }
        public virtual ULTCURMAD_PREGUNTA ULTCURMAD_PREGUNTA { get; set; }
    }
}

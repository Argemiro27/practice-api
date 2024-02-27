using System;

namespace Dotnet.Onion.Template.API.DTO.Contrato
{
    public class Exp_Agente_DTO
    {
        public int cod_empresa { get; set; }
        public int cod_filial { get; set; }
        public int num_contrato { get; set; }
        public int num_ano_contrato { get; set; }
        public string num_seq_contrato { get; set; }
        public int cod_contato { get; set; }
        public char? flg_cond_pag { get; set; }
        public double? val_comissao { get; set; }
        public int? num_lanc_custo { get; set; }
        public int handle { get; set; }
        public double val_tot_comissao { get; set; }
        public DateTime? dat_incluido { get; set; }
        public int? han_contrato { get; set; }
        public string nom_contato { get; set; }
    }
}

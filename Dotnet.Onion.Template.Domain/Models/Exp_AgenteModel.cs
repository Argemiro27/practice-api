using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet.Onion.Template.Domain.Models
{
    public class EXP_AGENTE_MODEL
    {
        [Key, Column("COD_EMPRESA", Order = 0)]
        public int cod_empresa { get; set; }

        [Key, Column("COD_FILIAL", Order = 1)]
        public int cod_filial { get; set; }

        [Key, Column("NUM_CONTRATO", Order = 2)]
        public int num_contrato { get; set; }

        [Key, Column("NUM_ANO_CONTRATO", Order = 3)]
        public int num_ano_contrato { get; set; }

        [Key, Column("NUM_SEQ_CONTRATO", Order = 4)]
        [MaxLength(4)]
        public string num_seq_contrato { get; set; }

        [Key, Column("COD_CONTATO", Order = 5)]
        public int cod_contato { get; set; }

        [Column("FLG_COND_PAG")]
        public char? flg_cond_pag { get; set; }

        [Column("VAL_COMISSAO")]
        public double? val_comissao { get; set; }

        [Column("NUM_LANC_CUSTO")]
        public int? num_lanc_custo { get; set; }

        [Column("HANDLE")]
        public int handle { get; set; }

        [Column("VAL_TOT_COMISSAO")]
        public double val_tot_comissao { get; set; }

        [Column("DAT_INCLUIDO")]
        public DateTime? dat_incluido { get; set; }

        [Column("HAN_CONTRATO")]
        public int? han_contrato { get; set; }


    }
}

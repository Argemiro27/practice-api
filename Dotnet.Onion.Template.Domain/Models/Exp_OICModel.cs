using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet.Onion.Template.Domain.Models
{
    public class EXP_OIC_MODEL
    {
        [Key]
        [Column("HANDLE")]
        public int handle { get; set; }

        [Required]
        [Column("COD_EMPRESA")]
        public int cod_empresa { get; set; }

        [Required]
        [Column("COD_FILIAL")]
        public int cod_filial { get; set; }

        [Required]
        [Column("NUM_OIC")]
        public int num_oic { get; set; }

        [Required]
        [Column("NUM_ANO_OIC")]
        public int num_ano_oic { get; set; }

        [Column("QTD_QUILOS")]
        public double? qtd_quilos { get; set; }

        [Column("NOM_CONTRAMARCA")]
        public string nom_contramarca { get; set; }

        [Column("FLG_LOGO")]
        public char? flg_logo { get; set; }

        [Column("DAT_INCLUIDO")]
        public DateTime? dat_incluido { get; set; }

        [Column("HAN_CONTRATO")]
        public int? han_contrato { get; set; }
    }
}

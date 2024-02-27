using System;

namespace Dotnet.Onion.Template.API.DTO.Contrato
{
    public class Exp_OIC_DTO
    {
        public long? handle { get; set; }
        public int? cod_empresa { get; set; }
        public int? cod_filial { get; set; }
        public int? num_oic { get; set; }
        public int? num_ano_oic { get; set; }
        public double? qtd_quilos { get; set; }
        public string? nom_contramarca { get; set; }
        public char? flg_logo { get; set; }
        public DateTime? dat_incluido { get; set; }
        public int? han_contrato { get; set; }
    }
}

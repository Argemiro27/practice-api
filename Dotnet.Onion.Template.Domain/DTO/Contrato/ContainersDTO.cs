using System;

namespace Dotnet.Onion.Template.API.DTO.Contrato
{
    public class ContainersDTO
    {
        public long? handle { get; set; }

        public string? num_container { get; set; }

        public long? qtd_volumes { get; set; }

        public double? qtd_quilos { get; set; }

        public double? qtd_quilos_bruto { get; set; }

        public string? num_sd { get; set; }

        public long? num_oic { get; set; }

        public long? num_ano_oic { get; set; }

        public string? dsc_obs { get; set; }

        public long? han_saida { get; set; }

        public long? num_contador { get; set; }

        public string? num_placa_cav { get; set; }

        public string? nom_marca_cav { get; set; }

        public string? nom_uf_cav { get; set; }

        public string? num_placa_car { get; set; }

        public string? nom_uf_car { get; set; }

        public long? num_tara { get; set; }

        public string? num_lacre_exp { get; set; }

        public string? num_lacre_rf { get; set; }

        public string? num_lacre_armador { get; set; }

        public long? num_conhecimento { get; set; }

        public string? num_scandbag { get; set; }

        public DateOnly? dat_carga { get; set; }

        public DateOnly? dat_saida { get; set; }

        public long? cod_contato { get; set; }

        public DateOnly? dat_vazio { get; set; }
        public DateOnly? dat_cheio { get; set; }
        public string? nom_transportador { get; set; }

        public int? num_tara_container { get; set; }

        public double? qtd_padrao_saca { get; set; }

        //public string? num_po { get; set; }

        //public string? num_batch { get; set; }

    }
}

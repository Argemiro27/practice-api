using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet.Onion.Template.Domain.Models
{
    public class EXP_CONTRATO_MODEL
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("handle")]
        public int handle { get; set; }

        [Column("cod_empresa")]
        public int cod_empresa { get; set; }

        [Column("cod_filial")]
        public int cod_filial { get; set; }

        [Column("num_contrato")]
        public int num_contrato { get; set; }

        [Column("num_ano_contrato")]
        public int num_ano_contrato { get; set; }

        [Column("num_seq_contrato")]
        public string num_seq_contrato { get; set; }

        [Column("num_venda")]
        public int? num_venda { get; set; }

        [Column("num_ano_venda")]
        public int? num_ano_venda { get; set; }

        [Column("dat_emissao")]
        public DateTime? dat_emissao { get; set; }

        [Column("cod_cliente")]
        public int? cod_cliente { get; set; }

        [Column("nom_ref_cli")]
        public string nom_ref_cli { get; set; }

        [Column("dat_periodo_emb")]
        public DateTime? dat_periodo_emb { get; set; }

        [Column("flg_quinzena")]
        public string flg_quinzena { get; set; }

        [Column("cod_vendedor")]
        public int? cod_vendedor { get; set; }

        [Column("cod_embarcador")]
        public int? cod_embarcador { get; set; }

        [Column("dsc_qualidade")]
        public string dsc_qualidade { get; set; }

        [Column("num_ano1_safra1")]
        public int? num_ano1_safra1 { get; set; }

        [Column("num_ano2_safra1")]
        public int? num_ano2_safra1 { get; set; }

        [Column("num_ano1_safra2")]
        public int? num_ano1_safra2 { get; set; }

        [Column("num_ano2_safra2")]
        public int? num_ano2_safra2 { get; set; }

        [Column("qtd_quilos")]
        public double? qtd_quilos { get; set; }

        [Column("cod_condicao")]
        public int? cod_condicao { get; set; }

        [Column("nom_incoterm")]
        public string? nom_incoterm { get; set; }

        [Column("flg_preco")]
        public string? flg_preco { get; set; }

        [Column("flg_fixacao")]
        public string? flg_fixacao { get; set; }

        [Column("dat_a_fixar")]
        public DateTime? dat_a_fixar { get; set; }

        [Column("flg_unid_preco")]
        public string? flg_unid_preco { get; set; }

        [Column("val_diferencial")]
        public double? val_diferencial { get; set; }

        [Column("val_fixado")]
        public double? val_fixado { get; set; }

        [Column("val_preco_ctslb")]
        public double? val_preco_ctslb { get; set; }

        [Column("val_preco_kg")]
        public double? val_preco_kg { get; set; }

        [Column("dat_fixacao")]
        public DateTime? dat_fixacao { get; set; }

        [Column("nom_arbitragem")]
        public string? nom_arbitragem { get; set; }

        [Column("nom_contramarca")]
        public string? nom_contramarca { get; set; }

        [Column("dsc_notas")]
        public string? dsc_notas { get; set; }

        [Column("dsc_alerta")]
        public string? dsc_alerta { get; set; }

        [Column("flg_cancelado")]
        public string? flg_cancelado { get; set; }

        [Column("flg_divisao")]
        public string? flg_divisao { get; set; }


        [Column("nom_origem")]
        public string? nom_origem { get; set; }

        [Column("dat_cancelamento")]
        public DateTime? dat_cancelamento { get; set; }

        [Column("nom_motivo_cancel")]
        public string? nom_motivo_cancel { get; set; }

        [Column("flg_amostra_pre")]
        public string? flg_amostra_pre { get; set; }

        [Column("flg_amostra_emb")]
        public string? flg_amostra_emb { get; set; }

        [Column("dsc_amostra_pre")]
        public string? dsc_amostra_pre { get; set; }

        [Column("dsc_amostra_emb")]
        public string? dsc_amostra_emb { get; set; }

        [Column("dat_inst_emb")]
        public DateTime? dat_inst_emb { get; set; }

        [Column("flg_meio_transp")]
        public string? flg_meio_transp { get; set; }

        [Column("han_porto_emb")]
        public int? han_porto_emb { get; set; }

        [Column("han_porto_desc")]
        public int? han_porto_desc { get; set; }


        [Column("nom_local_entrega")]
        public string? nom_local_entrega { get; set; }

        [Column("nom_destino_final")]
        public string? nom_destino_final { get; set; }


        [Column("cod_agencia_mar")]
        public int? cod_agencia_mar { get; set; }

        [Column("cod_armador")]
        public int? cod_armador { get; set; }

        [Column("nom_navio")]
        public string? nom_navio { get; set; }

        [Column("dat_chegada_bra")]
        public DateTime? dat_chegada_bra { get; set; }

        [Column("dat_saida_bra")]
        public DateTime? dat_saida_bra { get; set; }


        [Column("dat_previsao_dead")]
        public DateTime? dat_previsao_dead { get; set; }

        [Column("dat_chegada_dest")]
        public DateTime? dat_chegada_dest { get; set; }

        [Column("dat_carga")]
        public DateTime? dat_carga { get; set; }

        [Column("num_contrato_serv")]
        public string? num_contrato_serv { get; set; }

        [Column("flg_frete_conta")]
        public string? flg_frete_conta { get; set; }

        [Column("val_frete")]
        public double? val_frete { get; set; }

        [Column("dsc_obs_frete")]
        public string? dsc_obs_frete { get; set; }

        [Column("cod_despachante")]
        public int? cod_despachante { get; set; }

        [Column("qtd_volumes")]
        public int? qtd_volumes { get; set; }

        [Column("cod_embalagem")]
        public int? cod_embalagem { get; set; }

        [Column("flg_tipo_emb")]
        public string? flg_tipo_emb { get; set; }

        [Column("nom_outra_emb")]
        public string? nom_outra_emb { get; set; }

        [Column("flg_tp_container")]
        public string? flg_tp_container { get; set; }

        [Column("qtd_containers")]
        public int? qtd_containers { get; set; }

        [Column("flg_estufagem")]
        public string? flg_estufagem { get; set; }

        [Column("cod_local_estuf")]
        public int? cod_local_estuf { get; set; }

        [Column("dsc_produto_bl")]
        public string? dsc_produto_bl { get; set; }

        [Column("dsc_obs_embarque")]
        public string? dsc_obs_embarque { get; set; }

        [Column("cod_consignatario")]
        public int? cod_consignatario { get; set; }

        [Column("cod_for_account")]
        public int? cod_for_account { get; set; }

        [Column("nom_outro_consig")]
        public string? nom_outro_consig { get; set; }

        [Column("dat_res_praca")]
        public DateTime? dat_res_praca { get; set; }

        [Column("dsc_reserva_praca")]
        public string? dsc_reserva_praca { get; set; }

        [Column("num_booking")]
        public string? num_booking { get; set; }

        [Column("dat_dead_doc")]
        public DateTime? dat_dead_doc { get; set; }

        [Column("dat_dead_merc")]
        public DateTime? dat_dead_merc { get; set; }

        [Column("dat_dead_semana")]
        public DateTime? dat_dead_semana { get; set; }

        [Column("nom_retira_container")]
        public string? nom_retira_container { get; set; }

        [Column("nom_entrega_container")]
        public string? nom_entrega_container { get; set; }

        [Column("cod_transportador")]
        public int? cod_transportador { get; set; }

        [Column("qtd_saida")]
        public double? qtd_saida { get; set; }

        [Column("dat_saida")]
        public DateTime? dat_saida { get; set; }

        [Column("num_bl")]
        public string? num_bl { get; set; }

        [Column("dat_bl")]
        public DateTime? dat_bl { get; set; }

        [Column("dat_rec_bl")]
        public DateTime? dat_rec_bl { get; set; }

        [Column("num_dhl_doc")]
        public string? num_dhl_doc { get; set; }

        [Column("dat_envio_courier")]
        public DateTime? dat_envio_courier { get; set; }

        [Column("dat_envio_doc")]
        public DateTime? dat_envio_doc { get; set; }

        [Column("num_viagem")]
        public string? num_viagem { get; set; }

        [Column("num_prior_notice")]
        public string? num_prior_notice { get; set; }

        [Column("dat_prior_notice")]
        public DateTime? dat_prior_notice { get; set; }

        [Column("dsc_obs_bl")]
        public string? dsc_obs_bl { get; set; }

        [Column("dsc_obs_aplic")]
        public string? dsc_obs_aplic { get; set; }

        [Column("flg_alfandega")]
        public string? flg_alfandega { get; set; }

        [Column("dat_alfandega")]
        public DateTime? dat_alfandega { get; set; }

        [Column("num_cda")]
        public string? num_cda { get; set; }

        [Column("flg_exportado")]
        public string? flg_exportado { get; set; }

        [Column("cod_certificador")]
        public int? cod_certificador { get; set; }

        [Column("flg_fairtrade")]
        public string? flg_fairtrade { get; set; }

        [Column("flg_tp_amostra")]
        public string? flg_tp_amostra { get; set; }

        [Column("num_amostra")]
        public int? num_amostra { get; set; }

        [Column("num_ano_amostra")]
        public int? num_ano_amostra { get; set; }

        [Column("hor_dead_merc")]
        public string? hor_dead_merc { get; set; }

        [Column("hor_dead_doc")]
        public string? hor_dead_doc { get; set; }

        [Column("cod_tipo_cafe")]
        public int? cod_tipo_cafe { get; set; }

        [Column("cod_terminal_ret")]
        public int? cod_terminal_ret { get; set; }

        [Column("cod_terminal_ent")]
        public int? cod_terminal_ent { get; set; }

        [Column("cod_padrao")]
        public int? cod_padrao { get; set; }

        [Column("hnd_peneira")]
        public int? hnd_peneira { get; set; }

        [Column("flg_sinc_web")]
        public string? flg_sinc_web { get; set; }

        [Column("qtd_kg_saldo")]
        public double? qtd_kg_saldo { get; set; }

        [Column("dat_prev_receb")]
        public DateTime? dat_prev_receb { get; set; }

        [Column("flg_meio_receb")]
        public string? flg_meio_receb { get; set; }

        [Column("flg_venda_ext")]
        public string? flg_venda_ext { get; set; }

        [Column("han_bolsa")]
        public int? han_bolsa { get; set; }

        [Column("dat_env_booking")]
        public DateTime? dat_env_booking { get; set; }

        [Column("dat_env_shipping")]
        public DateTime? dat_env_shipping { get; set; }

        [Column("num_cnpj_reserva")]
        public string? num_cnpj_reserva { get; set; }

        [Column("num_solicitacao_reserva")]
        public string? num_solicitacao_reserva { get; set; }

        [Column("num_autorizacao_reserva")]
        public string? num_autorizacao_reserva { get; set; }

        [Column("qtd_cotacao_frete")]
        public int? qtd_cotacao_frete { get; set; }

        [Column("nom_courier")]
        public string? nom_courier { get; set; }

        [Column("han_banco_benef")]
        public int? han_banco_benef { get; set; }

        [Column("han_agencia_benef")]
        public int? han_agencia_benef { get; set; }

        [Column("num_conta_banc")]
        public string? num_conta_banc { get; set; }

        [Column("han_banco_inter")]
        public int? han_banco_inter { get; set; }

        [Column("han_agencia_inter")]
        public int? han_agencia_inter { get; set; }

        [Column("qtd_padrao_saca")]
        public double? qtd_padrao_saca { get; set; }

        [Column("flg_especie")]
        public string flg_especie { get; set; }

        [Column("val_const_bolsa")]
        public double? val_const_bolsa { get; set; }

        [Column("han_modal_emb")]
        public int? han_modal_emb { get; set; }

        [Column("qtd_palet")]
        public int? qtd_palet { get; set; }

        [Column("qtd_forracao")]
        public int? qtd_forracao { get; set; }

        [Column("flg_canal")]
        public string? flg_canal { get; set; }

        [Column("han_navio")]
        public int? han_navio { get; set; }

        [Column("valor_total_dolar")]
        public double? valor_total_dolar { get; set; }

        [Column("num_saca_libra")]
        public double? num_saca_libra { get; set; }

        [Column("flg_tipo_bl")]
        public string? flg_tipo_bl { get; set; }

        [Column("dat_dead_vgm")]
        public DateTime? dat_dead_vgm { get; set; }

        [Column("hor_dead_vgm")]
        public string? hor_dead_vgm { get; set; }

        [Column("dat_incluido")]
        public DateTime? dat_incluido { get; set; }

        [Column("dat_fixacao_fnd")]
        public DateTime? dat_fixacao_fnd { get; set; }

        [Column("num_certificacao")]
        public string? num_certificacao { get; set; }

        [Column("qtd_lote_fixar")]
        public int? qtd_lote_fixar { get; set; }

        [Column("nom_contrato_format")]
        public string nom_contrato_format { get; set; }

        [Column("dat_ent_navio")]
        public DateTime? dat_ent_navio { get; set; }

        [Column("dat_dead_isf")]
        public DateTime? dat_dead_isf { get; set; }

        [Column("hor_dead_isf")]
        public string? hor_dead_isf { get; set; }

        [Column("qtd_dia_fixar")]
        public int? qtd_dia_fixar { get; set; }

    }
}

using System.Collections.Generic;
using System;

namespace Dotnet.Onion.Template.Domain.DAO
{
    public class Exp_ContratoDAO
    {
        #region ----> EXP_CONTRATOI <----
        public int? cod_cliente { get; set; }  //--> Código: Cliente
        public string? nom_cliente { get; set; }  //--> Nome: Cliente
        public string? nom_ref_cli { get; set; }  //--> Referência Cliente
        public DateOnly? dat_periodo_emb { get; set; } //--> Data período de embarque
        public string? flg_tp_amostra { get; set; }  //--> Tipo de amostra
        public int? cod_vendedor { get; set; }
        public string? nom_vendedor { get; set; }
        public int? cod_embarcador { get; set; }
        public string? nom_embarcador { get; set; }
        public string? cod_certificador { get; set; }
        public string? nom_certificador { get; set; }
        public int? cod_tipo_cafe { get; set; }
        public string? cod_nbm { get; set; }
        public string? flg_especie { get; set; }
        public string? nom_especie { get; set; }
        public int? hnd_peneira { get; set; }
        public string? nom_peneira { get; set; }
        public int? cod_padrao { get; set; }
        public string? dsc_qualidade { get; set; }
        public double? qtd_sacas { get; set; }
        public double? qtd_padrao_saca { get; set; }  // --> peso em kg por saca

        public double? num_saca_libra { get; set; } //--> num sacas Libra

        //public double num_toneladas { get; set; }//--> Toneladas

        public string? nom_incoterm { get; set; }
        public double? qtd_quilos { get; set; }


        public int? num_ano1_safra1 { get; set; } //--> ano 1 safra 1
        public int? num_ano2_safra1 { get; set; } //--> ano 2 safra 1
        public int? num_ano1_safra2 { get; set; } //--> ano 1 safra 2
        public int? num_ano2_safra2 { get; set; } //--> ano 2 safra 2
        public List<Exp_Agente_DAO> agentes { get; set; }
        #endregion

        #region ---> EXP_CONTRATOII <---


        public string? flg_preco { get; set; } // "F": Fixo; "A": A fixar;

        public float? val_unitario { get; set; } // Valor unitário
        public float? valor_total_dolar { get; set; } // Valor total em dólar
        public int? han_bolsa { get; set; } // Bolsa

        public string? flg_fixacao { get; set; } // "I": A fixar pelo importador; "E": A fixar pelo exportador;

        public int? qtd_dia_fixar { get; set; } // Dias fixados

        //// Falta mês e ano de fixação

        public double? val_diferencial { get; set; } // Valor diferencial

        public double? val_fixado { get; set; } // Valor fixado


        public DateOnly? dat_fixacao { get; set; } // Data fixacao

        public DateOnly? dat_fixacao_fnd { get; set; } // Data fnd

        public int? qtd_lote_fixar { get; set; }

        public string? nom_contramarca { get; set; }

        public List<Exp_OIC_DAO> oics { get; set; }
        public string? dsc_notas { get; set; }
        #endregion

        #region --> INSTRUÇÃO DE EMBARQUE I<--

        //public string? flg_instrucao { get; set; }
        public DateOnly? dat_inst_emb { get; set; }
        public string? flg_meio_transp { get; set; }

        public string? nom_meio_transp { get; set; }
        public long? han_porto_emb { get; set; }

        public string? nom_porto_emb { get; set; }
        public long? han_porto_desc { get; set; }
        public string? nom_porto_desc { get; set; }
        public long? cod_agencia_mar { get; set; }
        public string? nom_agencia_mar { get; set; }

        public long? cod_armador { get; set; }

        public string? nom_armador { get; set; }

        public string? nom_local_entrega { get; set; }

        public string? nom_destino_final { get; set; }

        public long? han_navio { get; set; }

        public string? nom_navio { get; set; }

        public DateOnly? dat_chegada_bra { get; set; }
        public DateOnly? dat_saida_bra { get; set; }

        public DateOnly? dat_prev_estufagem { get; set; } // Dat Carga

        public string? num_viagem { get; set; }

        public DateOnly? dat_previsao_dead { get; set; } // Previsão Deadline 

        public DateOnly? dat_chegada_dest { get; set; }

        public string? num_contrato_serv { get; set; }

        public string? flg_frete_conta { get; set; }

        public string? nom_frete_conta { get; set; }
        public double? val_frete { get; set; }

        public long? qtd_cotacao_frete { get; set; } // Quantidade de containers

        public string? dsc_obs_frete { get; set; }

        public long? cod_despachante { get; set; }

        public string? nom_despachante { get; set; }

        #endregion

        #region --> RESERVA/ CERTIFICADO <--
        public string? num_cnpj_reserva { get; set; }

        public string? num_solicitacao_reserva { get; set; }

        public string? num_autorizacao_reserva { get; set; }

        public string? dsc_reserva_praca { get; set; }

        public string? num_booking { get; set; }


        #region --> Deadline Draft <--

        public DateOnly? dat_dead_doc { get; set; }
        public string? hor_dead_doc { get; set; }
        public long? cod_terminal_ret { get; set; }
        public string? nom_terminal_ret { get; set; }

        #endregion

        #region --> Deadline Café <--

        public DateOnly? dat_dead_merc { get; set; }
        public string? hor_dead_merc { get; set; }
        public long? cod_terminal_ent { get; set; }
        public string? nom_terminal_ent { get; set; }

        #endregion



        #region --> Deadline VGM <--

        public DateOnly? dat_dead_vgm { get; set; }
        public string? hor_dead_vgm { get; set; }

        #endregion



        #region --> Deadline ISF <--
        public DateOnly? dat_dead_isf { get; set; }
        public string? hor_dead_isf { get; set; }

        #endregion


        public List<CertificadosDAO> certificados { get; set; }
        #endregion

        #region ---> TRANSPORTE <---

        public long? cod_transportador { get; set; }

        public string? nom_transportador { get; set; }

        public double? qtd_saida { get; set; }

        public double? Devolucao { get; set; }

        public List<ContainersDAO> containers { get; set; }

        public string? num_bl { get; set; }
        public string? flg_tipo_bl { get; set; }
        public DateOnly? dat_bl { get; set; }

        public DateOnly? dat_rec_bl { get; set; }

        public string? num_courier { get; set; } // num_dhl_doc
        public DateOnly? dat_envio_doc { get; set; }
        public DateOnly? dat_ent_navio { get; set; }
        public string? nom_courier { get; set; }

        public string? dsc_obs_bl { get; set; }

        public string? flg_alfandega { get; set; }

        public DateOnly? dat_alfandega { get; set; } // depósito

        public string? num_cda { get; set; }

        public string? num_prior_notice { get; set; }

        public DateOnly? dat_prior_notice { get; set; }

        #endregion
    }

}

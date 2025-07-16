using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_IA.Classes
{
    public class Cadastro_das_Entradas
    {


        /// <summary>
        /// CAMPO DE CADASTRO DAS ENTRADAS
        /// </summary>


        private int codigo_compra;
        private DateTime data_emissao;
        private DateTime data_entrada;
        private decimal icms;
        private string numero_nota_fiscal;
        private decimal valor_nota;
        private decimal valor_real;
        private string fornecedor;
        private string nome_transportadora;
        private string numero_conhecimento;
        private string numero_bloquete;
        private decimal valor;
        private DateTime? vencimeto_2;
        private decimal total_frete;
        private decimal icms_substituicao;
        private bool lacrar;
        private string pedido_fabrica;
        private bool atualizar_estoque;
        private string lancamento_usuario;
        private DateTime lancamento_data_hora;
        private string loja_origem;
        private string cfop;
        private bool atualizar_preco;
        private bool compra_baixada;
        private string danfe;
        private decimal outras_despesas;
        private string nfe_modelo;
        private string nfe_serie;
        private string nfe_sub_serie;
        private string nfe_ch;
        private decimal valor_fornecido;
        private decimal valor_servico_nao_tributado;
        private decimal valor_terceiros;
        private decimal valor_pis;
        private decimal valor_cofins;
        private string tipo_ligacao;
        private string grupo_tensao;
        private decimal base_icmsst;
        private decimal valor_seguro;
        private decimal desconto_nota;
        private decimal base_icms_nota;
        private decimal aliq_icms_nota;
        private decimal icms_nota;
        private decimal valor_prod;
        private decimal vl_seguro;
        private decimal desconto;
        private string nfe_chave;
        private string nfe_protocolo;
        private decimal outros;
        private string importacao_doc;
        private string importacao_numero_doc;
        private decimal importacao_vlcofins;
        private string importacao_drawback;
        private decimal valor_pis_ret;
        private decimal valor_cofins_ret;
        private decimal valor_base_cofins;
        private decimal valor_iss;
        private string ind_pgto;
        private string nfsech;
        private string natbccred;
        private string cstpis;
        private string tp_assinante;
        private bool validador_selecionar;
        private decimal valor_aliq_pis;
        private decimal valor_aliq_cofins;
        private string frete_conta;
        private int prazo_nf;
        private string finalidade_nf;
        private string inf_cpl;
        private string inf_ad_fisco;
        private string seg_cod_barra;
        private bool compra_de_veiculo;
        private bool ignorar_icms_desonerado;
        private string detalhes_imposto_manual;
        private bool compra_cancelado;
     


    }
}

using Locadora.Apresentacao.WinForm.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Apresentacao.WinForm.ModuloTaxa
{
    public class ConfigurarToolBoxTaxa : ConfigurarToolboxBase
    {
        public override string TipoCadastro => "Cadastro Taxa";

        public override string TooltipInserir => "Inserir Nova Taxa";

        public override string TooltipEditar => "Editar Taxa";

        public override string TooltipExcluir =>"Excluir Taxa" ;
    }
}

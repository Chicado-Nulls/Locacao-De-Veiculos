using Locadora.Apresentacao.WinForm.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Apresentacao.WinForm.ModuloCondutor
{
    public class ConfigurarToolboxCondutor : ConfigurarToolboxBase
    {
        public override string TipoCadastro => "Cadastro Condutor";

        public override string TooltipInserir => "Inserir condutor";

        public override string TooltipEditar => "Editar condutor";

        public override string TooltipExcluir => "Excluir condutor";
    }
}

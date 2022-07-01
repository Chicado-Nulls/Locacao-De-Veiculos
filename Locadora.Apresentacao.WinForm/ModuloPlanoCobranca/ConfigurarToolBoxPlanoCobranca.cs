using Locadora.Apresentacao.WinForm.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Apresentacao.WinForm.ModuloPlanoCobranca
{
    public class ConfigurarToolBoxPlanoCobranca : ConfigurarToolboxBase
    {
        public override string TipoCadastro => "Plano De Cobrança";

        public override string TooltipInserir => "Inserir Plano De Cobrança";

        public override string TooltipEditar => "Editar Grupo De Cobrança";

        public override string TooltipExcluir => "Excluir Plano De Cobrança";
    }
}

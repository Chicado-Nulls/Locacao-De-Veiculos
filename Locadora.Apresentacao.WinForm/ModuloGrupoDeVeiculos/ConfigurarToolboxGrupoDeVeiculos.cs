using Locadora.Apresentacao.WinForm.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Apresentacao.WinForm.ModuloGrupoDeVeiculos
{
    public class ConfigurarToolboxGrupoDeVeiculos : ConfigurarToolboxBase
    {
        public override string TipoCadastro => "Cadastro Grupo De Veiculos";

        public override string TooltipInserir =>"Inserir Um Grupo De Veiculos";

        public override string TooltipEditar => "Editar Um Grupo De Veiculos";

        public override string TooltipExcluir => "Excluir Um Grupo De Veiculos";
    }
}

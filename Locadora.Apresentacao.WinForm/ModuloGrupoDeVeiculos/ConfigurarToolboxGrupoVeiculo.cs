using Locadora.Apresentacao.WinForm.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Apresentacao.WinForm.ModuloGrupoDeVeiculos
{
    public class ConfigurarToolboxGrupoVeiculo : ConfigurarToolboxBase
    {
        public override string TipoCadastro => "Grupo De Veiculos";

        public override string TooltipInserir =>"Inserir Grupo De Veiculos";

        public override string TooltipEditar => "Editar Grupo De Veiculos";

        public override string TooltipExcluir => "Excluir Grupo De Veiculos";
    }
}

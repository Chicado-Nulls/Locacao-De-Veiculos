﻿using Locadora.Apresentacao.WinForm.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora.Apresentacao.WinForm.ModuloFuncionario
{
    public class ControladorFuncionario : ControladorBase
    {
        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override void Inserir()
        {
            throw new NotImplementedException();
        }

        public override ConfigurarToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfigurarTollboxFuncionario();
        }

        public override UserControl ObtemListagem()
        {
            throw new NotImplementedException();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Dominio.Compartilhado
{
    public class NaoPodeExcluirEsteRegistroException : Exception
    {
        public NaoPodeExcluirEsteRegistroException(Exception ex) : base("", ex)
        {

        }
    }
}

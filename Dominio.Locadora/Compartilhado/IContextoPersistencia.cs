using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Dominio.Compartilhado
{
    public interface IContextoPersistencia
    {
        void GravarDados();
    }
}

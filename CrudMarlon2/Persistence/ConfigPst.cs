using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudMarlon2.Persistence
{
    interface ConfigPst
    {
        String Inserir();
        String Pesquisar();
        String Alterar();
        String Excluir();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudMarlon2.Persistence
{
    class PessoaPst : Model.Pessoa, ConfigPst
    {
        public string Alterar()
        {
            String Query = "UPDATE CLIENTE " +
                            " SET NOME = " + Nome + ", ENDERECO = " + Endereco + ", EMAIL =" + Email + ", TELEFONE =" + Telefone + "" + "WHERE =" + Id;

            return Query;
        }

        public string Excluir()
        {
            String Query = "DELETE TABLE CLIENTE WHERE ID = " + Id;

            return Query;
        }

        public string Inserir()
        {
            String Query = "INSERT INTO CLIENTE (NOME, ENDERECO, EMAIL, TELEFONE) VALUES(" + "'" + Nome + "'" + ", " + "'" + Endereco + "'" + ", " + "'" + Email + "'" + "," + "'" + Telefone + "'" + ")";

            return Query;
                   

        }

        public string Pesquisar()
        {
            String Query = "SELECT * FROM CLIENTE ";

            return Query;
        }
    }
}

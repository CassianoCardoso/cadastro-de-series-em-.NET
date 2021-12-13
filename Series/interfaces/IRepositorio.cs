using System;
using System.Collections.Generic;
using System.Text;

namespace Series.interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Listta();
        T RetornaPorId(int id);

        void insere(T entidade);

        void Exclui(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();
    }

}

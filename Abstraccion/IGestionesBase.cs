using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    public interface IGestionesBase<T>
    {
        bool Baja(T objeto);

        bool Guardado(T objeto);

        List<T> listarTodo(); 


    }
}

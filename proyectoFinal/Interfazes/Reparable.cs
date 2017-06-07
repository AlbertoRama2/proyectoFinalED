using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinal.models
{
    interface Reparable
    {
        //atributos
        float precio();

        //metodos
        void reparar(float reparacion);
    }
}

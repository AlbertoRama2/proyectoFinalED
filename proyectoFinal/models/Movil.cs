using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinal.models
{
    class Movil:Dispositivo
    {
        public Movil(string marca, string modelo, float pulgadas, string sistemaOperativo, float precio) : base(marca, modelo, pulgadas, sistemaOperativo, precio)
        {

        }
    }
}

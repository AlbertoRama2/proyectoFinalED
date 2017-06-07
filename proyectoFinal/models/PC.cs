using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinal.models
{
    class PC:Dispositivo
    {
        public string FuenteAlimentacion { get; set; }
        public List<string> Piezas { get; set; }
        public string RAM { get; set; }
        public string Procesador { get; set; }

        public PC(string marca, string modelo, string sistemaOperativo, float precio) : base(marca, modelo,sistemaOperativo, precio)
        {

        }
    }
}

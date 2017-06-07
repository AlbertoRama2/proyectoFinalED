using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinal.models
{
    class Portatil
    {
        public string SistemaOperativo { get; set; }
        public string RAM { get; set; }
        public string Procesador { get; set; }

        public Portatil(string marca, string modelo, float pulgadas, string sistemaOperativo, float precio) : base(marca, modelo,pulgadas, sistemaOperativo, precio)
        {

        }
    }
}

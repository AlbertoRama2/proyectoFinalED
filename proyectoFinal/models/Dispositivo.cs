using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinal.models
{
    abstract class Dispositivo : Reparable
    {
        //atributos
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public float Pulgadas { get; set; }
        public string SistemaOperativo { get; set; }
        public float Precio { get; set; }

        //constructor
        public Dispositivo(string marca,string modelo,float pulgadas,string sistemaOperativo, float precio)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Pulgadas = pulgadas;
            this.SistemaOperativo = sistemaOperativo;
            this.Precio = precio;
        }

        public Dispositivo(string marca, string modelo, string sistemaOperativo, float precio)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.SistemaOperativo = sistemaOperativo;
            this.Precio = precio;
        }



        //Metodos
        public float precio()
        {
            throw new NotImplementedException();
        }

        public void reparar(float reparacion)
        {
            throw new NotImplementedException();
        }

        public virtual string ToString(string generarMAC)
        {
            return String.Format("{0},{1},{2},{3},{4}", Marca, Modelo, Pulgadas, SistemaOperativo, Precio);
        }
        
    }
}

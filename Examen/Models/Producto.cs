using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen.Models
{
    public class Producto
    {
        /// <summary>
        /// id=primary key
        /// </summary>
        public double ID { get; set; }
        public string nombre;
        public string marca;
        public string familia;
        public string casafabricacion;
        public string tipounidad;
        public string departamento;
        public bool activo;
        public DateTime fechaingreso;
        public double unidad;
        public double impuesto;
    }
}
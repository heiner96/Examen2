using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen.Models
{
    public class Cliente
    {
        /// <summary>
        /// primary key=ID/cedula
        /// </summary>
        public double ID { get; set; }
        public string nombre;
        public string apellido;
        public DateTime fechanacimiento;
        public string direccion;
        public char estadocivil;
        public char sexo;
        public DateTime fechaingreso;
        public string tipo;
        public double descuento;
    }
}
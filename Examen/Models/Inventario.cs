using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen.Models
{
    public class Inventario
    {
        /// <summary>
        /// id/primary
        /// </summary>
        public double ID { get; set; }
        public double idproducto;
        public double cantidad;
        public double cantidadminima;
        public double cantidadmaxima;
        public double gravadoexcepto;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GloboProyect.Models
{
    public class Proyecto
    {
        public int idCliente { get; set; }
        public int idTipoDeProyecto { get; set; }
        public string sitio { get; set; }
        public string nombreDireccion { get; set; }
        public int numeroDireccion { get; set; }
        public int idLiderProyecto { get; set; }
        public DateTime fechaInicioEstimada { get; set; }
    }
}
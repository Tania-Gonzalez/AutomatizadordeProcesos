//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoResidencias
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reportes
    {
        public int ID_Reportes { get; set; }
        public int ID_Avance { get; set; }
        public string Mes_Entrega { get; set; }
        public System.DateTime Fecha_Entrega { get; set; }
    
        public virtual Avance Avance { get; set; }
    }
}

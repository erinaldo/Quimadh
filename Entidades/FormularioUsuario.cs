//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class FormularioUsuario
    {
        public long idFormulario { get; set; }
        public int idUsuario { get; set; }
        public int id { get; set; }
    
        public virtual Formulario Formulario { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}

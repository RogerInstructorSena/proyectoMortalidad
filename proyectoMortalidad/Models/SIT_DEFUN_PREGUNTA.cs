//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace proyectoMortalidad.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SIT_DEFUN_PREGUNTA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SIT_DEFUN_PREGUNTA()
        {
            this.Variable = new HashSet<Variable>();
        }
    
        public decimal sitDefunPreguntaId { get; set; }
        public string sitDefunPreguntaNombre { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Variable> Variable { get; set; }
    }
}

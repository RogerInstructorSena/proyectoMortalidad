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
    
    public partial class C_MCM1_PREGUNTA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_MCM1_PREGUNTA()
        {
            this.Variable = new HashSet<Variable>();
        }
    
        public string cMcm1PreguntaId { get; set; }
        public string cMcm1PreguntaNombre { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Variable> Variable { get; set; }
    }
}

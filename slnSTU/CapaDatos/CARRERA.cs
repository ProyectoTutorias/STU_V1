//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class CARRERA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CARRERA()
        {
            this.DOCENTE = new HashSet<DOCENTE>();
        }
    
        public int ID_CARRERA { get; set; }
        public int ID_FACULTAD { get; set; }
        public int CODIGOAREACARRERA { get; set; }
        public string CODIGOCARRERA { get; set; }
        public string NOMBRECARRERA { get; set; }
        public string CODIGOFACULTADAREACARRERA { get; set; }
    
        public virtual FACULTAD FACULTAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DOCENTE> DOCENTE { get; set; }
    }
}



namespace EXFIN
{
    using System;
    using System.Collections.Generic;
    
    public partial class ALUMNOS
    {
        public int ID { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDOS { get; set; }
        public string CARNET { get; set; }
        public Nullable<int> IDCURSO { get; set; }
        public string ESTADO { get; set; }
    
        public virtual CURSO CURSO { get; set; }
    }
}

namespace service_lanche.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class clientes
    {
        public int id { get; set; }

        [StringLength(180)]
        public string nome { get; set; }

        public string endereco { get; set; }

        public string referencia { get; set; }

        [StringLength(150)]
        public string cel { get; set; }

        [StringLength(180)]
        public string email { get; set; }

        [StringLength(180)]
        public string senha { get; set; }
    }
}

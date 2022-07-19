namespace service_lanche.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class registroVendas
    {
        public int id { get; set; }

        [StringLength(180)]
        public string nome { get; set; }

        public string endereco { get; set; }

        [StringLength(150)]
        public string cel { get; set; }

        public string pedido { get; set; }

        [StringLength(150)]
        public string data { get; set; }

        [StringLength(150)]
        public string hora { get; set; }

        [StringLength(150)]
        public string total { get; set; }
    }
}

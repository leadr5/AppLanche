namespace service_lanche.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("adicional")]
    public partial class adicional
    {
        public int id { get; set; }

        public string adicionais { get; set; }

        [StringLength(150)]
        public string precoAdicionais { get; set; }
    }
}

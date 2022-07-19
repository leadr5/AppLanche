namespace service_lanche.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class combos
    {
        public int id { get; set; }

        public string combo { get; set; }

        public string imgCombo { get; set; }

        [StringLength(150)]
        public string precoCombo { get; set; }
    }
}

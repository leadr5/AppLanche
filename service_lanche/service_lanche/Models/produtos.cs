namespace service_lanche.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class produtos
    {
        public int id { get; set; }

        [StringLength(150)]
        public string produto { get; set; }

        public string imgProduto { get; set; }

        [StringLength(150)]
        public string precoProduto { get; set; }

        public string descricaoProduto { get; set; }

        public string extra { get; set; }
    }
}

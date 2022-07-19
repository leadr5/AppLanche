namespace service_lanche.Models
{
    using System;
    using System.Collections.Generic;

    public partial class produtos
    {
        public int id { get; set; }
        public string produto { get; set; }
        public string imgProduto { get; set; }
        public string precoProduto { get; set; }
        public string descricaoProduto { get; set; }
        public string extra { get; set; }
    }
}

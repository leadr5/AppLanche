namespace service_lanche.Models
{
    using System;
    using System.Collections.Generic;

    public partial class clientes
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
        public string referencia { get; set; }
        public string cel { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
    }
}

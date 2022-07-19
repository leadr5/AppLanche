namespace service_lanche.Models
{
    using System;
    using System.Collections.Generic;

    public partial class registroVendas
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
        public string cel { get; set; }
        public string pedido { get; set; }
        public string data { get; set; }
        public string hora { get; set; }
        public string total { get; set; }
    }
}

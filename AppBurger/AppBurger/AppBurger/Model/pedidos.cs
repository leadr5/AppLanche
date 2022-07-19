namespace service_lanche.Models
{
    using System;
    using System.Collections.Generic;

    public partial class pedidos
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
        public string referencia { get; set; }
        public string cel { get; set; }
        public string pedido { get; set; }
        public string adicional { get; set; }
        public string obsLanche { get; set; }
        public string dataPedido { get; set; }
        public string horaPdido { get; set; }
        public string totalPedido { get; set; }
        public string tipoPagamento { get; set; }
        public string obsPagamento { get; set; }
        public string recebido { get; set; }
        public string extra { get; set; }
    }
}

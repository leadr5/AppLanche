namespace service_lanche.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pedidos
    {
        public int id { get; set; }

        [StringLength(180)]
        public string nome { get; set; }

        public string endereco { get; set; }

        public string referencia { get; set; }

        [StringLength(150)]
        public string cel { get; set; }

        [StringLength(180)]
        public string pedido { get; set; }

        [StringLength(180)]
        public string adicional { get; set; }

        public string obsLanche { get; set; }

        [StringLength(150)]
        public string dataPedido { get; set; }

        [StringLength(150)]
        public string horaPdido { get; set; }

        [StringLength(150)]
        public string totalPedido { get; set; }

        [StringLength(150)]
        public string tipoPagamento { get; set; }

        public string obsPagamento { get; set; }

        [StringLength(150)]
        public string recebido { get; set; }

        public string extra { get; set; }
    }
}

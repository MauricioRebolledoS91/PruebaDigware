namespace Base.API.Entidades.FacturaControl
{
    using Base.Transversal.DTO.EntidadRepositorio;
    using System;
    public class FacturaControlador : IFacturaDTO
    {
        public int IdFactura { get; set; }
        public int? IdCliente { get; set; }
        public DateTime? Fecha { get; set; }
    }
}

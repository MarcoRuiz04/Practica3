namespace Practica3
{
    class Articulo
    {
        double Preciofinal = 0;
        double Des = 0;

        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        public double Descuento { get; set; }

        public Articulo(string descripcion, double precio, double descuento, int cantidad)
        {
            Descripcion = descripcion;
            Precio = precio;
            Descuento = descuento;
            Cantidad = cantidad;
        }


        internal double CalcularPrecioDescuento()
        {
            return Precio - (Precio * Descuento);
        }

        internal double CalcularIVA()
        {
            Des = CalcularPrecioDescuento();
            Preciofinal = Des + (Des * 0.15);
            return Preciofinal;
        }

    }
}
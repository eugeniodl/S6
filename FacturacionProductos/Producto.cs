public interface IProducto
{
    public string Nombre { get; set; }
    public decimal PrecioBase { get; set; }
    decimal CalcularPrecioFinal();
}

public interface IProductoPerecedero : IProducto
{
    DateTime FechaCaducidad { get; set; }
}

public abstract class Producto : IProducto
{
    public string Nombre { get; set; }
    public decimal PrecioBase { get; set; }

    protected Producto(string nombre, decimal precioBase)
    {
        Nombre = nombre;
        PrecioBase = precioBase;
    }
    public abstract decimal CalcularPrecioFinal();
}

public class ProductoGeneral : Producto
{
    public ProductoGeneral(string nombre, decimal precioBase) 
        : base(nombre, precioBase)
    {
    }

    public override decimal CalcularPrecioFinal()
    {
        return PrecioBase;
    }
}

public class ProductoElectronico : Producto
{
    public ProductoElectronico(string nombre, decimal precioBase) 
        : base(nombre, precioBase)
    {
    }

    public override decimal CalcularPrecioFinal()
    {
        return PrecioBase * 1.15m;
    }
}

public class ProductoPerecedero : Producto, IProductoPerecedero
{
    public DateTime FechaCaducidad { get; set; }

    public ProductoPerecedero(string nombre, decimal precioBase,
        DateTime fechaCaducidad) 
        : base(nombre, precioBase)
    {
        FechaCaducidad = fechaCaducidad;
    }

    public override decimal CalcularPrecioFinal()
    {
        if (FechaCaducidad < DateTime.Now.AddDays(7))
        {
            return PrecioBase * 0.8m;
        }
        return PrecioBase;
    }
}

public class ProductoConDescuento : Producto
{
    public new string Nombre = "Descuento Especial";
    public ProductoConDescuento(string nombre, decimal precioBase) 
        : base(nombre, precioBase)
    {
    }

    public override decimal CalcularPrecioFinal()
    {
        return PrecioBase * 0.9m;
    }
}
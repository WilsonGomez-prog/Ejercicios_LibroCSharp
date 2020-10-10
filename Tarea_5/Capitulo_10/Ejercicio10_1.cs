using System;

public class Ejercicio10_1
{
    public Ejercicio10_1()
    {

    }
}


class Producto
{
    public string Nombre { get; set; }
    public int codigoProducto { get; set; }
    public int CantidadProducto { get; set; }
    public string Descripcion { get; set; }
    public double PrecioUnitario { get; set; }

    public Producto()
    {
        Nombre = " ";
        codigoProducto = 0;
        CantidadProducto = 0;
        Descripcion = "";
        PrecioUnitario = 0.0;
    }

    public Producto(string NombreProd, int CodigoProd, string DescripcionProd, double Precio)
    {
        Nombre = NombreProd;
        codigoProducto = CodigoProd;
        CantidadProducto = 1;
        Descripcion = DescripcionProd;
        PrecioUnitario = Precio;
    }

    public int RetirarUnidades(int CantSolicitada)
    {
        if (CantSolicitada > 0)
        {
            if(CantidadProducto <= CantSolicitada)
            {
                CantidadProducto-=CantSolicitada;
            }
            else
            {
                CantSolicitada = CantidadProducto;
                CantidadProducto-=CantidadProducto;
            }

            return CantSolicitada;
        }
        else
        {
            return 0;
        }
    }

    public void AgregarUnidades(int CantRecibida)
    {
        if(CantRecibida > 0)
        {
            CantidadProducto+=CantRecibida;
        }
    }

    public string InfoProducto()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendFormat($"Producto: \n\tCodigo del producto: {codigoProducto} \n\tNombre del producto: {Nombre}\n\tDescripción: {Descripcion} \n\tPrecio por Unidad: {PrecioUnitario} \n\tCantidad de unidades disponibles: {CantidadProducto}");
        return (sb.ToString());
    }
}
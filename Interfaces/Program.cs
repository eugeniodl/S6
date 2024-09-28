IPagoRecurrente pago = new PagoDebitoAutomatico();
pago.ConfigurarRecurrencia(15);
pago.ProcesarPago(1000);

public interface IPago
{
    void ProcesarPago(decimal monto);
}

public interface IPagoRecurrente : IPago
{
    void ConfigurarRecurrencia(int dias);
}

public class PagoConTarjeta : IPago
{
    public void ProcesarPago(decimal monto)
    {
        Console.WriteLine($"Pago de {monto:C} procesado con tarjeta de crédito.");
    }
}

public class PagoDebitoAutomatico : IPagoRecurrente
{
    private int _diasRecurrencia;
    public void ConfigurarRecurrencia(int dias)
    {
        _diasRecurrencia = dias;
        Console.WriteLine($"Recurrencia configurada cada {_diasRecurrencia} días.");
    }

    public void ProcesarPago(decimal monto)
    {
        Console.WriteLine($"Pago de {monto:C} procesado por débito automático.");
    }
}
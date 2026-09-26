using System;

public class DocumentoServicioReal : IDocumentoServicio
{
    public void AccederDocumento(string usuario, string rol)
    {
        Console.WriteLine($"[SujetoReal] Acceso concedido. Mostrando información confidencial a {usuario}.");
    }
}
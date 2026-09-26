using System;

public class DocumentoServicioProxy : IDocumentoServicio
{
    private DocumentoServicioReal? _servicioReal;

    public void AccederDocumento(string usuario, string rol)
    {
        Console.WriteLine($"\n[Proxy] Petición recibida de '{usuario}' con rol '{rol}'. Verificando permisos...");

        if (rol.Equals("Admin", StringComparison.OrdinalIgnoreCase))
        {
            _servicioReal ??= new DocumentoServicioReal();

            Console.WriteLine("[Proxy] Permiso autorizado.");
            _servicioReal.AccederDocumento(usuario, rol);
        }
        else
        {
            Console.WriteLine($"[Proxy] ACCESO DENEGADO. El rol '{rol}' no tiene privilegios suficientes.");
        }
    }
}
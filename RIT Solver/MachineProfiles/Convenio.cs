using System;

public class Convenio
{
    // Identificación del convenio
    public int Id { get; set; }
    public string CodigoConvenio { get; set; } // Ej: "CV-2025-001"
    public DateTime FechaCreacion { get; set; }
    public DateTime? FechaVigenciaInicio { get; set; }
    public DateTime? FechaVigenciaFin { get; set; }

    // Datos del proveedor de servicios (tu empresa)
    public Empresa Proveedor { get; set; }

    // Datos del cliente que recibe el soporte
    public Empresa Cliente { get; set; }

    // Detalles del servicio
    public string ObjetoDelServicio { get; set; } // Descripción general del soporte ofrecido
    public string Alcance { get; set; }           // Qué incluye y qué no
    public string Modalidad { get; set; }         // Remoto, presencial, mixto
    public string HorarioAtencion { get; set; }   // Ej: "Lunes a Viernes, 9:00 a 18:00"

    // Cobros y facturación
    public decimal CostoMensual { get; set; }
    public bool IncluyeFactura { get; set; }
    public string FrecuenciaFacturacion { get; set; } // Ej: "Mensual", "Por evento"
    public string FormaDePago { get; set; }           // Ej: "Transferencia", "Efectivo"

    // Condiciones y legales
    public string ClausulasConfidencialidad { get; set; }
    public string CondicionesCancelacion { get; set; }

    // Estado del convenio
    public bool EstaActivo { get; set; }

    // Historial de firmas
    public FirmaDigital FirmaProveedor { get; set; }
    public FirmaDigital FirmaCliente { get; set; }
}

using HealthCheck.Domain.Enums;

namespace HealthCheck.Application.HealthCheck.DTO;

public class MonitoredItemDTO
{
    /// <summary>
    /// Nome
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Descrição
    /// </summary>
    public string Description { get; set; }
    
    /// <summary>
    /// Endpoint
    /// </summary>
    public string Endpoint { get; set; }
    
    /// <summary>
    /// Método HTTP
    /// </summary>
    public HttpMethod HttpMethod { get; set; }
    
    /// <summary>
    /// Usuário
    /// </summary>
    public string User { get; set; }
    
    /// <summary>
    /// Periodicidade (milissegundos)
    /// </summary>
    public int Periodicity { get; set; }
    
    /// <summary>
    /// Periodicidade (Dias da Semana [1-6])
    /// </summary>
    public int[] DaysOfWeek { get; set; }
    
    /// <summary>
    /// Método de Autenticação
    /// </summary>
    public AuthenticationTypeEnum AuthenticationType { get; set; }
}
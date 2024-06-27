using HealthCheck.Domain.Enums;

namespace HealthCheck.Application.DTO;

public class MonitoredItemDTO
{
    /// <summary>
    /// Nome da API
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Descrição da API
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Endpoint da API
    /// </summary>
    public string Endpoint { get; set; }

    /// <summary>
    /// Método da request
    /// </summary>
    public HttpMethod HttpMethod { get; set; }

    /// <summary>
    /// Usuário
    /// </summary>
    public string CreatedBy { get; set; }

    /// <summary>
    /// Periodicidade (Dias da Semana [1-6])
    /// </summary>
    public int Periodicity { get; set; }

    /// <summary>
    /// Dias da semana que vai rodar
    /// </summary>
    public int[] DaysOfWeek { get; set; }

    /// <summary>
    /// Tipo de autenticador
    /// </summary>
    public AuthenticationTypeEnum AuthenticationType { get; set; }
}
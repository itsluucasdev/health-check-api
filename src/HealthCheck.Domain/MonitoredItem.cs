namespace HealthCheck.Domain.HealthCheck;

public class MonitoredItem
{
    /// <summary>
    /// UUID - Universal Unic Identifier  
    /// </summary>
    public string Hash { get; set; }

    /// <summary>
    /// Hash - API
    /// </summary>
    public string Schema { get; set; }

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
    public string HttpMethod { get; set; }

    /// <summary>
    /// Data de Criação
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Data de atualização
    /// </summary>
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// Criado por
    /// </summary>
    public string CreatedBy { get; set; }

    /// <summary>
    /// Atualizado Por
    /// </summary>
    public string UpdatedBy { get; set; }

    /// <summary>
    /// Expressão Cron
    /// </summary>
    public string CronExpression { get; set; }

    /// <summary>
    /// Ultimo Status salvo
    /// </summary>
    public int? LastStatus { get; set; }

    /// <summary>
    /// Data da ultima vez que bateu no endpoint 
    /// </summary>
    public DateTime? LastRun { get; set; }

    /// <summary>
    /// Tipo de autenticador
    /// </summary>
    public int AuthenticationType { get; set; }
}
using FluentValidation;
using HealthCheck.Application.HealthCheck.DTO;

namespace HealthCheck.Application.HealthCheck.Validations;

public class MonitoredApiValidator : AbstractValidator<MonitoredApiDTO>
{
    public MonitoredApiValidator()
    {
        RuleFor(api => api.Name)
            .NotEmpty()
            .WithMessage($"Field {nameof(MonitoredApiDTO.Name)} must be filled");
        
        RuleFor(api => api.Description)
            .NotEmpty()
            .WithMessage($"Field {nameof(MonitoredApiDTO.Description)} must be filled");
        
        RuleFor(api => api.Url)
            .NotEmpty()
            .WithMessage($"Field {nameof(MonitoredApiDTO.Url)} must be filled");
        
        RuleFor(api => api.HttpMethod)
            .NotEmpty()
            .WithMessage($"Field {nameof(MonitoredApiDTO.HttpMethod)} must be filled");
        
        RuleFor(api => api.ExpectedCode)
            .NotEmpty()
            .WithMessage($"Field {nameof(MonitoredApiDTO.ExpectedCode)} must be filled");
        
        RuleFor(api => api.ExpectedMessage)
            .NotEmpty()
            .WithMessage($"Field {nameof(MonitoredApiDTO.ExpectedMessage)} must be filled");
    }
}
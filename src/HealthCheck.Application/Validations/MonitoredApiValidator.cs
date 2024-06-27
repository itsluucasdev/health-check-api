using FluentValidation;
using HealthCheck.Application.DTO;

namespace HealthCheck.Application.HealthCheck.Validations;

public class MonitoredApiValidator : AbstractValidator<MonitoredItemDTO>
{
    public MonitoredApiValidator()
    {
        RuleFor(api => api.Name)
            .NotEmpty()
            .WithMessage($"Field {nameof(MonitoredItemDTO.Name)} must be filled")
            .WithErrorCode("422.100");

        RuleFor(api => api.Description)
            .NotEmpty()
            .WithMessage($"Field {nameof(MonitoredItemDTO.Description)} must be filled");
    }
}
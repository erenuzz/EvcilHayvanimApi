using DtoLayer.Dtos.AsiTakibiDto;
using EntityLayer.Concrete;
using FluentValidation;

namespace EvcilHayvanimUI.ValidationRules.AsiTakibiValidationRules
{
    public class AsiTakibiValidator:AbstractValidator<AsiTakibiAddDto>
    {
        public AsiTakibiValidator()
        {
            RuleFor(x => x.YapilanAsininTuru).NotEmpty().WithMessage("Lütfen yapılan aşının türünü seçin.");
            RuleFor(x => x.AsininYapildigiTarih).NotEmpty().WithMessage("Lütfen aşının yapıldığı tarihi girin.");

        }
    }
}

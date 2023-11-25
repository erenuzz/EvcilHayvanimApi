using DtoLayer.Dtos.SaglikTakibiDto;
using DtoLayer.Dtos.SosyalAktiviteleriDto;
using FluentValidation;

namespace EvcilHayvanimUI.ValidationRules.SosyalAktiviteValidationRules
{
    public class SosyalAktiviteValidator:AbstractValidator<SosyalAktiviteleriAddDto>
    {
        public SosyalAktiviteValidator()
        {
            RuleFor(x => x.HayvaniniziMutluEdenSeyler).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
            RuleFor(x => x.HayvaniniziOfkelendirenSeyler).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
            RuleFor(x => x.OnuSakinlestirmekIcinKullandiginizYontemler).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
            RuleFor(x => x.OyunOynamaZamaniUyarisi).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
           
        }
    }
}

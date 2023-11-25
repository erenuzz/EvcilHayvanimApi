using DtoLayer.Dtos.BeslenmeTakibiDto;
using FluentValidation;

namespace EvcilHayvanimUI.ValidationRules.BeslenmeTakibiValidationRules
{
    public class BeslenmeTakibiValidator:AbstractValidator<BeslenmeTakibiAddDto>
    {
        public BeslenmeTakibiValidator()
        {
            RuleFor(x => x.KullandigiMamaTuru).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
            RuleFor(x => x.MamaMarkasi).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
            RuleFor(x => x.MamaAromasi).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
            RuleFor(x => x.UygunOlanOgunMiktari).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
            RuleFor(x => x.AlerjikReaksiyonGosterdigiBesinler).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
           
            RuleFor(x => x.SuTuketimOrani).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
           
            RuleFor(x => x.SuTuketimOrani).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
           
            RuleFor(x => x.YemekSaatiUyarisi).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
        }
    }
}

using DtoLayer.Dtos.TemizlikTakibiDto;
using FluentValidation;

namespace EvcilHayvanimUI.ValidationRules.TemizlikTakibiValidationRules
{
    public class TemizlikTakibiValidator:AbstractValidator<TemizlikTakibiAddDto>
    {
        public TemizlikTakibiValidator()
        {
            RuleFor(x => x.TirnaklariNeSikliklaKesiyorsunuz).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
            RuleFor(x => x.AgizBakimiNeSikliklaYapiliyor).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
            RuleFor(x => x.KulakTemizligiNeSikliklaYapiliyor).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
            RuleFor(x => x.GenelTemizlikTuru).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
            RuleFor(x => x.NeSikliklaYikiyorsunuz).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
            RuleFor(x => x.NeSikliklaTuyleriniTararsiniz).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
            RuleFor(x => x.NeSikliklaPatiBakimiYapiyorsunuz).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
            RuleFor(x => x.BakimTakipUyarisi).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
        }
    }
}

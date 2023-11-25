using DtoLayer.Dtos.SaglikTakibiDto;
using FluentValidation;

namespace EvcilHayvanimUI.ValidationRules.SaglikTakibiValidationRules
{
    public class SaglikTakibiValidator:AbstractValidator<SaglikTakibiAddDto>
    {
        public SaglikTakibiValidator()
        {
            RuleFor(x => x.VeterinerAdi).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
            RuleFor(x => x.Soyadi).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
            RuleFor(x => x.KlinikTelNo).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
            RuleFor(x => x.KlinikAdi).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
            RuleFor(x => x.KlinikAdres).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
            RuleFor(x => x.HayvaninizinKiloDurumu).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
            RuleFor(x => x.KalitsalHastalikAciklama).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
            RuleFor(x => x.GeciciHastalikAciklama).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
            RuleFor(x => x.EvcilHayvaninizdaGozlemlediginizFarklilik).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
          
        }
    }
}

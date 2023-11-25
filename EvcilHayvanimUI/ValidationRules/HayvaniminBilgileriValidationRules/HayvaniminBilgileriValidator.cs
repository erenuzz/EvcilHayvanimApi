using DtoLayer.Dtos.HayvaniminBilgileriDto;
using FluentValidation;

namespace EvcilHayvanimUI.ValidationRules.HayvaniminBilgileri
{
    public class HayvaniminBilgileriValidator:AbstractValidator<HayvaniminBilgileriAddDto>
    {
        public HayvaniminBilgileriValidator()
        {
            RuleFor(x => x.Adi).NotEmpty().WithMessage("Bu alan boş bırakılmaz");
            RuleFor(x => x.Yasi).NotEmpty().WithMessage("Bu alan boş bırakılmaz");
            RuleFor(x => x.SahiplenildigiTarih).NotEmpty().WithMessage("Bu alan boş bırakılmaz");
            RuleFor(x => x.Cinsiyeti).NotEmpty().WithMessage("Bu alan boş bırakılmaz");
            RuleFor(x => x.DogumTarihi).NotEmpty().WithMessage("Bu alan boş bırakılmaz");
            RuleFor(x => x.Kilosu).NotEmpty().WithMessage("Bu alan boş bırakılmaz");
            RuleFor(x => x.HastalikAciklamaveKullandigiIlaclar).NotEmpty().WithMessage("Bu alan boş bırakılmaz");
           
            RuleFor(x => x.Irki).NotEmpty().WithMessage("Bu alan boş bırakılmaz");
            
        }
    }
}

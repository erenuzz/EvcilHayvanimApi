using AutoMapper;
using DtoLayer.Dtos.AsiTakibiDto;
using DtoLayer.Dtos.BeslenmeTakibiDto;
using DtoLayer.Dtos.GirisDto;
using DtoLayer.Dtos.HayvaniminBilgileriDto;
using DtoLayer.Dtos.KayitDto;
using DtoLayer.Dtos.SaglikTakibiDto;
using DtoLayer.Dtos.SosyalAktiviteleriDto;
using DtoLayer.Dtos.TemizlikTakibiDto;
using EntityLayer.Concrete;

namespace EvcilHayvanim.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<AsiTakibiAddDto, AsiTakibi>();
            CreateMap<AsiTakibi , AsiTakibiAddDto>();
            CreateMap<AsiTakibiUpDto , AsiTakibi>().ReverseMap();

            CreateMap<BeslenmeTakibiAddDto, BeslenmeTakibi>();
            CreateMap<BeslenmeTakibi, BeslenmeTakibiAddDto>();
            CreateMap<BeslenmeTakibiUpDto, BeslenmeTakibi>().ReverseMap();

            CreateMap<HayvaniminBilgileriAddDto, HayvaniminBilgileri>();
            CreateMap<HayvaniminBilgileri, HayvaniminBilgileriAddDto>();
            CreateMap<HayvaniminBilgileriUpDto, HayvaniminBilgileri>().ReverseMap();

            CreateMap<SaglikTakibiAddDto, SaglikTakibi>();
            CreateMap<SaglikTakibi, SaglikTakibiAddDto>();
            CreateMap<SaglikTakibiUpDto, SaglikTakibi>().ReverseMap();

            CreateMap<SosyalAktiviteleriAddDto, SosyalAktiviteleri>();
            CreateMap<SosyalAktiviteleri, SosyalAktiviteleriAddDto>();
            CreateMap<SosyalAktiviteleriUpDto, SosyalAktiviteleri>().ReverseMap();

            CreateMap<TemizlikTakibiAddDto, TemizlikTakibi>();
            CreateMap<TemizlikTakibi, TemizlikTakibiAddDto>();
            CreateMap<TemizlikTakibiUpDto, TemizlikTakibi>().ReverseMap();

            CreateMap<YeniKayitDto, Kullanicilar>();
            CreateMap<Kullanicilar, YeniKayitDto>();

            CreateMap<GirisDto, Kullanicilar>();
            CreateMap<Kullanicilar, GirisDto>();
          

        }
    }
}

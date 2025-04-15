using AutoMapper;
using Demo1.DTOs;
using Demo1.Model;

namespace Demo1.AutoMapper
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<CalisanDto, Calisan>().ReverseMap();
            //.ForMember...

            /*CreateMap<AlimSatim, AlimSatimDto>()
                .ForMember(dest => dest.DepoAdi, opt => opt.MapFrom(src => src.Depo.DepoAdi));
            */
            CreateMap<AlimSatim, AlimSatimDto>()
               .ForMember(dest => dest.FisDestekler,
                   opt => opt.MapFrom(src => src.FisDestekler));


       
            CreateMap<AlimSatimDto, AlimSatim>()
                .ForMember(dest => dest.FisDestekler,
                    opt => opt.MapFrom(src => src.FisDestekler));


            CreateMap<FisDestek, FisDestekDto>();
            CreateMap<FisDestekDto, FisDestek>();

            CreateMap<Urun, UrunDto>();
            CreateMap<UrunDto, Urun>();

            CreateMap<Depo, DepoDto>();
            CreateMap<DepoDto, Depo>();

            CreateMap<Kategori, KategoriDto>();
            CreateMap<KategoriDto, Kategori>();


            CreateMap<Marka, MarkaDto>();
            CreateMap<MarkaDto, Marka>();

            CreateMap<Departman, DepartmanDto>();
            CreateMap<DepartmanDto, Departman>();

            CreateMap<Islem, IslemDto>();
            CreateMap<IslemDto, Islem>();

            CreateMap<Kategori, KategoriDto>();
            CreateMap<KategoriDto, Kategori>();

            CreateMap<KullaniciIslem, KullaniciIslemDto>();
            CreateMap<KullaniciIslemDto, KullaniciIslem>();

            CreateMap<KullaniciRol, KullaniciRolDto>();
            CreateMap<KullaniciRolDto, KullaniciRol>();

            CreateMap<Rol, RolDto>();
            CreateMap<RolDto, Rol>();

            CreateMap<Yetki, YetkiDto>();
            CreateMap<YetkiDto, Yetki>();
        }
    }
}

using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISNogometniStadion.WebAPI.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Database.Korisnici, Model.Korisnik>();
            //source pa destination
            //konverzija iz jednog smjera u drugi-reverse map
            CreateMap<Database.Korisnici, Model.Requests.KorisniciInsertRequest>().ReverseMap();
            CreateMap<Database.Korisnici, Model.Requests.KorisniciUpdateRequest>().ReverseMap();
            CreateMap<Database.Drzave, Model.Drzava>();
            CreateMap<Database.Drzave, Model.Requests.DrzaveInsertRequest>().ReverseMap();
            CreateMap<Database.Drzave, Model.Requests.DrzaveUpdateRequest>().ReverseMap();
            CreateMap<Database.Gradovi, Model.Grad>();
            CreateMap<Database.Gradovi, Model.Requests.GradoviInsertRequest>().ReverseMap();
            CreateMap<Database.Gradovi, Model.Requests.GradoviUpdateRequest>().ReverseMap();
            CreateMap<Database.Timovi, Model.Tim>();
            CreateMap<Database.Timovi, Model.Requests.TimoviInsertRequest>().ReverseMap();
            CreateMap<Database.Timovi, Model.Requests.TimoviUpdateRequest>().ReverseMap();
            CreateMap<Database.Stadioni, Model.Stadion>();
            CreateMap<Database.Stadioni, Model.Requests.StadioniInsertRequest>().ReverseMap();
            CreateMap<Database.Stadioni, Model.Requests.StadioniUpdateRequest>().ReverseMap();
            CreateMap<Database.Tribine, Model.Tribina>();
            CreateMap<Database.Tribine, Model.Requests.TribineInsertRequest>().ReverseMap();
            CreateMap<Database.Tribine, Model.Requests.TribineUpdateRequest>().ReverseMap();
            CreateMap<Database.Ulaznice, Model.Ulaznica>();
            CreateMap<Database.Ulaznice, Model.Requests.UlazniceInsertRequest>().ReverseMap();
            CreateMap<Database.Ulaznice, Model.Requests.UlazniceUpdateRequest>().ReverseMap();
            CreateMap<Database.Sjedala, Model.Sjedalo>();
            CreateMap<Database.Sjedala, Model.Requests.SjedalaInsertRequest>().ReverseMap();
            CreateMap<Database.Sjedala, Model.Requests.SjedaloUpdateRequest>().ReverseMap();
            CreateMap<Database.Utakmice, Model.Utakmica>();
            CreateMap<Database.Utakmice, Model.Requests.UtakmiceInsertRequest>().ReverseMap();
            CreateMap<Database.Utakmice, Model.Requests.UtakmiceUpdateRequest>().ReverseMap();

            //CreateMap<Database.Utakmice, Model.Utakmica>().ForMember(s => s.DomaciTimm, a => a.MapFrom(o => o.DomaciTim.Naziv));
            //CreateMap<Database.Utakmice, Model.Utakmica>().ForMember(s => s.GostujuciTim, a => a.MapFrom(o=>o.GostujuciTim.Naziv));
            //CreateMap<Database.Utakmice, Model.Utakmica>().ForMember(s => s.stadion, a => a.MapFrom(o => o.stadion.Naziv));

        }
    }
}

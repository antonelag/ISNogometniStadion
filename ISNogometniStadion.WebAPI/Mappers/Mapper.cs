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

        }
    }
}

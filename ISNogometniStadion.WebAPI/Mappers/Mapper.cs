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
            CreateMap<Database.Drzave, Model.Drzava>();
            CreateMap<Database.Drzave, Model.Requests.DrzaveInsertRequest>().ReverseMap();
            CreateMap<Database.Gradovi, Model.Grad>();
            CreateMap<Database.Gradovi, Model.Requests.GradoviInsertRequest>().ReverseMap();
           // CreateMap<Database.Korisnici, Model.Korisnik>().ForMember(s => s.Grad, c => c.MapFrom(s => s.Grad.Naziv));
            CreateMap<Database.Timovi, Model.Tim>();
            CreateMap<Database.Timovi, Model.Requests.TimoviInsertRequest>().ReverseMap();
            CreateMap<Database.Stadioni, Model.Stadion>();
            CreateMap<Database.Stadioni, Model.Requests.StadioniInsertRequest>().ReverseMap();
            CreateMap<Database.Tribine, Model.Tribina>();
            CreateMap<Database.Tribine, Model.Requests.TribineInsertRequest>().ReverseMap();
            CreateMap<Database.Ulaznice, Model.Ulaznica>();
            CreateMap<Database.Ulaznice, Model.Requests.UlazniceInsertRequest>().ReverseMap();
            CreateMap<Database.Sjedala, Model.Sjedalo>();
            CreateMap<Database.Sjedala, Model.Requests.SjedalaInsertRequest>().ReverseMap();
            CreateMap<Database.Utakmice, Model.Utakmica>();
            CreateMap<Database.Utakmice, Model.Requests.UtakmiceInsertRequest>().ReverseMap();
            CreateMap<Database.Korisnici, Model.Korisnik>()
                .ForMember(s => s.Naziv, a => 
                a.MapFrom(b => new Database.ISNogometniStadionContext().Gradovi.Find(b.GradID).Naziv));

            CreateMap<Database.Gradovi, Model.Grad>()
                .ForMember(s => s.Drzava, a =>
                a.MapFrom(b => new Database.ISNogometniStadionContext().Drzave.Find(b.DrzavaID).Naziv));

            CreateMap<Database.Sjedala, Model.Sjedalo>()
                .ForMember(s => s.Tribina, a =>
                a.MapFrom(b => new Database.ISNogometniStadionContext().Tribine.Find(b.TribinaID).Naziv));

            CreateMap<Database.Stadioni, Model.Stadion>()
              .ForMember(s => s.Grad, a =>
              a.MapFrom(b => new Database.ISNogometniStadionContext().Gradovi.Find(b.GradID).Naziv));
            //CreateMap<Database.Utakmice, Model.Utakmica>().ForMember(s => s.DomaciTimm, a => a.MapFrom(o => o.DomaciTim.Naziv));
            //CreateMap<Database.Utakmice, Model.Utakmica>().ForMember(s => s.GostujuciTim, a => a.MapFrom(o=>o.GostujuciTim.Naziv));
            //CreateMap<Database.Utakmice, Model.Utakmica>().ForMember(s => s.stadion, a => a.MapFrom(o => o.stadion.Naziv));

        }
    }
}

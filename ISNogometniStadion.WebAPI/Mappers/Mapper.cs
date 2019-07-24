using AutoMapper;
using Microsoft.EntityFrameworkCore;
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

            CreateMap<Database.Timovi, Model.Tim>()
              .ForMember(s => s.Stadion, a =>
              a.MapFrom(b => new Database.ISNogometniStadionContext().Stadioni.Find(b.StadionID).Naziv));

            CreateMap<Database.Tribine, Model.Tribina>()
          .ForMember(s => s.Stadion, a =>
          a.MapFrom(b => new Database.ISNogometniStadionContext().Stadioni.Find(b.StadionID).Naziv));


      
            CreateMap<Database.Utakmice, Model.Utakmica>()
            .ForMember(s => s.stadion, a =>
            a.MapFrom(b => new Database.ISNogometniStadionContext().Stadioni.Find(b.StadionID).Naziv))
            .ForMember(s => s.GostujuciTim, a =>
            a.MapFrom(b => new Database.ISNogometniStadionContext().Timovi.Find(b.GostujuciTimID).Naziv))
            .ForMember(s => s.DomaciTim, a =>
              a.MapFrom(b => new Database.ISNogometniStadionContext().Timovi.Find(b.DomaciTimID).Naziv));

         


            CreateMap<Database.Ulaznice, Model.Ulaznica>()
               .ForMember(s => s.Oznaka, a =>
               a.MapFrom(b => new Database.ISNogometniStadionContext().Sjedala.Find(b.SjedaloID).Oznaka))
//popraviti!!
               .ForMember(s => s.utakmica, a =>
                a.MapFrom(b => new Database.ISNogometniStadionContext().Utakmice
                .Include(s=>s.DomaciTim).Include(s=>s.GostujuciTim)
                .FirstOrDefault(s=>s.UtakmicaID==b.UtakmicaID).Utakmica))

               .ForMember(s => s.korisnik, a =>
                a.MapFrom(b => new Database.ISNogometniStadionContext().Korisnici.Find(b.KorisnikID).Korisnik));

        }
    }
}

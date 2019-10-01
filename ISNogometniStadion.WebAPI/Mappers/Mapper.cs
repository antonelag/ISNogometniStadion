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
            CreateMap<Database.Sektori, Model.Sektor>();
            CreateMap<Database.Sektori, Model.Requests.SektoriInsertRequest>().ReverseMap();
            CreateMap<Database.Preporuke, Model.Preporuka>();
            CreateMap<Database.Preporuke, Model.Requests.PreporukaInsertRequest>().ReverseMap();
            CreateMap<Database.Uplate, Model.Uplata>();
            CreateMap<Database.Uplate,Model.Uplata>()
                .ForMember(s => s.UplataPodaci, a => a.MapFrom(b => new Database.ISNogometniStadionContext()
                .Ulaznice.Include(s=>s.Utakmica.DomaciTim).Include(s=>s.Utakmica.GostujuciTim).Include(s=>s.Korisnik).FirstOrDefault(s=>s.UlaznicaID==b.UlaznicaID).UlaznicaPodaci));

            CreateMap<Database.Uplate, Model.Requests.UplateInsertRequest>().ReverseMap();
         

            CreateMap<Database.Ulaznice, Model.Ulaznica>();
            CreateMap<Database.Ulaznice, Model.Requests.UlazniceInsertRequest>().ReverseMap();

            CreateMap<Database.Lige, Model.Liga>();
            CreateMap<Database.Lige, Model.Requests.LigaInsertRequest>().ReverseMap();
            CreateMap<Database.Sjedala, Model.Sjedalo>();
            CreateMap<Database.Sjedala, Model.Requests.SjedalaInsertRequest>().ReverseMap();
            CreateMap<Database.Utakmice, Model.Utakmica>();
            CreateMap<Database.Utakmice, Model.Requests.UtakmiceInsertRequest>().ReverseMap();
            CreateMap<Model.Requests.UtakmiceInsertRequest, Database.Utakmice>()
                .ForMember(s => s.dateonly, a => a.MapFrom(s => s.DatumOdigravanja.Date));

            CreateMap<Database.Korisnici, Model.Korisnik>()
                .ForMember(s => s.Naziv, a =>
                a.MapFrom(b => new Database.ISNogometniStadionContext().Gradovi.Find(b.GradID).Naziv));

            CreateMap<Database.Gradovi, Model.Grad>()
                .ForMember(s => s.Drzava, a =>
                a.MapFrom(b => new Database.ISNogometniStadionContext().Drzave.Find(b.DrzavaID).Naziv));

            CreateMap<Database.Sjedala, Model.Sjedalo>()
                .ForMember(s => s.Sektor, a =>
                a.MapFrom(b => new Database.ISNogometniStadionContext().Sektori.Find(b.SektorID).Naziv));

            CreateMap<Database.Stadioni, Model.Stadion>()
              .ForMember(s => s.Grad, a =>
              a.MapFrom(b => new Database.ISNogometniStadionContext().Gradovi.Find(b.GradID).Naziv));

            CreateMap<Database.Timovi, Model.Tim>()
              .ForMember(s => s.Stadion, a =>
              a.MapFrom(b => new Database.ISNogometniStadionContext().Stadioni.Find(b.StadionID).Naziv));


            CreateMap<Database.Timovi, Model.Tim>()
             .ForMember(s => s.Liga, a =>
             a.MapFrom(b => new Database.ISNogometniStadionContext().Lige.Find(b.LigaID).Naziv));
            CreateMap<Database.Lige, Model.Liga>()
         .ForMember(s => s.Drzava, a =>
         a.MapFrom(b => new Database.ISNogometniStadionContext().Drzave.Find(b.DrzavaID).Naziv));

            CreateMap<Database.Tribine, Model.Tribina>()
          .ForMember(s => s.Stadion, a =>
          a.MapFrom(b => new Database.ISNogometniStadionContext().Stadioni.Find(b.StadionID).Naziv));



            CreateMap<Database.Utakmice, Model.Utakmica>()
            .ForMember(s => s.stadion, a =>
            a.MapFrom(b => new Database.ISNogometniStadionContext().Stadioni.Find(b.StadionID).Naziv))
            .ForMember(s => s.GostujuciTim, a =>
            a.MapFrom(b => new Database.ISNogometniStadionContext().Timovi.Find(b.GostujuciTimID).Naziv))
            .ForMember(s => s.DomaciTim, a =>
              a.MapFrom(b => new Database.ISNogometniStadionContext().Timovi.Find(b.DomaciTimID).Naziv))
            .ForMember(s => s.Liga, a =>
               a.MapFrom(b => new Database.ISNogometniStadionContext().Lige.Find(b.LigaID).Naziv));




            CreateMap<Database.Ulaznice, Model.Ulaznica>()
               .ForMember(s => s.Oznaka, a =>
               a.MapFrom(b => new Database.ISNogometniStadionContext().Sjedala.Find(b.SjedaloID).Oznaka))
               //popraviti!!
               .ForMember(s => s.utakmica, a =>
                a.MapFrom(b => new Database.ISNogometniStadionContext().Utakmice
                .Include(s => s.DomaciTim).Include(s => s.GostujuciTim)
                .FirstOrDefault(s => s.UtakmicaID == b.UtakmicaID).Utakmica))

               .ForMember(s => s.korisnik, a =>
                a.MapFrom(b => new Database.ISNogometniStadionContext().Korisnici.Find(b.KorisnikID).Korisnik))

               .ForMember(s => s.sektor, a =>
                  a.MapFrom(b => new Database.ISNogometniStadionContext().Sjedala.Include(s => s.Sektor).FirstOrDefault(s => s.SjedaloID
                      == b.SjedaloID).Sektor.Naziv));



            CreateMap<Database.Sektori, Model.Sektor>()
                .ForMember(s => s.Cijena, a =>
                a.MapFrom(b => new Database.ISNogometniStadionContext().Tribine
                .FirstOrDefault(s => s.TribinaID == b.TribinaID).Cijena))
                .ForMember(s => s.Tribina, a =>
                   a.MapFrom(b => new Database.ISNogometniStadionContext().Tribine
                   .FirstOrDefault(s => s.TribinaID == b.TribinaID).Naziv));

        }
    }
}

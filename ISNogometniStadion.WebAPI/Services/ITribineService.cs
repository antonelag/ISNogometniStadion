﻿using ISNogometniStadion.Model;
using ISNogometniStadion.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISNogometniStadion.WebAPI.Services
{
    public interface ITribineService
    {
        List<Tribina> Get(TribineSearchRequest req);
        Tribina GetById(int id);
        Tribina Insert(TribineInsertRequest req);
        Tribina Update(int id, TribineInsertRequest req);
        string Delete(int id);
    }
}

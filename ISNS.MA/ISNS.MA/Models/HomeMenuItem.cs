using System;
using System.Collections.Generic;
using System.Text;

namespace ISNS.MA.Models
{
    public enum MenuItemType
    {
        Početna,
        About,
        Utakmice,
        Stadioni,
        Timovi,
        MojeUlaznice,
        UrediProfil
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}

using CoopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoopApp.Interfaces
{
    public interface IKunderRepository
    {
        List<Kunde> GetAllKunder();
        void AddKunde(Kunde kunde);
        Kunde GetKunde(int MellemsID);

    }
}

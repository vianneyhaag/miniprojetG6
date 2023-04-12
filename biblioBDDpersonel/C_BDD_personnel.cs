using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using BddpersonnelContext;

namespace biblioBDDpersonnels
{
    public class CBDDpersonnels
    {
        private BddpersonnelDataContext dc = null;
        public CBDDpersonnels()
        {
            dc = new BddpersonnelDataContext();
        }




        public List<Personnel> getALLPersonnels()
        {
            try
            {
                return dc.Personnels.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Service> getALLServices()
        {
            try
            {
                return dc.Services.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void AjouterPersonnel(string prenom, string nom, int idService, int idFonction, string tel)
        {
            Personnel p = new Personnel();
            p.Prenom = prenom;
            p.Nom = nom;
            p.Telephone = tel;
            p.IdService = idService;
            p.IdFonction = idFonction;
            dc.Personnels.InsertOnSubmit(p);
        }

        public void ModifierPersonnel(int id, string prenom, string nom, int idService, int idFonction, string tel)
        {
            Personnel p = dc.Personnels.Where(x => x.Id == id).FirstOrDefault();
            p.Prenom = prenom;
            p.Nom = nom;
            p.Telephone = tel;
            p.IdService = idService;
            p.IdFonction = idFonction;
            dc.SubmitChanges(p);
        }

        public void SupprimerPersonnel(int id)
        {
            try
            {
                Personnel p = dc.Personnels.Where(x => x.Id == id).FirstOrDefault();
                dc.Personnels.DeleteOnSubmit(p);

            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}

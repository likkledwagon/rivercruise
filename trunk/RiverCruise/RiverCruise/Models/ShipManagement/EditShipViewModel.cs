using System;
using System.Linq;

namespace RiverCruise.Models.ShipManagement
{
    public class EditShipViewModel : NewShipViewModel
    {
        public EditShipViewModel()
        {
        }

        public EditShipViewModel(DataModels.Ship queryResult, bool shipEdited)
        {
            ShipModified = shipEdited;

            Id = queryResult.Id;
            Name = queryResult.Name;
            Eni = queryResult.Eni;
            Flag = queryResult.Flag;
            Region = queryResult.Region;
            var crew = queryResult.Crew.FirstOrDefault(x => x.From < DateTime.Now && x.Until >= DateTime.Now);
            if (crew != null)
            { 
                NauticalCrew = crew.NauticalCrew.GetValueOrDefault(0);
                HotselStaff = crew.HotelStaff.GetValueOrDefault(0);
            }

            var company = queryResult.Ship2Company.FirstOrDefault(x => x.From < DateTime.Now && x.Until >= DateTime.Now);
            if (company != null)
            {
                Comany = new NewShipCompanyViewModel()
                {
                    Id = company.Company.Id,
                    Name = company.Company.Name
                };
            }
            else
            {
                Comany = new NewShipCompanyViewModel();
            }
        }

        public int Id { get; set; }
    }
}
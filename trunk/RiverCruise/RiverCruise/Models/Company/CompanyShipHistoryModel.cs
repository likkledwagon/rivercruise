using System;
using System.ComponentModel.DataAnnotations;
using DataModels;

namespace RiverCruise.Models.Company
{
    public enum HistoryType
    {
        In, Out
    }

    public class CompanyShipHistoryModel
    {

        public int ShipId { get; set; }

        public string ShipName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        public HistoryType HistoryType { get; set; }
    }
}
﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc.Html;

namespace RiverCruise.Models.ShipManagement
{
    public class NewShipViewModel
    {
        public NewShipCompanyViewModel Comany { get; set; }

        [Required]
        public string Name { get; set; }
        public string Eni { get; set; }

        [Display(Name = "Nautical crew")]
        public int NauticalCrew { get; set; }

        [Display(Name="Hotel staff")]
        public int HotselStaff { get; set; }
        public string Region { get; set; }

        [StringLength(3)]
        public string Flag { get; set; }
        public bool ShipModified { get; set; }

        [DateValidation(ErrorMessage = "Date must be between 1/01/1900 and current date.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Since { get; set; }
    }

    public class DateValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            try
            {
                return (((DateTime) value) >= new DateTime(1900, 01, 01) &&
                        ((DateTime) value) <= DateTime.Now);
            }
            catch
            {
                return false;
            }
        }
    }
}
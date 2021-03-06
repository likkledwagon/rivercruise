﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Web.UI;
using DataModels;

namespace RiverCruise.Models
{
    public class BasePagingModel
    {
        private string _action = "Index";
        private string _targetDiv = "div#pagerTarget";

        [Range(1, int.MaxValue, ErrorMessage = "Page out of range")]
        public int CurrentPage { get; set; }
        public double Pages { get; set; }
        public const int ItemsPerPage = 10;
        public const int TotalPageNumbers = 10;

        public void Initialize(int currentPage, int totalItems, string controller)
        {
            CurrentPage = currentPage;
            Pages = Math.Ceiling((double)totalItems / ItemsPerPage); ;
            TotalItems = totalItems;
            Controller = controller;
        }

        public string Controller { get; set; }

        public int TotalItems { get; set; }
        public string SearchText { get; set; }

        public string Action
        {
            get { return _action; }
            set { _action = value; }
        }

        public string TargetDiv
        {
            get { return _targetDiv; }
            set { _targetDiv = value; }
        }
    }
}
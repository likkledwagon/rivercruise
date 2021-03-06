﻿using System.Collections.ObjectModel;

namespace DataModels
{
    public class Company
    {
        public Company()
        {
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Website { get; set; }

        public virtual Collection<Ship2Company> Ship2Company { get; set; }
        public string CrewingAgent { get; set; }
        public string CrewingAgentWebsite { get; set; }
    }
}

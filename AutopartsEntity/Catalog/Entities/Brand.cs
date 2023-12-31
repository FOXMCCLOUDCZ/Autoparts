﻿using AutopartsCore.BaseEntities;
using AutopartsEntity.ExtensionForUsers.Entities;

namespace AutopartsEntity.Catalog.Entities
{
    public class Brand : BaseEntity
    {
        public int? TecDoc { get; set; }
        public string Title { get; set; } = null!;
        public string? LogoPath { get; set; }
        public string? WebSite { get; set; }
        public string? GeneralInformation { get; set; }
        public bool IsActive { get; set; } = false;

        public int? CountryId { get; set; }
        public Country? Country { get; set; } = null!;
    }
}
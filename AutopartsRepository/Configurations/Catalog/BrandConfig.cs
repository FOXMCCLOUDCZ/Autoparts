﻿using AutopartsEntity.Catalog.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutopartsRepository.Configurations.Catalog
{
    internal class BrandConfig : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(x => x.CreateDate).IsRequired()
                .HasMaxLength(10);
            builder.Property(x => x.UpdateDate)
                .HasMaxLength(10);
            builder.Property(x => x.RowVersion)
                .IsRowVersion();

            builder.Property(x => x.TecDoc)
                .HasMaxLength(6);
            builder.Property(x => x.Title).IsRequired()
                .HasMaxLength(50);
            builder.Property(x => x.LogoPath)
                .HasMaxLength(500);
            builder.Property(x => x.WebSite)
                .HasMaxLength(200);
            builder.Property(x => x.GeneralInformation)
                .HasMaxLength(2000);
            builder.Property(x => x.IsActive)
                .HasDefaultValue(false);
            builder.Property(x => x.CountryId);

            builder.HasData(
                new Brand { Id = 1, TecDoc = 1, Title = "SPIDAN", WebSite = "https://www.spidanchassisparts.com/", GeneralInformation = "Test", IsActive = true, CountryId = 4 },
                new Brand { Id = 2, TecDoc = 2, Title = "HELLA", IsActive = true },
                new Brand { Id = 3, TecDoc = 3, Title = "ATE", IsActive = true },
                new Brand { Id = 4, TecDoc = 4, Title = "MANN-FILTER", IsActive = true },
                new Brand { Id = 5, TecDoc = 5, Title = "PIERBURG", IsActive = true },
                new Brand { Id = 6, TecDoc = 6, Title = "LuK", IsActive = true },
                new Brand { Id = 7, TecDoc = 7, Title = "EBERSPÄCHER", IsActive = true },
                new Brand { Id = 8, TecDoc = 9, Title = "VICTOR REINZ", IsActive = true },
                new Brand { Id = 9, TecDoc = 10, Title = "ELRING", IsActive = true },
                new Brand { Id = 10, TecDoc = 11, Title = "BorgWarner (BERU)", IsActive = true },
                new Brand { Id = 11, TecDoc = 13, Title = "WALKER", IsActive = true },
                new Brand { Id = 12, TecDoc = 15, Title = "NGK", IsActive = true },
                new Brand { Id = 13, TecDoc = 16, Title = "BILSTEIN", IsActive = true },
                new Brand { Id = 14, TecDoc = 18, Title = "KONI", IsActive = true },
                new Brand { Id = 15, TecDoc = 19, Title = "SWF", IsActive = true },
                new Brand { Id = 16, TecDoc = 21, Title = "VALEO", IsActive = true },
                new Brand { Id = 17, TecDoc = 23, Title = "RUVILLE", IsActive = true },
                new Brand { Id = 18, TecDoc = 24, Title = "EXIDE", IsActive = true },
                new Brand { Id = 19, TecDoc = 26, Title = "VARTA", IsActive = true },
                new Brand { Id = 20, TecDoc = 29, Title = "ERNST", IsActive = true },
                new Brand { Id = 21, TecDoc = 30, Title = "BOSCH", IsActive = true },
                new Brand { Id = 22, TecDoc = 31, Title = "CONTINENTAL CTAM", IsActive = true },
                new Brand { Id = 23, TecDoc = 32, Title = "SACHS", IsActive = true },
                new Brand { Id = 24, TecDoc = 33, Title = "GATES", IsActive = true },
                new Brand { Id = 25, TecDoc = 34, Title = "KNECHT", IsActive = true },
                new Brand { Id = 26, TecDoc = 35, Title = "LEMFÖRDER", IsActive = true },
                new Brand { Id = 27, TecDoc = 36, Title = "VAN WEZEL", IsActive = true },
                new Brand { Id = 28, TecDoc = 37, Title = "MONROE", IsActive = true },
                new Brand { Id = 29, TecDoc = 38, Title = "PURFLUX", IsActive = true },
                new Brand { Id = 30, TecDoc = 39, Title = "TEXTAR", IsActive = true },
                new Brand { Id = 31, TecDoc = 41, Title = "BOSAL", IsActive = true },
                new Brand { Id = 32, TecDoc = 42, Title = "DAYCO", IsActive = true },
                new Brand { Id = 33, TecDoc = 43, Title = "CHAMPION", IsActive = true },
                new Brand { Id = 34, TecDoc = 47, Title = "BREMI", IsActive = true },
                new Brand { Id = 35, TecDoc = 48, Title = "JURID", IsActive = true },
                new Brand { Id = 36, TecDoc = 50, Title = "SKF", IsActive = true },
                new Brand { Id = 37, TecDoc = 51, Title = "WESTFALIA", IsActive = true },
                new Brand { Id = 38, TecDoc = 54, Title = "FTE", IsActive = true },
                new Brand { Id = 39, TecDoc = 55, Title = "HERTH+BUSS JAKOPARTS", IsActive = true },
                new Brand { Id = 40, TecDoc = 56, Title = "LÖBRO", IsActive = true },
                new Brand { Id = 41, TecDoc = 57, Title = "QUINTON HAZELL", IsActive = true },
                new Brand { Id = 42, TecDoc = 61, Title = "TYC", IsActive = true },
                new Brand { Id = 43, TecDoc = 65, Title = "BREMBO", IsActive = true },
                new Brand { Id = 44, TecDoc = 66, Title = "DENSO", IsActive = true },
                new Brand { Id = 45, TecDoc = 67, Title = "OSRAM", IsActive = true },
                new Brand { Id = 46, TecDoc = 68, Title = "ZF", IsActive = true },
                new Brand { Id = 47, TecDoc = 72, Title = "HERTH+BUSS ELPARTS", IsActive = true },
                new Brand { Id = 48, TecDoc = 75, Title = "PHILIPS", IsActive = true },
                new Brand { Id = 49, TecDoc = 78, Title = "KLOKKERHOLM", IsActive = true },
                new Brand { Id = 50, TecDoc = 79, Title = "BorgWarner (Wahler)", IsActive = true },
                new Brand { Id = 51, TecDoc = 81, Title = "HENGST FILTER", IsActive = true },
                new Brand { Id = 52, TecDoc = 83, Title = "CONTINENTAL/VDO", IsActive = true },
                new Brand { Id = 53, TecDoc = 85, Title = "KYB", IsActive = true },
                new Brand { Id = 54, TecDoc = 86, Title = "ZIMMERMANN", IsActive = true },
                new Brand { Id = 55, TecDoc = 88, Title = "GLASER", IsActive = true },
                new Brand { Id = 56, TecDoc = 89, Title = "DELPHI", IsActive = true },
                new Brand { Id = 57, TecDoc = 94, Title = "METZGER", IsActive = true },
                new Brand { Id = 58, TecDoc = 95, Title = "MAGNETI MARELLI", IsActive = true },
                new Brand { Id = 59, TecDoc = 97, Title = "WAECO", IsActive = true },
                new Brand { Id = 60, TecDoc = 101, Title = "FEBI BILSTEIN", IsActive = true },
                new Brand { Id = 61, TecDoc = 106, Title = "BRINK", IsActive = true },
                new Brand { Id = 62, TecDoc = 109, Title = "BUGATTI", IsActive = true },
                new Brand { Id = 63, TecDoc = 110, Title = "SNR", IsActive = true },
                new Brand { Id = 64, TecDoc = 112, Title = "EIBACH", IsActive = true },
                new Brand { Id = 65, TecDoc = 113, Title = "PAYEN", IsActive = true },
                new Brand { Id = 66, TecDoc = 114, Title = "BUDWEG CALIPER", IsActive = true },
                new Brand { Id = 67, TecDoc = 115, Title = "ULO", IsActive = true },
                new Brand { Id = 68, TecDoc = 117, Title = "LRT", IsActive = true },
                new Brand { Id = 69, TecDoc = 118, Title = "HJS", IsActive = true },
                new Brand { Id = 70, TecDoc = 121, Title = "METELLI", IsActive = true },
                new Brand { Id = 71, TecDoc = 123, Title = "NISSENS", IsActive = true },
                new Brand { Id = 72, TecDoc = 126, Title = "STABILUS", IsActive = true },
                new Brand { Id = 73, TecDoc = 127, Title = "NK", IsActive = true },
                new Brand { Id = 74, TecDoc = 129, Title = "OPTIMAL", IsActive = true },
                new Brand { Id = 75, TecDoc = 135, Title = "SIDEM", IsActive = true },
                new Brand { Id = 76, TecDoc = 137, Title = "UFI", IsActive = true },
                new Brand { Id = 77, TecDoc = 138, Title = "JOHNS", IsActive = true },
                new Brand { Id = 78, TecDoc = 139, Title = "AJUSA", IsActive = true },
                new Brand { Id = 79, TecDoc = 140, Title = "CORTECO", IsActive = true },
                new Brand { Id = 80, TecDoc = 141, Title = "AE", IsActive = true },
                new Brand { Id = 81, TecDoc = 142, Title = "SOFIMA", IsActive = true },
                new Brand { Id = 82, TecDoc = 144, Title = "MEYLE", IsActive = true },
                new Brand { Id = 83, TecDoc = 151, Title = "SWAG", IsActive = true },
                new Brand { Id = 84, TecDoc = 154, Title = "DOLZ", IsActive = true },
                new Brand { Id = 85, TecDoc = 156, Title = "JAPANPARTS", IsActive = true },
                new Brand { Id = 86, TecDoc = 158, Title = "ICER", IsActive = true },
                new Brand { Id = 87, TecDoc = 159, Title = "FACET", IsActive = true },
                new Brand { Id = 88, TecDoc = 161, Title = "TRW", IsActive = true },
                new Brand { Id = 89, TecDoc = 162, Title = "VAICO", IsActive = true },
                new Brand { Id = 90, TecDoc = 166, Title = "AISIN", IsActive = true },
                new Brand { Id = 91, TecDoc = 167, Title = "DUPLI COLOR", IsActive = true },
                new Brand { Id = 92, TecDoc = 168, Title = "MOTIP", IsActive = true },
                new Brand { Id = 93, TecDoc = 169, Title = "PRESTO", IsActive = true },
                new Brand { Id = 94, TecDoc = 175, Title = "LESJÖFORS", IsActive = true },
                new Brand { Id = 95, TecDoc = 177, Title = "BTS Turbo", IsActive = true },
                new Brand { Id = 96, TecDoc = 178, Title = "HEPU", IsActive = true },
                new Brand { Id = 97, TecDoc = 180, Title = "ALCO FILTER", IsActive = true },
                new Brand { Id = 98, TecDoc = 181, Title = "GK", IsActive = true },
                new Brand { Id = 99, TecDoc = 182, Title = "SCHLÜTTER TURBOLADER", IsActive = true },
                new Brand { Id = 100, TecDoc = 183, Title = "VEMO", IsActive = true },
                new Brand { Id = 101, TecDoc = 185, Title = "KAMOKA", IsActive = true },
                new Brand { Id = 102, TecDoc = 191, Title = "IMASAF", IsActive = true },
                new Brand { Id = 103, TecDoc = 192, Title = "FAG", IsActive = true },
                new Brand { Id = 104, TecDoc = 197, Title = "LPR", IsActive = true },
                new Brand { Id = 105, TecDoc = 198, Title = "OCAP", IsActive = true },
                new Brand { Id = 106, TecDoc = 202, Title = "GLYCO", IsActive = true },
                new Brand { Id = 107, TecDoc = 204, Title = "INA", IsActive = true },
                new Brand { Id = 108, TecDoc = 205, Title = "NRF", IsActive = true },
                new Brand { Id = 109, TecDoc = 206, Title = "A.B.S.", IsActive = true },
                new Brand { Id = 110, TecDoc = 207, Title = "CASTROL", IsActive = true },
                new Brand { Id = 111, TecDoc = 209, Title = "TRUCKTEC AUTOMOTIVE", IsActive = true },
                new Brand { Id = 112, TecDoc = 214, Title = "REMY", IsActive = true },
                new Brand { Id = 113, TecDoc = 215, Title = "CALORSTAT by Vernet", IsActive = true },
                new Brand { Id = 114, TecDoc = 216, Title = "NÜRAL", IsActive = true },
                new Brand { Id = 115, TecDoc = 220, Title = "AIRTEX", IsActive = true },
                new Brand { Id = 116, TecDoc = 222, Title = "LIQUI MOLY", IsActive = true },
                new Brand { Id = 117, TecDoc = 225, Title = "SCT - MANNOL", IsActive = true },
                new Brand { Id = 118, TecDoc = 226, Title = "ELSTOCK", IsActive = true },
                new Brand { Id = 119, TecDoc = 233, Title = "DINEX", IsActive = true },
                new Brand { Id = 120, TecDoc = 234, Title = "ERA", IsActive = true },
                new Brand { Id = 121, TecDoc = 235, Title = "FRECCIA", IsActive = true },
                new Brand { Id = 122, TecDoc = 240, Title = "FAE", IsActive = true },
                new Brand { Id = 123, TecDoc = 244, Title = "MEAT & DORIA", IsActive = true },
                new Brand { Id = 124, TecDoc = 247, Title = "AVA QUALITY COOLING", IsActive = true },
                new Brand { Id = 125, TecDoc = 248, Title = "NIPPARTS", IsActive = true },
                new Brand { Id = 126, TecDoc = 256, Title = "FILTRON", IsActive = true },
                new Brand { Id = 127, TecDoc = 257, Title = "ASHIKA", IsActive = true },
                new Brand { Id = 128, TecDoc = 260, Title = "SASIC", IsActive = true },
                new Brand { Id = 129, TecDoc = 267, Title = "FAI AutoParts", IsActive = true },
                new Brand { Id = 130, TecDoc = 268, Title = "JP GROUP", IsActive = true },
                new Brand { Id = 131, TecDoc = 277, Title = "AMC", IsActive = true },
                new Brand { Id = 132, TecDoc = 287, Title = "MAHLE", IsActive = true },
                new Brand { Id = 133, TecDoc = 294, Title = "SACHS PERFORMANCE", IsActive = true },
                new Brand { Id = 134, TecDoc = 295, Title = "fri.tech.", IsActive = true },
                new Brand { Id = 135, TecDoc = 297, Title = "sbs", IsActive = true },
                new Brand { Id = 136, TecDoc = 299, Title = "WEBASTO", IsActive = true },
                new Brand { Id = 137, TecDoc = 300, Title = "AUTEX", IsActive = true },
                new Brand { Id = 138, TecDoc = 301, Title = "TOPRAN", IsActive = true },
                new Brand { Id = 139, TecDoc = 305, Title = "K&N Filters", IsActive = true },
                new Brand { Id = 140, TecDoc = 310, Title = "GRAF", IsActive = true },
                new Brand { Id = 141, TecDoc = 311, Title = "CIFAM", IsActive = true },
                new Brand { Id = 142, TecDoc = 316, Title = "GENERAL RICAMBI", IsActive = true },
                new Brand { Id = 143, TecDoc = 323, Title = "AUTOMEGA", IsActive = true },
                new Brand { Id = 144, TecDoc = 324, Title = "WIX FILTERS", IsActive = true },
                new Brand { Id = 145, TecDoc = 326, Title = "BorgWarner (Schwitzer)", IsActive = true },
                new Brand { Id = 146, TecDoc = 327, Title = "BorgWarner", IsActive = true },
                new Brand { Id = 147, TecDoc = 328, Title = "BorgWarner (3K)", IsActive = true },
                new Brand { Id = 148, TecDoc = 331, Title = "ORIGINAL IMPERIUM", IsActive = true },
                new Brand { Id = 149, TecDoc = 340, Title = "PRASCO", IsActive = true },
                new Brand { Id = 150, TecDoc = 347, Title = "TRW Engine Component", IsActive = true },
                new Brand { Id = 151, TecDoc = 350, Title = "BLUE PRINT", IsActive = true },
                new Brand { Id = 152, TecDoc = 351, Title = "AUTOFREN SEINSA", IsActive = true },
                new Brand { Id = 153, TecDoc = 356, Title = "TESLA", IsActive = true },
                new Brand { Id = 154, TecDoc = 362, Title = "ALKAR", IsActive = true },
                new Brand { Id = 155, TecDoc = 367, Title = "FA1", IsActive = true },
                new Brand { Id = 156, TecDoc = 373, Title = "GSP", IsActive = true },
                new Brand { Id = 157, TecDoc = 376, Title = "CENTRA", IsActive = true },
                new Brand { Id = 158, TecDoc = 377, Title = "BOSCH DIAGNOSTICS", IsActive = true },
                new Brand { Id = 159, TecDoc = 380, Title = "FRENKIT", IsActive = true },
                new Brand { Id = 160, TecDoc = 385, Title = "GOETZE ENGINE", IsActive = true },
                new Brand { Id = 161, TecDoc = 388, Title = "MOTORAD", IsActive = true },
                new Brand { Id = 162, TecDoc = 389, Title = "GLYSANTIN", IsActive = true },
                new Brand { Id = 163, TecDoc = 391, Title = "EAI", IsActive = true },
                new Brand { Id = 164, TecDoc = 394, Title = "BARUM", IsActive = true },
                new Brand { Id = 165, TecDoc = 397, Title = "JANMOR", IsActive = true },
                new Brand { Id = 166, TecDoc = 399, Title = "EXEDY", IsActive = true },
                new Brand { Id = 167, TecDoc = 400, Title = "RAICAM", IsActive = true },
                new Brand { Id = 168, TecDoc = 403, Title = "MAXGEAR", IsActive = true },
                new Brand { Id = 169, TecDoc = 406, Title = "BM CATALYSTS", IsActive = true },
                new Brand { Id = 170, TecDoc = 409, Title = "FREMAX", IsActive = true },
                new Brand { Id = 171, TecDoc = 427, Title = "ASMET", IsActive = true },
                new Brand { Id = 172, TecDoc = 430, Title = "RTS", IsActive = true },
                new Brand { Id = 173, TecDoc = 432, Title = "KOLBENSCHMIDT", IsActive = true },
                new Brand { Id = 174, TecDoc = 433, Title = "STATIM", IsActive = true },
                new Brand { Id = 175, TecDoc = 436, Title = "MOTUL", IsActive = true },
                new Brand { Id = 176, TecDoc = 437, Title = "CoopersFiaam", IsActive = true },
                new Brand { Id = 177, TecDoc = 443, Title = "ENERGIZER", IsActive = true },
                new Brand { Id = 178, TecDoc = 447, Title = "PILKINGTON", IsActive = true },
                new Brand { Id = 179, TecDoc = 449, Title = "HITACHI", IsActive = true },
                new Brand { Id = 180, TecDoc = 454, Title = "BANDO", IsActive = true },
                new Brand { Id = 181, TecDoc = 460, Title = "DRI", IsActive = true },
                new Brand { Id = 182, TecDoc = 461, Title = "RAVENOL", IsActive = true },
                new Brand { Id = 183, TecDoc = 464, Title = "OSVAT", IsActive = true },
                new Brand { Id = 184, TecDoc = 467, Title = "CS Germany", IsActive = true },
                new Brand { Id = 185, TecDoc = 475, Title = "BORG & BECK", IsActive = true },
                new Brand { Id = 186, TecDoc = 483, Title = "ClimAir", IsActive = true },
                new Brand { Id = 187, TecDoc = 485, Title = "NARVA", IsActive = true },
                new Brand { Id = 188, TecDoc = 494, Title = "BRISK", IsActive = true },
                new Brand { Id = 189, TecDoc = 499, Title = "ZAFFO", IsActive = true },
                new Brand { Id = 190, TecDoc = 4005, Title = "EPS", IsActive = true },
                new Brand { Id = 191, TecDoc = 4006, Title = "KW", IsActive = true },
                new Brand { Id = 192, TecDoc = 4023, Title = "KS TOOLS", IsActive = true },
                new Brand { Id = 193, TecDoc = 4026, Title = "VIGOR", IsActive = true },
                new Brand { Id = 194, TecDoc = 4314, Title = "SHELL", IsActive = true },
                new Brand { Id = 195, TecDoc = 4333, Title = "Prestone", IsActive = true },
                new Brand { Id = 196, TecDoc = 4344, Title = "ELTA AUTOMOTIVE", IsActive = true },
                new Brand { Id = 197, TecDoc = 4346, Title = "VIKA", IsActive = true },
                new Brand { Id = 198, TecDoc = 4353, Title = "DPA", IsActive = true },
                new Brand { Id = 199, TecDoc = 4367, Title = "STOP&GO", IsActive = true },
                new Brand { Id = 200, TecDoc = 4372, Title = "PETEC", IsActive = true },
                new Brand { Id = 201, TecDoc = 4381, Title = "Airstal", IsActive = true },
                new Brand { Id = 202, TecDoc = 4434, Title = "CONTINENTAL", IsActive = true },
                new Brand { Id = 203, TecDoc = 4436, Title = "DUNLOP", IsActive = true },
                new Brand { Id = 204, TecDoc = 4449, Title = "MOBIL", IsActive = true },
                new Brand { Id = 205, TecDoc = 4451, Title = "YUASA", IsActive = true },
                new Brand { Id = 206, TecDoc = 4452, Title = "GS", IsActive = true },
                new Brand { Id = 207, TecDoc = 4457, Title = "SONAX", IsActive = true },
                new Brand { Id = 208, TecDoc = 4512, Title = "ERT", IsActive = true },
                new Brand { Id = 209, TecDoc = 4514, Title = "ET ENGINETEAM", IsActive = true },
                new Brand { Id = 210, TecDoc = 4536, Title = "LINEX", IsActive = true },
                new Brand { Id = 211, TecDoc = 4539, Title = "Arnott", IsActive = true },
                new Brand { Id = 212, TecDoc = 4593, Title = "TEDGUM", IsActive = true },
                new Brand { Id = 213, TecDoc = 4612, Title = "TUNGSRAM", IsActive = true },
                new Brand { Id = 214, TecDoc = 4615, Title = "GARRETT", IsActive = true },
                new Brand { Id = 215, TecDoc = 4657, Title = "ABAKUS", IsActive = true },
                new Brand { Id = 216, TecDoc = 4676, Title = "ROTINGER", IsActive = true },
                new Brand { Id = 217, TecDoc = 4679, Title = "CAFFARO", IsActive = true },
                new Brand { Id = 218, TecDoc = 4705, Title = "MOBILETRON", IsActive = true },
                new Brand { Id = 219, TecDoc = 4717, Title = "NE", IsActive = true },
                new Brand { Id = 220, TecDoc = 4719, Title = "LIFT-TEK", IsActive = true },
                new Brand { Id = 221, TecDoc = 4721, Title = "MIRAGLIO", IsActive = true },
                new Brand { Id = 222, TecDoc = 4734, Title = "HELLA GUTMANN", IsActive = true },
                new Brand { Id = 223, TecDoc = 4808, Title = "HAZET", IsActive = true },
                new Brand { Id = 224, TecDoc = 4815, Title = "Borsehung", IsActive = true },
                new Brand { Id = 225, TecDoc = 4821, Title = "QUARO", IsActive = true },
                new Brand { Id = 226, TecDoc = 4843, Title = "AS-PL", IsActive = true },
                new Brand { Id = 227, TecDoc = 4849, Title = "Ac Rolcar", IsActive = true },
                new Brand { Id = 228, TecDoc = 4866, Title = "ARAL", IsActive = true },
                new Brand { Id = 229, TecDoc = 4871, Title = "COFLE", IsActive = true },
                new Brand { Id = 230, TecDoc = 4873, Title = "POLMO", IsActive = true },
                new Brand { Id = 231, TecDoc = 4881, Title = "DYNAMAX", IsActive = true },
                new Brand { Id = 232, TecDoc = 4911, Title = "ALLIGATOR", IsActive = true },
                new Brand { Id = 233, TecDoc = 4912, Title = "GEDORE", IsActive = true },
                new Brand { Id = 234, TecDoc = 4923, Title = "NORMA", IsActive = true },
                new Brand { Id = 235, TecDoc = 4946, Title = "SCHRADER", IsActive = true },
                new Brand { Id = 236, TecDoc = 4949, Title = "TURBORAIL", IsActive = true },
                new Brand { Id = 237, TecDoc = 4969, Title = "ESEN SKV", IsActive = true },
                new Brand { Id = 238, TecDoc = 5251, Title = "HART", IsActive = true },
                new Brand { Id = 239, TecDoc = 6102, Title = "ACPS-ORIS", IsActive = true },
                new Brand { Id = 240, TecDoc = 6186, Title = "VALVOLINE", IsActive = true },
                new Brand { Id = 241, TecDoc = 6263, Title = "CPB", IsActive = true },
                new Brand { Id = 242, TecDoc = 6304, Title = "QUICK BRAKE", IsActive = true },
                new Brand { Id = 243, TecDoc = 6306, Title = "GKN", IsActive = true },
                new Brand { Id = 244, TecDoc = 6343, Title = "REPSOL", IsActive = true },
                new Brand { Id = 245, TecDoc = 6368, Title = "EBC Brakes", IsActive = true },
                new Brand { Id = 246, TecDoc = 6441, Title = "BERU by DRiV", IsActive = true },
                new Brand { Id = 247, TecDoc = 6444, Title = "BorgWarner (AWD)", IsActive = true },
                new Brand { Id = 248, TecDoc = 6534, Title = "Dr.Motor Automotive", IsActive = true },
                new Brand { Id = 249, TecDoc = 6558, Title = "AIC", IsActive = true },
                new Brand { Id = 250, TecDoc = 6984, Title = "Oyodo", IsActive = true },
                new Brand { Id = 251, TecDoc = 6985, Title = "JPN", IsActive = true }
                );
        }
    }
}
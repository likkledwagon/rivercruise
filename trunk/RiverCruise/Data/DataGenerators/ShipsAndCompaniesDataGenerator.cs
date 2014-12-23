using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using DataModels;

namespace Data.DataGenerators
{
    public class ShipsAndCompaniesDataGenerator
    {
        public static void FillShipsAndCompanies(RiverCruiseDB context)
        {
            var companies = new List<Company>();
            var vessels = new List<Ship>();
            try
            {
                var companycompanyC001 = new Company() {Name = "A\'ROSA"};
                companies.Add(companycompanyC001);
                var V00101 = new Ship()
                {
                    Eni = "4801170",
                    Flag = "GFR",
                    HotelStaff = 44,
                    Name = "A'ROSA BELLA",
                    NauticalCrew = 6,
                    Region = "Danube",
                    Company = companycompanyC001
                };
                vessels.Add(V00101);
                var V00102 = new Ship()
                {
                    Eni = "4801180",
                    Flag = "GFR",
                    HotelStaff = 44,
                    Name = "A'ROSA DONNA",
                    NauticalCrew = 6,
                    Region = "Danube",
                    Company = companycompanyC001
                };
                vessels.Add(V00102);
                var V00103 = new Ship()
                {
                    Eni = "4801870",
                    Flag = "GFR",
                    HotelStaff = 44,
                    Name = "A'ROSA MIA",
                    NauticalCrew = 6,
                    Region = "Danube",
                    Company = companycompanyC001
                };
                vessels.Add(V00103);
                var V00104 = new Ship()
                {
                    Eni = "4802780",
                    Flag = "GFR",
                    HotelStaff = 44,
                    Name = "A'ROSA RIVA",
                    NauticalCrew = 6,
                    Region = "Danube",
                    Company = companycompanyC001
                };
                vessels.Add(V00104);
                var V00105 = new Ship()
                {
                    Eni = "4803520",
                    Flag = "GFR",
                    HotelStaff = 39,
                    Name = "A'ROSA LUNA",
                    NauticalCrew = 6,
                    Region = "Rhone-Saone",
                    Company = companycompanyC001
                };
                vessels.Add(V00105);
                var V00106 = new Ship()
                {
                    Eni = "4803530",
                    Flag = "GFR",
                    HotelStaff = 39,
                    Name = "A'ROSA STELLA",
                    NauticalCrew = 6,
                    Region = "Rhone-Saone",
                    Company = companycompanyC001
                };
                vessels.Add(V00106);
                var V00107 = new Ship()
                {
                    Eni = "4807500",
                    Flag = "GFR",
                    HotelStaff = 43,
                    Name = "A'ROSA AQUA",
                    NauticalCrew = 6,
                    Region = "Rhine-Mosel",
                    Company = companycompanyC001
                };
                vessels.Add(V00107);
                var V00108 = new Ship()
                {
                    Eni = "4808020",
                    Flag = "GFR",
                    HotelStaff = 43,
                    Name = "A'ROSA VIVA",
                    NauticalCrew = 6,
                    Region = "Rhine-Mosel",
                    Company = companycompanyC001
                };
                vessels.Add(V00108);
                var V00109 = new Ship()
                {
                    Eni = "4809910",
                    Flag = "GFR",
                    HotelStaff = 43,
                    Name = "A'ROSA BRAVA",
                    NauticalCrew = 6,
                    Region = "Rhine-Mosel",
                    Company = companycompanyC001
                };
                vessels.Add(V00109);
                var V00110 = new Ship()
                {
                    Eni = "",
                    Flag = "",
                    HotelStaff = 44,
                    Name = "A'ROSA SILVA",
                    NauticalCrew = 6,
                    Region = "Rhine-Mosel-Danube",
                    Company = companycompanyC001
                };
                vessels.Add(V00110);
                var companycompanyC002 = new Company() {Name = "ADELE CRUISE,H-I-A"};
                companies.Add(companycompanyC002);
                var V00201 = new Ship()
                {
                    Eni = "2323525",
                    Flag = "NTH",
                    HotelStaff = 16,
                    Name = "PRINCESS",
                    NauticalCrew = 5,
                    Region = "Elbe-Havel-Oder",
                    Company = companycompanyC002
                };
                vessels.Add(V00201);
                var V00202 = new Ship()
                {
                    Eni = "2205451",
                    Flag = "NTH",
                    HotelStaff = 16,
                    Name = "ALEGRIA",
                    NauticalCrew = 5,
                    Region = "B/NL-Rhine ",
                    Company = companycompanyC002
                };
                vessels.Add(V00202);
                var companycompanyC003 = new Company() {Name = "AMA Waterways GmbH"};
                companies.Add(companycompanyC003);
                var V00301 = new Ship()
                {
                    Eni = "",
                    Flag = "GFR",
                    HotelStaff = 35,
                    Name = "AMADAGIO",
                    NauticalCrew = 6,
                    Region = "NL/Rhine-M-Danube",
                    Company = companycompanyC003
                };
                vessels.Add(V00301);
                var V00302 = new Ship()
                {
                    Eni = "7001837",
                    Flag = "GFR",
                    HotelStaff = 35,
                    Name = "AMALEGRO",
                    NauticalCrew = 6,
                    Region = "NL/Rhine-M-Danube",
                    Company = companycompanyC003
                };
                vessels.Add(V00302);
                var V00303 = new Ship()
                {
                    Eni = "7001862",
                    Flag = "SWZ",
                    HotelStaff = 35,
                    Name = "AMACELLO",
                    NauticalCrew = 6,
                    Region = "NL/Rhine-M-Danube",
                    Company = companycompanyC003
                };
                vessels.Add(V00303);
                var V00304 = new Ship()
                {
                    Eni = "7001864",
                    Flag = "SWZ",
                    HotelStaff = 35,
                    Name = "AMADANTE",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Danube",
                    Company = companycompanyC003
                };
                vessels.Add(V00304);
                var V00305 = new Ship()
                {
                    Eni = "7001908",
                    Flag = "SWZ",
                    HotelStaff = 35,
                    Name = "AMALYRA",
                    NauticalCrew = 6,
                    Region = "Rhine-M-M-Danube",
                    Company = companycompanyC003
                };
                vessels.Add(V00305);
                var V00306 = new Ship()
                {
                    Eni = "7001909",
                    Flag = "SWZ",
                    HotelStaff = 35,
                    Name = "AMADOLCE",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Danube",
                    Company = companycompanyC003
                };
                vessels.Add(V00306);
                var V00307 = new Ship()
                {
                    Eni = "2332082",
                    Flag = "SWZ",
                    HotelStaff = 43,
                    Name = "AMABELLA",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Danube",
                    Company = companycompanyC003
                };
                vessels.Add(V00307);
                var V00308 = new Ship()
                {
                    Eni = "7001725",
                    Flag = "SWZ",
                    HotelStaff = 43,
                    Name = "AMAVERDE",
                    NauticalCrew = 6,
                    Region = "Rhine_M-Danube",
                    Company = companycompanyC003
                };
                vessels.Add(V00308);
                var V00309 = new Ship()
                {
                    Eni = "",
                    Flag = "",
                    HotelStaff = 43,
                    Name = "AMACERTO",
                    NauticalCrew = 6,
                    Region = "",
                    Company = companycompanyC003
                };
                vessels.Add(V00309);
                var companycompanyC004 = new Company() {Name = "Amazonica Shipping GmbH"};
                companies.Add(companycompanyC004);
                var V00401 = new Ship()
                {
                    Eni = "30000218",
                    Flag = "AUT",
                    HotelStaff = 26,
                    Name = "THEODOR KORNER",
                    NauticalCrew = 6,
                    Region = "Danube",
                    Company = companycompanyC004
                };
                vessels.Add(V00401);
                var companycompanyC005 = new Company() {Name = "Beijerland Handel &  Scheepvaart BV"};
                companies.Add(companycompanyC005);
                var V00501 = new Ship()
                {
                    Eni = "2321035",
                    Flag = "NTH",
                    HotelStaff = 10,
                    Name = "FORTUNA",
                    NauticalCrew = 6,
                    Region = "For sale",
                    Company = companycompanyC005
                };
                vessels.Add(V00501);
                var V00502 = new Ship()
                {
                    Eni = "",
                    Flag = "GFR",
                    HotelStaff = 19,
                    Name = "RUGEN",
                    NauticalCrew = 6,
                    Region = "Danube",
                    Company = companycompanyC005
                };
                vessels.Add(V00502);
                var V00503 = new Ship()
                {
                    Eni = "3150589",
                    Flag = "NTH",
                    HotelStaff = 12,
                    Name = "HORIZON",
                    NauticalCrew = 6,
                    Region = "",
                    Company = companycompanyC005
                };
                vessels.Add(V00503);
                var companycompanyC006 = new Company() {Name = "Bonaventura Cruises"};
                companies.Add(companycompanyC006);
                var V00601 = new Ship()
                {
                    Eni = "2316938",
                    Flag = "NTH",
                    HotelStaff = 15,
                    Name = "VICTORIA AMAZONICA",
                    NauticalCrew = 6,
                    Region = "Rhine-Danube",
                    Company = companycompanyC006
                };
                vessels.Add(V00601);
                var V00602 = new Ship()
                {
                    Eni = "2323472",
                    Flag = "NTH",
                    HotelStaff = 16,
                    Name = "VICTORIA CRUZIANA",
                    NauticalCrew = 6,
                    Region = "Rhine-Mosel",
                    Company = companycompanyC006
                };
                vessels.Add(V00602);
                var V00603 = new Ship()
                {
                    Eni = "",
                    Flag = "",
                    HotelStaff = 33,
                    Name = "THEODOR KORNER",
                    NauticalCrew = 6,
                    Region = "Danube",
                    Company = companycompanyC006
                };
                vessels.Add(V00603);
                var V00604 = new Ship()
                {
                    Eni = "2326758",
                    Flag = "NTH",
                    HotelStaff = 18,
                    Name = "ABEL TASMAN",
                    NauticalCrew = 6,
                    Region = "Danube",
                    Company = companycompanyC006
                };
                vessels.Add(V00604);
                var companycompanyC007 = new Company() {Name = "BTR International River Cr."};
                companies.Add(companycompanyC007);
                var V00701 = new Ship()
                {
                    Eni = "2312870",
                    Flag = "NTH",
                    HotelStaff = null,
                    Name = "BRILLANT",
                    NauticalCrew = null,
                    Region = "Rhine, B/NL",
                    Company = companycompanyC007
                };
                vessels.Add(V00701);
                var companycompanyC008 = new Company() {Name = "Calanda River Line Cruises, Enkhuizen"};
                companies.Add(companycompanyC008);
                var V00801 = new Ship()
                {
                    Eni = "2312744",
                    Flag = "NTH",
                    HotelStaff = 6,
                    Name = "PATRIA",
                    NauticalCrew = 3,
                    Region = "Rhine-Mosel",
                    Company = companycompanyC008
                };
                vessels.Add(V00801);
                var V00802 = new Ship()
                {
                    Eni = "2325292",
                    Flag = "NTH",
                    HotelStaff = 15,
                    Name = "ANDANTE",
                    NauticalCrew = 5,
                    Region = "B/NL-Rhine ",
                    Company = companycompanyC008
                };
                vessels.Add(V00802);
                var V00803 = new Ship()
                {
                    Eni = "2326758",
                    Flag = "NTH",
                    HotelStaff = 18,
                    Name = "ALLEGRO",
                    NauticalCrew = 6,
                    Region = "B/NL-Rhine",
                    Company = companycompanyC008
                };
                vessels.Add(V00803);
                var companycompanyC009 = new Company() {Name = "Channel Cruises Holland B.V.,Monnickendam"};
                companies.Add(companycompanyC009);
                var V00901 = new Ship()
                {
                    Eni = "2211655",
                    Flag = "NTH",
                    HotelStaff = 5,
                    Name = "ANNA MARIA AGNES",
                    NauticalCrew = null,
                    Region = "Netherlands",
                    Company = companycompanyC009
                };
                vessels.Add(V00901);
                var V00902 = new Ship()
                {
                    Eni = "3310386",
                    Flag = "NTH",
                    HotelStaff = 5,
                    Name = "ANGELA ESMEE",
                    NauticalCrew = null,
                    Region = "Netherlands",
                    Company = companycompanyC009
                };
                vessels.Add(V00902);
                var companycompanyC010 = new Company() {Name = "CNF-Giurgiu NAV S.A."};
                companies.Add(companycompanyC010);
                var V01001 = new Ship()
                {
                    Eni = "",
                    Flag = "RUM",
                    HotelStaff = 69,
                    Name = "DONAUSTAR",
                    NauticalCrew = 6,
                    Region = "Danube",
                    Company = companycompanyC010
                };
                vessels.Add(V01001);
                var V01002 = new Ship()
                {
                    Eni = "",
                    Flag = "RUM",
                    HotelStaff = 69,
                    Name = "DELTASTAR",
                    NauticalCrew = 6,
                    Region = "Danube",
                    Company = companycompanyC010
                };
                vessels.Add(V01002);
                var companycompanyC011 = new Company() {Name = "Croisi Europe,  Strassbourg"};
                companies.Add(companycompanyC011);
                var V01101 = new Ship()
                {
                    Eni = "",
                    Flag = "FRA",
                    HotelStaff = 17,
                    Name = "ST. ODILE",
                    NauticalCrew = 6,
                    Region = "Rhine-Mosel",
                    Company = companycompanyC011
                };
                vessels.Add(V01101);
                var V01102 = new Ship()
                {
                    Eni = "",
                    Flag = "FRA",
                    HotelStaff = 19,
                    Name = "CAMARGUE",
                    NauticalCrew = 6,
                    Region = "Rhone-Saone",
                    Company = companycompanyC011
                };
                vessels.Add(V01102);
                var V01103 = new Ship()
                {
                    Eni = "",
                    Flag = "FRA",
                    HotelStaff = 19,
                    Name = "LA BOHEME",
                    NauticalCrew = 6,
                    Region = "Danube",
                    Company = companycompanyC011
                };
                vessels.Add(V01103);
                var V01104 = new Ship()
                {
                    Eni = "",
                    Flag = "FRA",
                    HotelStaff = 19,
                    Name = "DOUCE France",
                    NauticalCrew = 6,
                    Region = "Rhine",
                    Company = companycompanyC011
                };
                vessels.Add(V01104);
                var V01105 = new Ship()
                {
                    Eni = "",
                    Flag = "FRA",
                    HotelStaff = 20,
                    Name = "SYMPHONIE",
                    NauticalCrew = 6,
                    Region = "Danube",
                    Company = companycompanyC011
                };
                vessels.Add(V01105);
                var V01106 = new Ship()
                {
                    Eni = "",
                    Flag = "FRA",
                    HotelStaff = 18,
                    Name = "RENOIR",
                    NauticalCrew = 6,
                    Region = "Seine",
                    Company = companycompanyC011
                };
                vessels.Add(V01106);
                var V01107 = new Ship()
                {
                    Eni = "",
                    Flag = "FRA",
                    HotelStaff = 18,
                    Name = "MISTRAL",
                    NauticalCrew = 6,
                    Region = "Rhone-Saone",
                    Company = companycompanyC011
                };
                vessels.Add(V01107);
                var V01108 = new Ship()
                {
                    Eni = "",
                    Flag = "FRA",
                    HotelStaff = 18,
                    Name = "VAN GOGH",
                    NauticalCrew = 6,
                    Region = "Rhone-Saone",
                    Company = companycompanyC011
                };
                vessels.Add(V01108);
                var V01109 = new Ship()
                {
                    Eni = "",
                    Flag = "FRA",
                    HotelStaff = 18,
                    Name = "MONET",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Danube",
                    Company = companycompanyC011
                };
                vessels.Add(V01109);
                var V01110 = new Ship()
                {
                    Eni = "",
                    Flag = "FRA",
                    HotelStaff = 19,
                    Name = "MICHELANGELO",
                    NauticalCrew = 6,
                    Region = "Po",
                    Company = companycompanyC011
                };
                vessels.Add(V01110);
                var V01111 = new Ship()
                {
                    Eni = "",
                    Flag = "FRA",
                    HotelStaff = 14,
                    Name = "VICTOR HUGO",
                    NauticalCrew = 6,
                    Region = "Tisza-Danube",
                    Company = companycompanyC011
                };
                vessels.Add(V01111);
                var V01112 = new Ship()
                {
                    Eni = "",
                    Flag = "FRA",
                    HotelStaff = 14,
                    Name = "MONA LISA",
                    NauticalCrew = 6,
                    Region = "Elbe-Oder",
                    Company = companycompanyC011
                };
                vessels.Add(V01112);
                var V01113 = new Ship()
                {
                    Eni = "",
                    Flag = "FRA",
                    HotelStaff = 18,
                    Name = "France",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Danube",
                    Company = companycompanyC011
                };
                vessels.Add(V01113);
                var V01114 = new Ship()
                {
                    Eni = "",
                    Flag = "FRA",
                    HotelStaff = 18,
                    Name = "MODIGLIANI",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Danube",
                    Company = companycompanyC011
                };
                vessels.Add(V01114);
                var V01115 = new Ship()
                {
                    Eni = "18223026",
                    Flag = "FRA",
                    HotelStaff = 19,
                    Name = "PRINCESSE D'AQUITAINE",
                    NauticalCrew = 6,
                    Region = "Seine",
                    Company = companycompanyC011
                };
                vessels.Add(V01115);
                var V01116 = new Ship()
                {
                    Eni = "",
                    Flag = "FRA",
                    HotelStaff = 19,
                    Name = "SEINE PRINCESS",
                    NauticalCrew = 6,
                    Region = "Seine",
                    Company = companycompanyC011
                };
                vessels.Add(V01116);
                var V01117 = new Ship()
                {
                    Eni = "",
                    Flag = "FRA",
                    HotelStaff = 22,
                    Name = "VASCO DA GAMA",
                    NauticalCrew = 6,
                    Region = "Douro",
                    Company = companycompanyC011
                };
                vessels.Add(V01117);
                var V01118 = new Ship()
                {
                    Eni = "",
                    Flag = "FRA",
                    HotelStaff = 22,
                    Name = "INFANTE D. HENRIQUE",
                    NauticalCrew = 6,
                    Region = "Douro",
                    Company = companycompanyC011
                };
                vessels.Add(V01118);
                var V01119 = new Ship()
                {
                    Eni = "",
                    Flag = "FRA",
                    HotelStaff = 22,
                    Name = "FERNAO DE MAGALHAES",
                    NauticalCrew = 6,
                    Region = "Douro",
                    Company = companycompanyC011
                };
                vessels.Add(V01119);
                var V01120 = new Ship()
                {
                    Eni = "",
                    Flag = "FRA",
                    HotelStaff = 22,
                    Name = "LEONARDO DA VINCI",
                    NauticalCrew = 6,
                    Region = "Rhine-Mosel",
                    Company = companycompanyC011
                };
                vessels.Add(V01120);
                var V01121 = new Ship()
                {
                    Eni = "",
                    Flag = "FRA",
                    HotelStaff = 22,
                    Name = "BOTTICELLI",
                    NauticalCrew = 6,
                    Region = "Rhine-Mosel",
                    Company = companycompanyC011
                };
                vessels.Add(V01121);
                var V01122 = new Ship()
                {
                    Eni = "",
                    Flag = "FRA",
                    HotelStaff = 29,
                    Name = "BEETHOVEN",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Danube",
                    Company = companycompanyC011
                };
                vessels.Add(V01122);
                var V01123 = new Ship()
                {
                    Eni = "",
                    Flag = "BKG",
                    HotelStaff = 28,
                    Name = "LA BELLE DE CADIX",
                    NauticalCrew = 6,
                    Region = "Guadiana/Guadalq.",
                    Company = companycompanyC011
                };
                vessels.Add(V01123);
                var V01124 = new Ship()
                {
                    Eni = "",
                    Flag = "FRA",
                    HotelStaff = 29,
                    Name = "L'EUROPE",
                    NauticalCrew = 6,
                    Region = "Danube",
                    Company = companycompanyC011
                };
                vessels.Add(V01124);
                var V01125 = new Ship()
                {
                    Eni = "1823464",
                    Flag = "FRA",
                    HotelStaff = 29,
                    Name = "VIVALDI",
                    NauticalCrew = 6,
                    Region = "Danube",
                    Company = companycompanyC011
                };
                vessels.Add(V01125);
                var V01126 = new Ship()
                {
                    Eni = "",
                    Flag = "FRA",
                    HotelStaff = 29,
                    Name = "BRIGITTE BARDOT",
                    NauticalCrew = 6,
                    Region = "",
                    Company = companycompanyC011
                };
                vessels.Add(V01126);
                var companycompanyC012 = new Company() {Name = "DNV-Tours"};
                companies.Add(companycompanyC012);
                var V01201 = new Ship()
                {
                    Eni = "",
                    Flag = "POL",
                    HotelStaff = 5,
                    Name = "CLASSIC LADY",
                    NauticalCrew = 1,
                    Region = "Masuren",
                    Company = companycompanyC012
                };
                vessels.Add(V01201);
                var companycompanyC013 = new Company() {Name = "Douro Azul,  Portugal"};
                companies.Add(companycompanyC013);
                var V01301 = new Ship()
                {
                    Eni = "",
                    Flag = "PTG",
                    HotelStaff = 11,
                    Name = "ALTODOURO",
                    NauticalCrew = 6,
                    Region = "Douro",
                    Company = companycompanyC013
                };
                vessels.Add(V01301);
                var V01302 = new Ship()
                {
                    Eni = "",
                    Flag = "PTG",
                    HotelStaff = 17,
                    Name = "INVICTA",
                    NauticalCrew = 6,
                    Region = "Douro",
                    Company = companycompanyC013
                };
                vessels.Add(V01302);
                var V01303 = new Ship()
                {
                    Eni = "",
                    Flag = "PTG",
                    HotelStaff = 32,
                    Name = "DOURO QUEEN",
                    NauticalCrew = 6,
                    Region = "Douro",
                    Company = companycompanyC013
                };
                vessels.Add(V01303);
                var V01304 = new Ship()
                {
                    Eni = "",
                    Flag = "PTG",
                    HotelStaff = 32,
                    Name = "DOURO CRUISER",
                    NauticalCrew = 6,
                    Region = "Douro",
                    Company = companycompanyC013
                };
                vessels.Add(V01304);
                var V01305 = new Ship()
                {
                    Eni = "",
                    Flag = "PTG",
                    HotelStaff = 32,
                    Name = "DOURO SPIRIT",
                    NauticalCrew = 6,
                    Region = "Douro",
                    Company = companycompanyC013
                };
                vessels.Add(V01305);
                var companycompanyC014 = new Company() {Name = "Dunav Tours,  Rousse"};
                companies.Add(companycompanyC014);
                var V01401 = new Ship()
                {
                    Eni = "",
                    Flag = "BUL",
                    HotelStaff = 59,
                    Name = "ROUSSE",
                    NauticalCrew = 6,
                    Region = "Danube",
                    Company = companycompanyC014
                };
                vessels.Add(V01401);
                var V01402 = new Ship()
                {
                    Eni = "",
                    Flag = "BUL",
                    HotelStaff = 59,
                    Name = "SOFIA",
                    NauticalCrew = 6,
                    Region = "Danube",
                    Company = companycompanyC014
                };
                vessels.Add(V01402);
                var V01403 = new Ship()
                {
                    Eni = "",
                    Flag = "BUL",
                    HotelStaff = 25,
                    Name = "ELEGANT LADY",
                    NauticalCrew = 6,
                    Region = "NL,Rhine-Mosel-M-Dan.",
                    Company = companycompanyC014
                };
                vessels.Add(V01403);
                var V01404 = new Ship()
                {
                    Eni = "",
                    Flag = "BUL",
                    HotelStaff = 34,
                    Name = "ROUSSE PRESTIGE",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Danube",
                    Company = companycompanyC014
                };
                vessels.Add(V01404);
                var V01405 = new Ship()
                {
                    Eni = "",
                    Flag = "BUL",
                    HotelStaff = 24,
                    Name = "HEINRICH HEINE",
                    NauticalCrew = 6,
                    Region = "Rhine-Main",
                    Company = companycompanyC014
                };
                vessels.Add(V01405);
                var V01406 = new Ship()
                {
                    Eni = "",
                    Flag = "BUL",
                    HotelStaff = 34,
                    Name = "ARIANA",
                    NauticalCrew = 6,
                    Region = "",
                    Company = companycompanyC014
                };
                vessels.Add(V01406);
                var companycompanyC015 = new Company() {Name = "Euro Shipping  Voyages, Bemmel"};
                companies.Add(companycompanyC015);
                var V01501 = new Ship()
                {
                    Eni = "7001704",
                    Flag = "NTH",
                    HotelStaff = 34,
                    Name = "MY STORY",
                    NauticalCrew = 6,
                    Region = "Danube",
                    Company = companycompanyC015
                };
                vessels.Add(V01501);
                var V01502 = new Ship()
                {
                    Eni = "2326953",
                    Flag = "NTH",
                    HotelStaff = 28,
                    Name = "SERENADE 1",
                    NauticalCrew = 6,
                    Region = "Rhine-Mosel",
                    Company = companycompanyC015
                };
                vessels.Add(V01502);
                var V01503 = new Ship()
                {
                    Eni = "7001831",
                    Flag = "NTH",
                    HotelStaff = 40,
                    Name = "SERENITY",
                    NauticalCrew = 6,
                    Region = "Rhine-Mosel",
                    Company = companycompanyC015
                };
                vessels.Add(V01503);
                var V01504 = new Ship()
                {
                    Eni = "2328761",
                    Flag = "NTH",
                    HotelStaff = 30,
                    Name = "SERENADE 2",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Danube",
                    Company = companycompanyC015
                };
                vessels.Add(V01504);
                var V01505 = new Ship()
                {
                    Eni = "7001647",
                    Flag = "NTH",
                    HotelStaff = 30,
                    Name = "ROYAL CROWN",
                    NauticalCrew = 6,
                    Region = "B/NL,Rhine_M-Danube",
                    Company = companycompanyC015
                };
                vessels.Add(V01505);
                var V01506 = new Ship()
                {
                    Eni = "2329015",
                    Flag = "NTH",
                    HotelStaff = 24,
                    Name = "SWITZERLAND II",
                    NauticalCrew = 6,
                    Region = "NL-Rhine-Mosel-Neckar",
                    Company = companycompanyC015
                };
                vessels.Add(V01506);
                var companycompanyC016 = new Company() {Name = "Evropska Vodni Doprava"};
                companies.Add(companycompanyC016);
                var V01601 = new Ship()
                {
                    Eni = "32108292",
                    Flag = "CZR",
                    HotelStaff = 14,
                    Name = "FLORENTINA",
                    NauticalCrew = 5,
                    Region = "Elbe-Moldau",
                    Company = companycompanyC016
                };
                vessels.Add(V01601);
                var companycompanyC017 = new Company() {Name = "Favorit Reisen"};
                companies.Add(companycompanyC017);
                var V01701 = new Ship()
                {
                    Eni = "",
                    Flag = "GFR",
                    HotelStaff = 49,
                    Name = "ROSSINI",
                    NauticalCrew = 6,
                    Region = "Danube",
                    Company = companycompanyC017
                };
                vessels.Add(V01701);
                var companycompanyC018 = new Company() {Name = "Feenstra Rhine  Line, Arnhem"};
                companies.Add(companycompanyC018);
                var V01801 = new Ship()
                {
                    Eni = "2007059",
                    Flag = "NTH",
                    HotelStaff = 24,
                    Name = "LADY ANNE",
                    NauticalCrew = null,
                    Region = "Rhine-Mosel",
                    Company = companycompanyC018
                };
                vessels.Add(V01801);
                var V01802 = new Ship()
                {
                    Eni = "2311625",
                    Flag = "NTH",
                    HotelStaff = 24,
                    Name = "AZOLLA",
                    NauticalCrew = null,
                    Region = "B/NL, Rhine-Mosel",
                    Company = companycompanyC018
                };
                vessels.Add(V01802);
                var V01803 = new Ship()
                {
                    Eni = "2315334",
                    Flag = "",
                    HotelStaff = 20,
                    Name = "SALVINIA",
                    NauticalCrew = 5,
                    Region = "B/NL, Rhine-Mosel",
                    Company = companycompanyC018
                };
                vessels.Add(V01803);
                var V01804 = new Ship()
                {
                    Eni = "2325953",
                    Flag = "NTH",
                    HotelStaff = 12,
                    Name = "AMSTERDAM",
                    NauticalCrew = 5,
                    Region = "NL/B, Rhine",
                    Company = companycompanyC018
                };
                vessels.Add(V01804);
                var V01805 = new Ship()
                {
                    Eni = "",
                    Flag = "SWZ",
                    HotelStaff = 28,
                    Name = "STATENDAM",
                    NauticalCrew = 6,
                    Region = "NL, Rhine-Mosel",
                    Company = companycompanyC018
                };
                vessels.Add(V01805);
                var V01806 = new Ship()
                {
                    Eni = "",
                    Flag = "SWZ",
                    HotelStaff = 16,
                    Name = "ROTTERDAM",
                    NauticalCrew = 6,
                    Region = "Rhine-Mosel",
                    Company = companycompanyC018
                };
                vessels.Add(V01806);
                var V01807 = new Ship()
                {
                    Eni = "2321970",
                    Flag = "NTH",
                    HotelStaff = 12,
                    Name = "CALYPSO",
                    NauticalCrew = 6,
                    Region = "B/NL, Rhine-Mosel",
                    Company = companycompanyC018
                };
                vessels.Add(V01807);
                var V01808 = new Ship()
                {
                    Eni = "2205549",
                    Flag = "NTH",
                    HotelStaff = 15,
                    Name = "POSEIDON",
                    NauticalCrew = 6,
                    Region = "B/NL, Rhine-M-Mosel",
                    Company = companycompanyC018
                };
                vessels.Add(V01808);
                var V01809 = new Ship()
                {
                    Eni = "2319818",
                    Flag = "NTH",
                    HotelStaff = 16,
                    Name = "REMBRANDT VAN RIJN",
                    NauticalCrew = 6,
                    Region = "B/NL, Rhine-M-Mosel",
                    Company = companycompanyC018
                };
                vessels.Add(V01809);
                var V01810 = new Ship()
                {
                    Eni = "2326752",
                    Flag = "NTH",
                    HotelStaff = 15,
                    Name = "ARLENE",
                    NauticalCrew = 6,
                    Region = "Rhine-Mosel",
                    Company = companycompanyC018
                };
                vessels.Add(V01810);
                var V01811 = new Ship()
                {
                    Eni = "",
                    Flag = "SWZ",
                    HotelStaff = 19,
                    Name = "DA VINCI",
                    NauticalCrew = 6,
                    Region = "NL, Rhine-Main, Mosel",
                    Company = companycompanyC018
                };
                vessels.Add(V01811);
                var V01812 = new Ship()
                {
                    Eni = "2316938",
                    Flag = "NTH",
                    HotelStaff = 15,
                    Name = "HORIZON",
                    NauticalCrew = 6,
                    Region = "B/NL,Rhine-Mosel",
                    Company = companycompanyC018
                };
                vessels.Add(V01812);
                var V01813 = new Ship()
                {
                    Eni = "",
                    Flag = "SWZ",
                    HotelStaff = 29,
                    Name = "ANTONIO BELLUCCI",
                    NauticalCrew = 6,
                    Region = "",
                    Company = companycompanyC018
                };
                vessels.Add(V01813);

                var V01815 = new Ship()
                {
                    Eni = "2320666",
                    Flag = "NTH",
                    HotelStaff = 24,
                    Name = "RIVER AMBASSADOR",
                    NauticalCrew = 6,
                    Region = "B, NL, Rhine-M-Dan.",
                    Company = companycompanyC018
                };
                vessels.Add(V01815);
                var V01816 = new Ship()
                {
                    Eni = "2321750",
                    Flag = "NTH",
                    HotelStaff = 24,
                    Name = "RIVER BARONESS",
                    NauticalCrew = 6,
                    Region = "Seine",
                    Company = companycompanyC018
                };
                vessels.Add(V01816);
                var V01817 = new Ship()
                {
                    Eni = "2323692",
                    Flag = "NTH",
                    HotelStaff = 28,
                    Name = "RIVER QUEEN",
                    NauticalCrew = 6,
                    Region = "B, NL, Rhine-M-Dan.",
                    Company = companycompanyC018
                };
                vessels.Add(V01817);
                var V01818 = new Ship()
                {
                    Eni = "2325078",
                    Flag = "NTH",
                    HotelStaff = 28,
                    Name = "RIVER PRINCESS",
                    NauticalCrew = 6,
                    Region = "B, NL, Rhine-M-Dan.",
                    Company = companycompanyC018
                };
                vessels.Add(V01818);
                var V01819 = new Ship()
                {
                    Eni = "7001746",
                    Flag = "SWZ",
                    HotelStaff = 30,
                    Name = "RIVER EMPRESS",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Dan.",
                    Company = companycompanyC018
                };
                vessels.Add(V01819);
                var V01820 = new Ship()
                {
                    Eni = "",
                    Flag = "SWZ",
                    HotelStaff = 30,
                    Name = "RIVER COUNTESS",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Dan.",
                    Company = companycompanyC018
                };
                vessels.Add(V01820);
                var V01821 = new Ship()
                {
                    Eni = "",
                    Flag = "SWZ",
                    HotelStaff = 30,
                    Name = "RIVER DUCHESS",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Dan.",
                    Company = companycompanyC018
                };
                vessels.Add(V01821);
                var V01822 = new Ship()
                {
                    Eni = "2327301",
                    Flag = "NTH",
                    HotelStaff = 30,
                    Name = "RIVER ROYALE",
                    NauticalCrew = 6,
                    Region = "Rhone",
                    Company = companycompanyC018
                };
                vessels.Add(V01822);
                var V01823 = new Ship()
                {
                    Eni = "2329007",
                    Flag = "MTA",
                    HotelStaff = 36,
                    Name = "RIVER BEATRICE",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Dan.",
                    Company = companycompanyC018
                };
                vessels.Add(V01823);
                var V01824 = new Ship()
                {
                    Eni = "7001935",
                    Flag = "",
                    HotelStaff = 36,
                    Name = "S.S.ANTOINETTE",
                    NauticalCrew = 6,
                    Region = "Rhine",
                    Company = companycompanyC018
                };
                vessels.Add(V01824);
                var companycompanyC019 = new Company() {Name = "Goldberg Ventures BV"};
                companies.Add(companycompanyC019);
                var V01901 = new Ship()
                {
                    Eni = "2311506",
                    Flag = "NTH",
                    HotelStaff = 6,
                    Name = "SIR WINSTON",
                    NauticalCrew = 6,
                    Region = "NL-Rhine",
                    Company = companycompanyC019
                };
                vessels.Add(V01901);
                var companycompanyC020 = new Company() {Name = "Grand Circle Cruise Line s.r.o., Bratislava"};
                companies.Add(companycompanyC020);
                var V02001 = new Ship()
                {
                    Eni = "",
                    Flag = "FRA",
                    HotelStaff = 10,
                    Name = "CHARDONNAY",
                    NauticalCrew = 4,
                    Region = "Rhone-Saone",
                    Company = companycompanyC020
                };
                vessels.Add(V02001);
                var V02002 = new Ship()
                {
                    Eni = "",
                    Flag = "FRA",
                    HotelStaff = 10,
                    Name = "PROVENCE",
                    NauticalCrew = 4,
                    Region = "Rhone-Saone",
                    Company = companycompanyC020
                };
                vessels.Add(V02002);
                var V02003 = new Ship()
                {
                    Eni = "2315025",
                    Flag = "MTA",
                    HotelStaff = null,
                    Name = "RIVER ALEGRO",
                    NauticalCrew = null,
                    Region = "",
                    Company = companycompanyC020
                };
                vessels.Add(V02003);
                var V02004 = new Ship()
                {
                    Eni = "",
                    Flag = "MTA",
                    HotelStaff = 28,
                    Name = "RIVER MELODY",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Danube",
                    Company = companycompanyC020
                };
                vessels.Add(V02004);
                var V02005 = new Ship()
                {
                    Eni = "7001721",
                    Flag = "MTA",
                    HotelStaff = 28,
                    Name = "RIVER HARMONY",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Danube",
                    Company = companycompanyC020
                };
                vessels.Add(V02005);
                var V02006 = new Ship()
                {
                    Eni = "7001722",
                    Flag = "MTA",
                    HotelStaff = 28,
                    Name = "RIVER RHAPSODY",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Danube",
                    Company = companycompanyC020
                };
                vessels.Add(V02006);
                var V02007 = new Ship()
                {
                    Eni = "7001728",
                    Flag = "MTA",
                    HotelStaff = 28,
                    Name = "RIVER CONCERTO",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Danube",
                    Company = companycompanyC020
                };
                vessels.Add(V02007);
                var V02008 = new Ship()
                {
                    Eni = "7001740",
                    Flag = "MTA",
                    HotelStaff = 32,
                    Name = "RIVER ARIA",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Danube",
                    Company = companycompanyC020
                };
                vessels.Add(V02008);
                var V02009 = new Ship()
                {
                    Eni = "225609",
                    Flag = "MTA",
                    HotelStaff = 26,
                    Name = "BIZET",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Danube",
                    Company = companycompanyC020
                };
                vessels.Add(V02009);
                var V02010 = new Ship()
                {
                    Eni = "7001803",
                    Flag = "MTA",
                    HotelStaff = 32,
                    Name = "RIVER ADAGIO",
                    NauticalCrew = 6,
                    Region = "Danube",
                    Company = companycompanyC020
                };
                vessels.Add(V02010);
                var companycompanyC021 = new Company() {Name = "Göta Kanal Rederi AB"};
                companies.Add(companycompanyC021);
                var V02101 = new Ship()
                {
                    Eni = "",
                    Flag = "SWE",
                    HotelStaff = 8,
                    Name = "JUNO",
                    NauticalCrew = 6,
                    Region = "Göta Kanal",
                    Company = companycompanyC021
                };
                vessels.Add(V02101);
                var V02102 = new Ship()
                {
                    Eni = "",
                    Flag = "SWE",
                    HotelStaff = null,
                    Name = "WILHEM THAM",
                    NauticalCrew = null,
                    Region = "Göta Kanal",
                    Company = companycompanyC021
                };
                vessels.Add(V02102);
                var V02103 = new Ship()
                {
                    Eni = "",
                    Flag = "SWE",
                    HotelStaff = null,
                    Name = "DIANA",
                    NauticalCrew = null,
                    Region = "Göta Kanal",
                    Company = companycompanyC021
                };
                vessels.Add(V02103);
                var companycompanyC022 = new Company() {Name = "Grunewald, Peter"};
                companies.Add(companycompanyC022);
                var V02201 = new Ship()
                {
                    Eni = "",
                    Flag = "GFR",
                    HotelStaff = 18,
                    Name = "SANS SOUCI",
                    NauticalCrew = 6,
                    Region = "Elbe, Havel, Oder",
                    Company = companycompanyC022
                };
                vessels.Add(V02201);
                var companycompanyC023 = new Company() {Name = "Lüftner Reisen GmbH,  Innsbruck"};
                companies.Add(companycompanyC023);
                var V02301 = new Ship()
                {
                    Eni = "",
                    Flag = "RUM",
                    HotelStaff = 30,
                    Name = "DANUBIA",
                    NauticalCrew = 6,
                    Region = "Danube",
                    Company = companycompanyC023
                };
                vessels.Add(V02301);
                var V02302 = new Ship()
                {
                    Eni = "8848003",
                    Flag = "GFR",
                    HotelStaff = 34,
                    Name = "DERTOUR AMADEUS",
                    NauticalCrew = 6,
                    Region = "Danube",
                    Company = companycompanyC023
                };
                vessels.Add(V02302);
                var V02303 = new Ship()
                {
                    Eni = "8848002",
                    Flag = "GFR",
                    HotelStaff = 34,
                    Name = "AMADEUS RHAPSODY",
                    NauticalCrew = 6,
                    Region = "Danube",
                    Company = companycompanyC023
                };
                vessels.Add(V02303);
                var V02304 = new Ship()
                {
                    Eni = "4801620",
                    Flag = "GFR",
                    HotelStaff = 34,
                    Name = "AMADEUS CLASSIC",
                    NauticalCrew = 6,
                    Region = "Danube",
                    Company = companycompanyC023
                };
                vessels.Add(V02304);
                var V02305 = new Ship()
                {
                    Eni = "4802330",
                    Flag = "GFR",
                    HotelStaff = 34,
                    Name = "AMADEUS SYMPHONY",
                    NauticalCrew = 6,
                    Region = "Mosel-Rhine-M-Dan.",
                    Company = companycompanyC023
                };
                vessels.Add(V02305);
                var V02306 = new Ship()
                {
                    Eni = "4803670",
                    Flag = "GFR",
                    HotelStaff = 34,
                    Name = "AMADEUS ROYAL",
                    NauticalCrew = 6,
                    Region = "B/NL, Rhine-M-D.",
                    Company = companycompanyC023
                };
                vessels.Add(V02306);
                var V02307 = new Ship()
                {
                    Eni = "4804710",
                    Flag = "GFR",
                    HotelStaff = 34,
                    Name = "AMADEUS PRINCESS",
                    NauticalCrew = 6,
                    Region = "B/NL, Rhine-M-D.",
                    Company = companycompanyC023
                };
                vessels.Add(V02307);
                var V02308 = new Ship()
                {
                    Eni = "4807380",
                    Flag = "GFR",
                    HotelStaff = 34,
                    Name = "AMADEUS DIAMOND",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Danube",
                    Company = companycompanyC023
                };
                vessels.Add(V02308);
                var V02309 = new Ship()
                {
                    Eni = "4808350",
                    Flag = "GFR",
                    HotelStaff = 34,
                    Name = "AMADEUS ELEGANT",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Danube",
                    Company = companycompanyC023
                };
                vessels.Add(V02309);
                var V02310 = new Ship()
                {
                    Eni = "",
                    Flag = "GFR",
                    HotelStaff = 34,
                    Name = "AMADEUS BRILLIANT",
                    NauticalCrew = 6,
                    Region = "B/NL-Rhine-M-Danube",
                    Company = companycompanyC023
                };
                vessels.Add(V02310);
                var companycompanyC024 = new Company() {Name = "Magna Carta Steamship"};
                companies.Add(companycompanyC024);
                var V02401 = new Ship()
                {
                    Eni = "",
                    Flag = "GBI",
                    HotelStaff = 14,
                    Name = "LORD OF THE GLENS",
                    NauticalCrew = 6,
                    Region = "Scotland-Caledonian Canal",
                    Company = companycompanyC024
                };
                vessels.Add(V02401);
                var companycompanyC025 = new Company() {Name = "Marine Cruise Co.  Caravella"};
                companies.Add(companycompanyC025);
                var V02501 = new Ship()
                {
                    Eni = "9948003",
                    Flag = "MTA",
                    HotelStaff = 29,
                    Name = "PRINZESSIN KATHARINA",
                    NauticalCrew = 6,
                    Region = "Danube",
                    Company = companycompanyC025
                };
                vessels.Add(V02501);
                var companycompanyC026 = new Company() {Name = "Nederlandse  Rode Kruis"};
                companies.Add(companycompanyC026);
                var V02601 = new Ship()
                {
                    Eni = "2322387",
                    Flag = "NTH",
                    HotelStaff = 8,
                    Name = "J. HENRY DUNANT",
                    NauticalCrew = 6,
                    Region = "NL, Rhine",
                    Company = companycompanyC026
                };
                vessels.Add(V02601);
                var companycompanyC027 = new Company() {Name = "Cruiselines  Nijmegen B.V."};
                companies.Add(companycompanyC027);
                var V02701 = new Ship()
                {
                    Eni = "",
                    Flag = "NTH",
                    HotelStaff = 34,
                    Name = "BELLRIVA",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Danube",
                    Company = companycompanyC027
                };
                vessels.Add(V02701);
                var V02702 = new Ship()
                {
                    Eni = "2322470",
                    Flag = "NTH",
                    HotelStaff = 15,
                    Name = "SERENA",
                    NauticalCrew = 5,
                    Region = "NL",
                    Company = companycompanyC027
                };
                vessels.Add(V02702);
                var V02703 = new Ship()
                {
                    Eni = "2327268",
                    Flag = "NTH",
                    HotelStaff = 17,
                    Name = "NORMANDIE",
                    NauticalCrew = 6,
                    Region = "Rhine-Mosel",
                    Company = companycompanyC027
                };
                vessels.Add(V02703);
                var companycompanyC028 = new Company() {Name = "Parness Cruise sarl"};
                companies.Add(companycompanyC028);
                var V02801 = new Ship()
                {
                    Eni = "",
                    Flag = "FRA",
                    HotelStaff = 5,
                    Name = "LE VIP PARIS",
                    NauticalCrew = 1,
                    Region = "Seine",
                    Company = companycompanyC028
                };
                vessels.Add(V02801);
                var companycompanyC029 = new Company() {Name = "Premicon AG,  München"};
                companies.Add(companycompanyC029);
                var V02901 = new Ship()
                {
                    Eni = "",
                    Flag = "MTA",
                    HotelStaff = 44,
                    Name = "MOZART",
                    NauticalCrew = 6,
                    Region = "Danube",
                    Company = companycompanyC029
                };
                vessels.Add(V02901);
                var V02902 = new Ship()
                {
                    Eni = "",
                    Flag = "MTA",
                    HotelStaff = 34,
                    Name = "MARIBELLE",
                    NauticalCrew = 6,
                    Region = "Rhone-Saone",
                    Company = companycompanyC029
                };
                vessels.Add(V02902);
                var V02903 = new Ship()
                {
                    Eni = "",
                    Flag = "MTA",
                    HotelStaff = 34,
                    Name = "CLASSICA",
                    NauticalCrew = 6,
                    Region = "Danube",
                    Company = companycompanyC029
                };
                vessels.Add(V02903);
                var V02904 = new Ship()
                {
                    Eni = "9948004",
                    Flag = "MTA",
                    HotelStaff = 37,
                    Name = "BOLERO",
                    NauticalCrew = 6,
                    Region = "Danube",
                    Company = companycompanyC029
                };
                vessels.Add(V02904);
                var V02905 = new Ship()
                {
                    Eni = "9948005",
                    Flag = "MTA",
                    HotelStaff = 34,
                    Name = "TUI MAXIMA",
                    NauticalCrew = 6,
                    Region = "NL-Rhine-M-Danube",
                    Company = companycompanyC029
                };
                vessels.Add(V02905);
                var V02906 = new Ship()
                {
                    Eni = "9948006",
                    Flag = "MTA",
                    HotelStaff = 38,
                    Name = "JOHANN STRAUSS",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Danube",
                    Company = companycompanyC029
                };
                vessels.Add(V02906);
                var V02907 = new Ship()
                {
                    Eni = "9948007",
                    Flag = "MTA",
                    HotelStaff = 37,
                    Name = "DCS AMETHYST",
                    NauticalCrew = 6,
                    Region = "Danube",
                    Company = companycompanyC029
                };
                vessels.Add(V02907);
                var V02908 = new Ship()
                {
                    Eni = "9948008",
                    Flag = "MTA",
                    HotelStaff = 38,
                    Name = "VIKTORIA",
                    NauticalCrew = 6,
                    Region = "B/NL, Rhine-M-Dan.",
                    Company = companycompanyC029
                };
                vessels.Add(V02908);
                var V02909 = new Ship()
                {
                    Eni = "9948000",
                    Flag = "MTA",
                    HotelStaff = 37,
                    Name = "BELVEDERE",
                    NauticalCrew = 6,
                    Region = "Danube",
                    Company = companycompanyC029
                };
                vessels.Add(V02909);
                var V02910 = new Ship()
                {
                    Eni = "9948011",
                    Flag = "MTA",
                    HotelStaff = 38,
                    Name = "FLAMENCO",
                    NauticalCrew = 6,
                    Region = "Danube",
                    Company = companycompanyC029
                };
                vessels.Add(V02910);
                var V02911 = new Ship()
                {
                    Eni = "9948012",
                    Flag = "MTA",
                    HotelStaff = 37,
                    Name = "AVALON TAPESTRY",
                    NauticalCrew = 6,
                    Region = "Rhine-Mosel-Main",
                    Company = companycompanyC029
                };
                vessels.Add(V02911);
                var V02912 = new Ship()
                {
                    Eni = "9948013",
                    Flag = "MTA",
                    HotelStaff = 38,
                    Name = "BELLEVUE",
                    NauticalCrew = 6,
                    Region = "NL/B, Rhine-M-Danube",
                    Company = companycompanyC029
                };
                vessels.Add(V02912);
                var V02913 = new Ship()
                {
                    Eni = "9948015",
                    Flag = "MTA",
                    HotelStaff = 37,
                    Name = "AVALON TRANQUILITY",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Danube",
                    Company = companycompanyC029
                };
                vessels.Add(V02913);
                var V02914 = new Ship()
                {
                    Eni = "9948014",
                    Flag = "MTA",
                    HotelStaff = 38,
                    Name = "AVALON IMAGERY",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Danube",
                    Company = companycompanyC029
                };
                vessels.Add(V02914);
                var V02915 = new Ship()
                {
                    Eni = "4806540",
                    Flag = "MTA",
                    HotelStaff = 54,
                    Name = "PREMICON QUEEN",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Danube",
                    Company = companycompanyC029
                };
                vessels.Add(V02915);
                var V02916 = new Ship()
                {
                    Eni = "65000001",
                    Flag = "MTA",
                    HotelStaff = 38,
                    Name = "TUI SONATA",
                    NauticalCrew = 6,
                    Region = "B/NL-Rhine-Mosel",
                    Company = companycompanyC029
                };
                vessels.Add(V02916);
                var V02917 = new Ship()
                {
                    Eni = "4809190",
                    Flag = "MTA",
                    HotelStaff = 38,
                    Name = "TUI ALLEGRA",
                    NauticalCrew = 6,
                    Region = "Rhine-Main",
                    Company = companycompanyC029
                };
                vessels.Add(V02917);
                var V02918 = new Ship()
                {
                    Eni = "4809200",
                    Flag = "MTA",
                    HotelStaff = 38,
                    Name = "TUI MELODIA",
                    NauticalCrew = 6,
                    Region = "Danube",
                    Company = companycompanyC029
                };
                vessels.Add(V02918);
                var companycompanyC030 = new Company() {Name = "Rijfers River Cruises"};
                companies.Add(companycompanyC030);
                var V03001 = new Ship()
                {
                    Eni = "2007993",
                    Flag = "NTH",
                    HotelStaff = 20,
                    Name = "REX-RHENI",
                    NauticalCrew = 6,
                    Region = "Rhine-Mosel, B/NL",
                    Company = companycompanyC030
                };
                vessels.Add(V03001);
                var V03002 = new Ship()
                {
                    Eni = "2324591",
                    Flag = "NTH",
                    HotelStaff = 28,
                    Name = "REGINA-RHENI",
                    NauticalCrew = 6,
                    Region = "Rhine-Main-Danube",
                    Company = companycompanyC030
                };
                vessels.Add(V03002);
                var companycompanyC031 = new Company() {Name = "River Advice AG, Basel"};
                companies.Add(companycompanyC031);
                var V03101 = new Ship()
                {
                    Eni = "7001701",
                    Flag = "SWZ",
                    HotelStaff = 39,
                    Name = "BRITANNIA",
                    NauticalCrew = 6,
                    Region = "Rhine-Main/Mosel",
                    Company = companycompanyC031
                };
                vessels.Add(V03101);
                var V03102 = new Ship()
                {
                    Eni = "7001703",
                    Flag = "SWZ",
                    HotelStaff = 34,
                    Name = "ALEMANNIA",
                    NauticalCrew = 6,
                    Region = "Rhine-Mosel",
                    Company = companycompanyC031
                };
                vessels.Add(V03102);
                var V03103 = new Ship()
                {
                    Eni = "7001847",
                    Flag = "SWZ",
                    HotelStaff = 28,
                    Name = "FIDELIO",
                    NauticalCrew = 6,
                    Region = "Main-Danube",
                    Company = companycompanyC031
                };
                vessels.Add(V03103);
                var V03104 = new Ship()
                {
                    Eni = "70011846",
                    Flag = "SWZ",
                    HotelStaff = 17,
                    Name = "OLYMPIA",
                    NauticalCrew = 6,
                    Region = "Rhine",
                    Company = companycompanyC031
                };
                vessels.Add(V03104);
                var V03105 = new Ship()
                {
                    Eni = "4033510",
                    Flag = "GFR",
                    HotelStaff = 15,
                    Name = "JOHANNES BRAHMS",
                    NauticalCrew = 6,
                    Region = "Elbe-Oder",
                    Company = companycompanyC031
                };
                vessels.Add(V03105);
                var V03106 = new Ship()
                {
                    Eni = "4804650",
                    Flag = "SWZ",
                    HotelStaff = 30,
                    Name = "RIVER NAVIGATOR",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Danube",
                    Company = companycompanyC031
                };
                vessels.Add(V03106);
                var V03107 = new Ship()
                {
                    Eni = "4804640",
                    Flag = "MTA",
                    HotelStaff = 34,
                    Name = "RIVER EXPLORER",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Danube",
                    Company = companycompanyC031
                };
                vessels.Add(V03107);
                var V03108 = new Ship()
                {
                    Eni = "4804660",
                    Flag = "MTA",
                    HotelStaff = 34,
                    Name = "RIVER ODYSSEY",
                    NauticalCrew = 6,
                    Region = "NL,Rhine-Mosel-M-Dan.",
                    Company = companycompanyC031
                };
                vessels.Add(V03108);
                var V03109 = new Ship()
                {
                    Eni = "",
                    Flag = "",
                    HotelStaff = 39,
                    Name = "RIVER DISCOVERY II ",
                    NauticalCrew = 6,
                    Region = "",
                    Company = companycompanyC031
                };
                vessels.Add(V03109);
                var V03110 = new Ship()
                {
                    Eni = "7001819",
                    Flag = "SWZ",
                    HotelStaff = 17,
                    Name = "REMBRANT",
                    NauticalCrew = 5,
                    Region = "Rhone",
                    Company = companycompanyC031
                };
                vessels.Add(V03110);
                var V03111 = new Ship()
                {
                    Eni = "7001812",
                    Flag = "GFR",
                    HotelStaff = 26,
                    Name = "RIVER ART",
                    NauticalCrew = 6,
                    Region = "Rhine",
                    Company = companycompanyC031
                };
                vessels.Add(V03111);
                var V03112 = new Ship()
                {
                    Eni = "7001833",
                    Flag = "SWZ",
                    HotelStaff = 28,
                    Name = "EXCELLENCE RHONE",
                    NauticalCrew = 6,
                    Region = "Rhone",
                    Company = companycompanyC031
                };
                vessels.Add(V03112);
                var V03113 = new Ship()
                {
                    Eni = "",
                    Flag = "SWZ",
                    HotelStaff = 30,
                    Name = "EXCELLENCE QUEEN",
                    NauticalCrew = 6,
                    Region = "Rhine",
                    Company = companycompanyC031
                };
                vessels.Add(V03113);
                var V03114 = new Ship()
                {
                    Eni = "",
                    Flag = "SWZ",
                    HotelStaff = 34,
                    Name = "SOUND OF MUSIC",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Danube",
                    Company = companycompanyC031
                };
                vessels.Add(V03114);
                var V03115 = new Ship()
                {
                    Eni = "",
                    Flag = "SWZ",
                    HotelStaff = 29,
                    Name = "PRINCESSE DE PROVENCE",
                    NauticalCrew = 6,
                    Region = "Rhone-Saone",
                    Company = companycompanyC031
                };
                vessels.Add(V03115);
                var V03116 = new Ship()
                {
                    Eni = "",
                    Flag = "SWZ",
                    HotelStaff = 11,
                    Name = "KONIGSTEIN",
                    NauticalCrew = 4,
                    Region = "Elbe-Havel",
                    Company = companycompanyC031
                };
                vessels.Add(V03116);
                var V03117 = new Ship()
                {
                    Eni = "5117120",
                    Flag = "SWZ",
                    HotelStaff = 14,
                    Name = "CEZANNE",
                    NauticalCrew = 4,
                    Region = "Seine",
                    Company = companycompanyC031
                };
                vessels.Add(V03117);
                var V03118 = new Ship()
                {
                    Eni = "5803950",
                    Flag = "SWZ",
                    HotelStaff = 16,
                    Name = "KATHARINA VON BORA",
                    NauticalCrew = 5,
                    Region = "Elbe-Havel",
                    Company = companycompanyC031
                };
                vessels.Add(V03118);
                var V03119 = new Ship()
                {
                    Eni = "4800110",
                    Flag = "SWZ",
                    HotelStaff = 24,
                    Name = "CASANOVA",
                    NauticalCrew = 5,
                    Region = "Mosel-Rhine-Neckar",
                    Company = companycompanyC031
                };
                vessels.Add(V03119);
                var V03120 = new Ship()
                {
                    Eni = "4801240",
                    Flag = "SWZ",
                    HotelStaff = 16,
                    Name = "FREDERIC CHOPIN",
                    NauticalCrew = 5,
                    Region = "Elbe-Havel-Oder",
                    Company = companycompanyC031
                };
                vessels.Add(V03120);
                var V03121 = new Ship()
                {
                    Eni = "4802890",
                    Flag = "SWZ",
                    HotelStaff = 29,
                    Name = "HEIDELBERG",
                    NauticalCrew = 6,
                    Region = "Danube",
                    Company = companycompanyC031
                };
                vessels.Add(V03121);
                var V03122 = new Ship()
                {
                    Eni = "7001859",
                    Flag = "SWZ",
                    HotelStaff = 24,
                    Name = "BELLISSIMA",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Danube",
                    Company = companycompanyC031
                };
                vessels.Add(V03122);
                var V03123 = new Ship()
                {
                    Eni = "",
                    Flag = "",
                    HotelStaff = 33,
                    Name = "AVALON SCENERY",
                    NauticalCrew = 6,
                    Region = "Rhone",
                    Company = companycompanyC031
                };
                vessels.Add(V03123);
                var V03124 = new Ship()
                {
                    Eni = "2330846",
                    Flag = "GFR",
                    HotelStaff = 33,
                    Name = "AVALON AFFINITY",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Danube",
                    Company = companycompanyC031
                };
                vessels.Add(V03124);
                var V03125 = new Ship()
                {
                    Eni = "2331194",
                    Flag = "GFR",
                    HotelStaff = 33,
                    Name = "AVALON CREATIVITY",
                    NauticalCrew = 6,
                    Region = "Seine",
                    Company = companycompanyC031
                };
                vessels.Add(V03125);
                var V03126 = new Ship()
                {
                    Eni = "2332007",
                    Flag = "GFR",
                    HotelStaff = 31,
                    Name = "AVALON FELICITY",
                    NauticalCrew = 6,
                    Region = "Rhine",
                    Company = companycompanyC031
                };
                vessels.Add(V03126);
                var V03127 = new Ship()
                {
                    Eni = "2332637",
                    Flag = "GFR",
                    HotelStaff = 31,
                    Name = "AVALON LUMINERY",
                    NauticalCrew = 6,
                    Region = "Rhine-Mosel-M-Dan.",
                    Company = companycompanyC031
                };
                vessels.Add(V03127);
                var V03128 = new Ship()
                {
                    Eni = "2333460",
                    Flag = "SWZ",
                    HotelStaff = 41,
                    Name = "AVALON PANORAMA",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Danube",
                    Company = companycompanyC031
                };
                vessels.Add(V03128);
                var V03129 = new Ship()
                {
                    Eni = "",
                    Flag = "",
                    HotelStaff = 41,
                    Name = "AVALON VISTA",
                    NauticalCrew = 6,
                    Region = "",
                    Company = companycompanyC031
                };
                vessels.Add(V03129);
                var V03130 = new Ship()
                {
                    Eni = "",
                    Flag = "",
                    HotelStaff = 29,
                    Name = "AVALON VISIONARY",
                    NauticalCrew = 6,
                    Region = "",
                    Company = companycompanyC031
                };
                vessels.Add(V03130);
                var V03131 = new Ship()
                {
                    Eni = "",
                    Flag = "",
                    HotelStaff = 29,
                    Name = "AVALON ARTISTRY II",
                    NauticalCrew = 6,
                    Region = "",
                    Company = companycompanyC031
                };
                vessels.Add(V03131);
                var companycompanyC032 = new Company() {Name = "River Tours AG/Royal Cruises AG"};
                companies.Add(companycompanyC032);
                var V03201 = new Ship()
                {
                    Eni = "7001515",
                    Flag = "SWZ",
                    HotelStaff = 24,
                    Name = "SWITZERLAND",
                    NauticalCrew = 6,
                    Region = "Rhine-Mosel-Main",
                    Company = companycompanyC032
                };
                vessels.Add(V03201);
                var V03202 = new Ship()
                {
                    Eni = "2332815",
                    Flag = "SWZ",
                    HotelStaff = 32,
                    Name = "EXCELLENCE ROYAL ",
                    NauticalCrew = 6,
                    Region = "Rhine-Mosel-M-Danube",
                    Company = companycompanyC032
                };
                vessels.Add(V03202);
                var companycompanyC033 = new Company() {Name = "Scenic Tours  Europe AG, Zug"};
                companies.Add(companycompanyC033);
                var V03301 = new Ship()
                {
                    Eni = "7001869",
                    Flag = "SWZ",
                    HotelStaff = 38,
                    Name = "SCENIC EMERALD",
                    NauticalCrew = 6,
                    Region = "Danube",
                    Company = companycompanyC033
                };
                vessels.Add(V03301);
                var V03302 = new Ship()
                {
                    Eni = "7001865",
                    Flag = "SWZ",
                    HotelStaff = 38,
                    Name = "SCENIC SAPPHIRE",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Danube",
                    Company = companycompanyC033
                };
                vessels.Add(V03302);
                var V03303 = new Ship()
                {
                    Eni = "7001905",
                    Flag = "SWZ",
                    HotelStaff = 38,
                    Name = "SCENIC DIAMOND",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Danube",
                    Company = companycompanyC033
                };
                vessels.Add(V03303);
                var V03304 = new Ship()
                {
                    Eni = "7001907",
                    Flag = "SWZ",
                    HotelStaff = 38,
                    Name = "SCENIC RUBY",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Danube",
                    Company = companycompanyC033
                };
                vessels.Add(V03304);
                var V03305 = new Ship()
                {
                    Eni = "",
                    Flag = "",
                    HotelStaff = 39,
                    Name = "SCENIC CRYSTAL",
                    NauticalCrew = 6,
                    Region = "",
                    Company = companycompanyC033
                };
                vessels.Add(V03305);
                var V03306 = new Ship()
                {
                    Eni = "65000002",
                    Flag = "MTA",
                    HotelStaff = 39,
                    Name = "SCENIC PEARL",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Danube",
                    Company = companycompanyC033
                };
                vessels.Add(V03306);
                var companycompanyC034 = new Company() {Name = "SCI Swiss Cruises International Kreuzf.G"};
                companies.Add(companycompanyC034);
                var V03401 = new Ship()
                {
                    Eni = "7001848",
                    Flag = "SWZ",
                    HotelStaff = 34,
                    Name = "NESTROY",
                    NauticalCrew = 6,
                    Region = "Danube",
                    Company = companycompanyC034
                };
                vessels.Add(V03401);
                var V03402 = new Ship()
                {
                    Eni = "7001903",
                    Flag = "SWZ",
                    HotelStaff = 21,
                    Name = "PRINCESS SOPHIE",
                    NauticalCrew = 5,
                    Region = "Danube",
                    Company = companycompanyC034
                };
                vessels.Add(V03402);
                var companycompanyC035 = new Company() {Name = "Scylla Tours  AG, Basel"};
                companies.Add(companycompanyC035);
                var V03501 = new Ship()
                {
                    Eni = "7001632",
                    Flag = "SWZ",
                    HotelStaff = 21,
                    Name = "SWISS PEARL",
                    NauticalCrew = 6,
                    Region = "Rhone-Saone since 2007",
                    Company = companycompanyC035
                };
                vessels.Add(V03501);
                var V03502 = new Ship()
                {
                    Eni = "7001643",
                    Flag = "SWZ",
                    HotelStaff = 21,
                    Name = "SWISS CRYSTAL",
                    NauticalCrew = 6,
                    Region = "Rhine-Neckar",
                    Company = companycompanyC035
                };
                vessels.Add(V03502);
                var V03503 = new Ship()
                {
                    Eni = "7001646",
                    Flag = "SWZ",
                    HotelStaff = 25,
                    Name = "SWISS DIAMOND",
                    NauticalCrew = 6,
                    Region = "B/NL-Mosel-Rhine-M-D",
                    Company = companycompanyC035
                };
                vessels.Add(V03503);
                var V03504 = new Ship()
                {
                    Eni = "7001711",
                    Flag = "SWZ",
                    HotelStaff = 19,
                    Name = "SWISS CORAL",
                    NauticalCrew = 6,
                    Region = "Elbe-Havel-Oder",
                    Company = companycompanyC035
                };
                vessels.Add(V03504);
                var V03505 = new Ship()
                {
                    Eni = "7001725",
                    Flag = "SWZ",
                    HotelStaff = 25,
                    Name = "SWISS CROWN",
                    NauticalCrew = 6,
                    Region = "B/NL-Rhine-M-Danube",
                    Company = companycompanyC035
                };
                vessels.Add(V03505);
                var V03506 = new Ship()
                {
                    Eni = "7001736",
                    Flag = "SWZ",
                    HotelStaff = 19,
                    Name = "SAXONIA",
                    NauticalCrew = 6,
                    Region = "Elbe-Oder",
                    Company = companycompanyC035
                };
                vessels.Add(V03506);
                var V03507 = new Ship()
                {
                    Eni = "7001742",
                    Flag = "SWZ",
                    HotelStaff = 16,
                    Name = "SWISS RUBY",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Danube",
                    Company = companycompanyC035
                };
                vessels.Add(V03507);
                var V03508 = new Ship()
                {
                    Eni = "7001807",
                    Flag = "SWZ",
                    HotelStaff = 27,
                    Name = "SWISS CORONA",
                    NauticalCrew = 6,
                    Region = "Rhine-Mosel-M-Dan.",
                    Company = companycompanyC035
                };
                vessels.Add(V03508);
                var V03509 = new Ship()
                {
                    Eni = "7001814",
                    Flag = "SWZ",
                    HotelStaff = 27,
                    Name = "SWISS GLORIA",
                    NauticalCrew = 6,
                    Region = "NL, Rhine-M-Danube",
                    Company = companycompanyC035
                };
                vessels.Add(V03509);
                var V03510 = new Ship()
                {
                    Eni = "7001825",
                    Flag = "SWZ",
                    HotelStaff = 29,
                    Name = "SWISS EMERALD",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Danube",
                    Company = companycompanyC035
                };
                vessels.Add(V03510);
                var V03511 = new Ship()
                {
                    Eni = "7001832",
                    Flag = "SWZ",
                    HotelStaff = 29,
                    Name = "SWISS TIARA",
                    NauticalCrew = 6,
                    Region = "NL, Rhine-M-Danube",
                    Company = companycompanyC035
                };
                vessels.Add(V03511);
                var V03512 = new Ship()
                {
                    Eni = "7001841",
                    Flag = "SWZ",
                    HotelStaff = 36,
                    Name = "AURELIA",
                    NauticalCrew = 6,
                    Region = "Danube",
                    Company = companycompanyC035
                };
                vessels.Add(V03512);
                var V03513 = new Ship()
                {
                    Eni = "7001858",
                    Flag = "SWZ",
                    HotelStaff = 30,
                    Name = "SWISS SAPPHIRE",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Danube",
                    Company = companycompanyC035
                };
                vessels.Add(V03513);
                var V03514 = new Ship()
                {
                    Eni = "7001906",
                    Flag = "SWZ",
                    HotelStaff = 27,
                    Name = "SWISS JEWEL",
                    NauticalCrew = 6,
                    Region = "NL, Rhine-M-Danube",
                    Company = companycompanyC035
                };
                vessels.Add(V03514);
                var V03515 = new Ship()
                {
                    Eni = "7001923",
                    Flag = "SWZ",
                    HotelStaff = 29,
                    Name = "VISTA PRIMA",
                    NauticalCrew = 6,
                    Region = "NL, Rhine-M-Danube",
                    Company = companycompanyC035
                };
                vessels.Add(V03515);
                var V03516 = new Ship()
                {
                    Eni = "7001934",
                    Flag = "SWZ",
                    HotelStaff = 36,
                    Name = "ALINA",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Danube",
                    Company = companycompanyC035
                };
                vessels.Add(V03516);
                var V03517 = new Ship()
                {
                    Eni = "7001943",
                    Flag = "SWZ",
                    HotelStaff = 21,
                    Name = "TREASUES",
                    NauticalCrew = 6,
                    Region = "Rhine-Main -Danube",
                    Company = companycompanyC035
                };
                vessels.Add(V03517);
                var V03518 = new Ship()
                {
                    Eni = "",
                    Flag = "",
                    HotelStaff = 36,
                    Name = "AMELIA",
                    NauticalCrew = 6,
                    Region = "",
                    Company = companycompanyC035
                };
                vessels.Add(V03518);
                var companycompanyC036 = new Company() {Name = "Sea Cloud Cruises  GmbH, Hamburg"};
                companies.Add(companycompanyC036);
                var V03601 = new Ship()
                {
                    Eni = "2325887",
                    Flag = "NTH",
                    HotelStaff = 20,
                    Name = "RIGOLETTO",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Danube, NL, B",
                    Company = companycompanyC036
                };
                vessels.Add(V03601);
                var V03602 = new Ship()
                {
                    Eni = "4800450",
                    Flag = "MTA",
                    HotelStaff = 30,
                    Name = "RIVER CLOUD II",
                    NauticalCrew = 6,
                    Region = "Rhine-Main-lower Danube",
                    Company = companycompanyC036
                };
                vessels.Add(V03602);
                var companycompanyC037 = new Company() {Name = "SODENAF Recreatie"};
                companies.Add(companycompanyC037);
                var V03701 = new Ship()
                {
                    Eni = "2325776",
                    Flag = "FRA",
                    HotelStaff = 10,
                    Name = "ANACOLUTHE",
                    NauticalCrew = 4,
                    Region = "Seine",
                    Company = companycompanyC037
                };
                vessels.Add(V03701);
                var companycompanyC038 = new Company() {Name = "Trachsler Fritra"};
                companies.Add(companycompanyC038);
                var V03801 = new Ship()
                {
                    Eni = "",
                    Flag = "GFR",
                    HotelStaff = 19,
                    Name = "DER KLEINE PRINZ",
                    NauticalCrew = 6,
                    Region = "Danube",
                    Company = companycompanyC038
                };
                vessels.Add(V03801);
                var companycompanyC039 = new Company() {Name = "Trans River Line  BV, Amsterdam"};
                companies.Add(companycompanyC039);
                var V03901 = new Ship()
                {
                    Eni = "2325128",
                    Flag = "NTH",
                    HotelStaff = 19,
                    Name = "DIANA",
                    NauticalCrew = 6,
                    Region = "NL-Rhine-Mosel",
                    Company = companycompanyC039
                };
                vessels.Add(V03901);
                var V03902 = new Ship()
                {
                    Eni = "2207430",
                    Flag = "NTH",
                    HotelStaff = 9,
                    Name = "VIRGINIA",
                    NauticalCrew = 6,
                    Region = "Rhine-Mosel",
                    Company = companycompanyC039
                };
                vessels.Add(V03902);
                var V03903 = new Ship()
                {
                    Eni = "2326420",
                    Flag = "NTH",
                    HotelStaff = 12,
                    Name = "PRINSES CHRISTINA",
                    NauticalCrew = 6,
                    Region = "Rhine",
                    Company = companycompanyC039
                };
                vessels.Add(V03903);
                var V03904 = new Ship()
                {
                    Eni = "2315764",
                    Flag = "NTH",
                    HotelStaff = 14,
                    Name = "ESMERALDA",
                    NauticalCrew = 6,
                    Region = "Rhine-Mosel-M-Dan.",
                    Company = companycompanyC039
                };
                vessels.Add(V03904);
                var companycompanyC040 = new Company() {Name = "Varende Recreatie"};
                companies.Add(companycompanyC040);
                var V04001 = new Ship()
                {
                    Eni = "2325776",
                    Flag = "NTH",
                    HotelStaff = 5,
                    Name = "PRINCE WILLEM-ALEXANDER",
                    NauticalCrew = 2,
                    Region = "",
                    Company = companycompanyC040
                };
                vessels.Add(V04001);
                var companycompanyC041 = new Company() {Name = "Viking River  Cruises, Basel"};
                companies.Add(companycompanyC041);
                var V04101 = new Ship()
                {
                    Eni = "5113930",
                    Flag = "GFR",
                    HotelStaff = 24,
                    Name = "CLARA SCHUMANN",
                    NauticalCrew = 6,
                    Region = "Elbe",
                    Company = companycompanyC041
                };
                vessels.Add(V04101);
                var V04102 = new Ship()
                {
                    Eni = "5113670",
                    Flag = "GFR",
                    HotelStaff = 23,
                    Name = "THEODOR FONTANE",
                    NauticalCrew = 6,
                    Region = "Elbe",
                    Company = companycompanyC041
                };
                vessels.Add(V04102);
                var V04103 = new Ship()
                {
                    Eni = "9240010",
                    Flag = "MTA",
                    HotelStaff = 41,
                    Name = "PRIMADONNA",
                    NauticalCrew = 6,
                    Region = "Danube",
                    Company = companycompanyC041
                };
                vessels.Add(V04103);
                var V04104 = new Ship()
                {
                    Eni = "4802070",
                    Flag = "GFR",
                    HotelStaff = 34,
                    Name = "VIKING SKY",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Danube",
                    Company = companycompanyC041
                };
                vessels.Add(V04104);
                var V04105 = new Ship()
                {
                    Eni = "4608050",
                    Flag = "GFR",
                    HotelStaff = 34,
                    Name = "VIKING DANUBE",
                    NauticalCrew = 6,
                    Region = "Danube",
                    Company = companycompanyC041
                };
                vessels.Add(V04105);
                var V04106 = new Ship()
                {
                    Eni = "4800210",
                    Flag = "GFR",
                    HotelStaff = 36,
                    Name = "VIKING PRIDE",
                    NauticalCrew = 6,
                    Region = "NL-Rhine-M-Danube",
                    Company = companycompanyC041
                };
                vessels.Add(V04106);
                var V04107 = new Ship()
                {
                    Eni = "4800250",
                    Flag = "GFR",
                    HotelStaff = 36,
                    Name = "VIKING EUROPE",
                    NauticalCrew = 6,
                    Region = "NL-Rhine-M-Danube",
                    Company = companycompanyC041
                };
                vessels.Add(V04107);
                var V04108 = new Ship()
                {
                    Eni = "4800380",
                    Flag = "GFR",
                    HotelStaff = 36,
                    Name = "VIKING SPIRIT",
                    NauticalCrew = 6,
                    Region = "Seine",
                    Company = companycompanyC041
                };
                vessels.Add(V04108);
                var V04109 = new Ship()
                {
                    Eni = "4800510",
                    Flag = "GFR",
                    HotelStaff = 36,
                    Name = "VIKING NEPTUNE",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Danube",
                    Company = companycompanyC041
                };
                vessels.Add(V04109);
                var V04110 = new Ship()
                {
                    Eni = "4803570",
                    Flag = "GFR",
                    HotelStaff = 44,
                    Name = "VIKING SUN",
                    NauticalCrew = 6,
                    Region = "Rhine",
                    Company = companycompanyC041
                };
                vessels.Add(V04110);
                var V04111 = new Ship()
                {
                    Eni = "4804700",
                    Flag = "GFR",
                    HotelStaff = 38,
                    Name = "VIKING HELVETIA",
                    NauticalCrew = 6,
                    Region = "Rhine",
                    Company = companycompanyC041
                };
                vessels.Add(V04111);
                var V04112 = new Ship()
                {
                    Eni = "4804700",
                    Flag = "GFR",
                    HotelStaff = 44,
                    Name = "VIKING LEGEND",
                    NauticalCrew = 6,
                    Region = "Rhine-M-Danube",
                    Company = companycompanyC041
                };
                vessels.Add(V04112);
                var V04113 = new Ship()
                {
                    Eni = "7001942",
                    Flag = "SWZ",
                    HotelStaff = 43,
                    Name = "VIKING PRESTIGE",
                    NauticalCrew = 6,
                    Region = "Nuremberg-Danube",
                    Company = companycompanyC041
                };
                vessels.Add(V04113);
                var V04114 = new Ship()
                {
                    Eni = "",
                    Flag = "",
                    HotelStaff = 44,
                    Name = "VIKING NJORD",
                    NauticalCrew = 6,
                    Region = "",
                    Company = companycompanyC041
                };
                vessels.Add(V04114);
                var V04115 = new Ship()
                {
                    Eni = "",
                    Flag = "",
                    HotelStaff = 43,
                    Name = "VIKING IDUN",
                    NauticalCrew = 6,
                    Region = "",
                    Company = companycompanyC041
                };
                vessels.Add(V04115);
                var V04116 = new Ship()
                {
                    Eni = "",
                    Flag = "",
                    HotelStaff = 43,
                    Name = "VIKING FREYA",
                    NauticalCrew = 6,
                    Region = "",
                    Company = companycompanyC041
                };
                vessels.Add(V04116);
                var V04117 = new Ship()
                {
                    Eni = "",
                    Flag = "",
                    HotelStaff = 43,
                    Name = "VIKING EMBLA",
                    NauticalCrew = 6,
                    Region = "",
                    Company = companycompanyC041
                };
                vessels.Add(V04117);
                var V04118 = new Ship()
                {
                    Eni = "",
                    Flag = "",
                    HotelStaff = 43,
                    Name = "VIKING ODIN ",
                    NauticalCrew = 6,
                    Region = "",
                    Company = companycompanyC041
                };
                vessels.Add(V04118);
                var V04119 = new Ship()
                {
                    Eni = "",
                    Flag = "",
                    HotelStaff = 43,
                    Name = "VIKING AEGIR",
                    NauticalCrew = 6,
                    Region = "",
                    Company = companycompanyC041
                };
                vessels.Add(V04119);
                var companycompanyC042 = new Company() {Name = "De Zeeuw Reederei  Management, Basel"};
                companies.Add(companycompanyC042);
                var V04201 = new Ship()
                {
                    Eni = "7001270",
                    Flag = "SWZ",
                    HotelStaff = null,
                    Name = "PRINSES JULIANA",
                    NauticalCrew = null,
                    Region = "Rhine-Mosel",
                    Company = companycompanyC042
                };
                vessels.Add(V04201);
                var V04202 = new Ship()
                {
                    Eni = "7000661",
                    Flag = "SWZ",
                    HotelStaff = 22,
                    Name = "RHINE PRINCESS",
                    NauticalCrew = 6,
                    Region = "B/NL, Rhine-Mosel",
                    Company = companycompanyC042
                };
                vessels.Add(V04202);
                var V04203 = new Ship()
                {
                    Eni = "7001707",
                    Flag = "MTA",
                    HotelStaff = 29,
                    Name = "RHEIN PRINZESSEN",
                    NauticalCrew = 6,
                    Region = "B/NL, Rhine-Mosel",
                    Company = companycompanyC042
                };
                vessels.Add(V04203);
                var companycompanyC043 = new Company() {Name = "De Zonnebloem"};
                companies.Add(companycompanyC043);
                var V04301 = new Ship()
                {
                    Eni = "2327391",
                    Flag = "NTH",
                    HotelStaff = 9,
                    Name = "DE ZONNEBLOEM",
                    NauticalCrew = 6,
                    Region = "NL, Rhine",
                    Company = companycompanyC043
                };
                vessels.Add(V04301);

                context.Companies.AddRange(companies);
                context.Ships.AddRange(vessels);
                context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Debug.Write(
                        string.Format("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State));
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Debug.Write(string.Format("- Property: \"{0}\", Value: \"{1}\", Error: \"{2}\"",
                            ve.PropertyName,
                            eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName),
                            ve.ErrorMessage));
                    }
                }
                throw;
            }
            catch (Exception e)
            {
                Debug.Write(e.Message);
            }
        }

    }
}
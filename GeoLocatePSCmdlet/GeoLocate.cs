﻿using System.Runtime.InteropServices;
using System.Net;

namespace GeoLocate.Command
{

    public enum dbType { City, Country, ISP, Enterprise, Domain }

    // Simple object with properties to hold the results from a MaxMind query. 
    // The query results are placed in an object to work with in PowerShell.
    public class GeoLocation
    {
        // Default constructor
        public GeoLocation() { }

        // Constructor with named parameters, only ipAddress is requried
        public GeoLocation(IPAddress ipAddress, 
            [Optional] string countryCode, 
            [Optional] string countryName, 
            [Optional] string subdivisionCode, 
            [Optional] string subdivisionName, 
            [Optional] string city,
            [Optional] string domain,
            [Optional] string organization,
            [Optional] string postalCode, 
            [Optional] double? latitude, 
            [Optional] double? longitude)
        {
            IPAddress   = ipAddress;
            CountryCode = countryCode;
            CountryName = countryName;
            SubdivisionCode  = subdivisionCode;
            SubdivisionName  = subdivisionName;
            City        = city;
            Domain      = domain;
            Organization = organization;
            PostalCode  = postalCode;
            Latitude    = latitude;
            Longitude   = longitude;
        }

        // Properties
        public IPAddress IPAddress { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string SubdivisionCode { get; set; }
        public string SubdivisionName { get; set; }
        public string City { get; set; }
        public string Domain { get; set; }
        public string Organization { get; set; }
        public string PostalCode { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
    }
}

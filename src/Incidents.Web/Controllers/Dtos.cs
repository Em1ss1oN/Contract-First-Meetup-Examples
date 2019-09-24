using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Incidents.Web.Controllers
{
    public class IncidentListDto 
    {
        public long? Total { get; set; }
    
        public List<IncidentListItemDto> Items { get; set; }
    }
    
    public class IncidentListItemDto 
    {
        /// <summary>Incident unique identifier</summary>
        [Required]
        public Guid Id { get; set; }
    
        [JsonConverter(typeof(StringEnumConverter))]
        public IncidentTypeDto Type { get; set; }
    
        /// <summary>Modified date</summary>
        [Required]
        public DateTimeOffset Modified { get; set; }
    
        /// <summary>Created date</summary>
        [Required]
        public DateTimeOffset? Created { get; set; }
    
        /// <summary>Incident reporter name</summary>
        [Required]
        public string Reporter { get; set; }
    }
    
    /// <summary>Incident Type</summary>
    public enum IncidentTypeDto
    {
        None,
        Malware,
        Phishing,
        SocialEngineering,
        Ddos
    
    }
    
    public class IncidentDto 
    {
        /// <summary>Incident unique identifier</summary>
        public Guid Id { get; set; }
    
        [JsonConverter(typeof(StringEnumConverter))]
        public IncidentTypeDto Type { get; set; }
    
        /// <summary>Detected date</summary>
        public DateTimeOffset Detected { get; set; }
    
        /// <summary>Created date</summary>
        public DateTimeOffset Created { get; set; }
    
        /// <summary>Incident reporter name</summary>
        public string Reporter { get; set; }
    
        /// <summary>Incident description</summary>
        public string Description { get; set; }
    
        [JsonConverter(typeof(StringEnumConverter))]
        public IncidentTlp Tlp { get; set; }
    }
    
    public class IncidentModel 
    {
        [Required]
        [JsonConverter(typeof(StringEnumConverter))]
        public IncidentTypeDto Type { get; set; }
    
        /// <summary>Detected date</summary>
        [Required]
        public DateTimeOffset Detected { get; set; }
    
        /// <summary>Incident reporter name</summary>
        [Required]
        public string Reporter { get; set; }
    
        /// <summary>Incident description</summary>
        public string Description { get; set; }
    
        [Required]
        [JsonConverter(typeof(StringEnumConverter))]
        public IncidentTlp Tlp { get; set; }
    }
    
    /// <summary>Object Id</summary>
    public class ObjectId 
    {
        [Required]
        public Guid Id { get; set; }
    }
    
    /// <summary>Traffic Lights Protocol</summary>
    public enum IncidentTlp
    {
        Red,
        Yellow,
        Green,
        White
    }
}
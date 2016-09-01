//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using DENTALMIS.Model;
using DENTALMIS.Utility.HelperModel;

namespace DENTALMIS
{
    using System;
    using System.Collections.Generic;
    
    public partial class DisesesClinicalFeature:SearchModel<DisesesClinicalFeature>
    {
        public DisesesClinicalFeature()
        {
            this.DiseasesInvestigations = new HashSet<DiseasesInvestigation>();
            this.DiseasesManagements = new HashSet<DiseasesManagement>();
        }
    
        public int ClinicalFeatureId { get; set; }
         [Required]
        [DisplayName("Diseases Symptom")]
        public string Symptom { get; set; }
            [DisplayName("Diseases Sign")]
         [Required]
        public string Sign { get; set; }
        public bool IsActive { get; set; }
    
        public virtual ICollection<DiseasesInvestigation> DiseasesInvestigations { get; set; }
        public virtual ICollection<DiseasesManagement> DiseasesManagements { get; set; }
    }
}
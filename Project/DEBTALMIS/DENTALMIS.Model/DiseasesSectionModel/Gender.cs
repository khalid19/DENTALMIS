//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;
using DENTALMIS.Utility.HelperModel;

namespace DENTALMIS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Gender:SearchModel<Gender>
    {

        public Gender()
        {
            this.Patients = new HashSet<Patient>();
            this.Doctors = new HashSet<Doctor>();

            this.ClinicEmployees = new HashSet<ClinicEmployee>();
        }

        public int GenderId { get; set; }
        [Required]
        public string Title { get; set; }
        public bool IsActive { get; set; }


        public virtual ICollection<ClinicEmployee> ClinicEmployees { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}
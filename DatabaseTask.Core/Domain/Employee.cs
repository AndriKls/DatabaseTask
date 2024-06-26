﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }

        public int EmployeeNumber { get; set; }

        [Column(TypeName = "VARCHAR(255)")]
        [Required]
        public string? FirstName { get; set; }

        [Column(TypeName = "VARCHAR(255)")]
        [Required]
        public string? LastName { get; set; }

        public int PID { get; set; }

        [Column(TypeName = "VARCHAR(255)")]
        [Required]
        public string? Address { get; set; }

        [MaxLength(15)]
        public string? PhoneNumber { get; set; }

        [Column(TypeName = "VARCHAR(255)")]
        [Required]
        public string? Email { get; set; }

        public DateTime WorkingSince { get; set; }
        public DateTime? WorkingUntil { get; set; }

        [Column(TypeName = "VARCHAR(255)")]
        public string? Comment { get; set; }

        public virtual ICollection<AccessPermission> AccessPermissions { get; set; }

        public int JobTitleId { get; set; }
        [ForeignKey("JobTitleId")]
        public virtual JobTitle JobTitle { get; set; }

        public virtual ICollection<WorkingHistory> WorkingHistories { get; set; }
        public virtual ICollection<EmployeeChild> EmployeeChildren { get; set; }
        public virtual ICollection<SickLeave> SickLeaves { get; set; }
        public virtual ICollection<Holiday> Holidays { get; set; }
        public virtual ICollection<HealthInspection> HealthInspections { get; set; }
        public virtual ICollection<Renting> Rentings { get; set; }
        public virtual ICollection<Request> Requests { get; set; }

        public int BranchOfficeId { get; set; }
        [ForeignKey("BranchOfficeId")]
        public virtual BranchOffice BranchOffice { get; set; }
    }
}




/// TEINE HINDELINE HARJUTUS
///
/// 1. Teha Teie meeskonna poolt esitletud FirmaDB-st objektide struktuur.
/// 2. Kui see on valmis, siis teha code first migration. Vajadusel võib mitu migrationit teha.
/// 3. NB! Kasutate enda meeskonna poolt esitatud FirmaDB ERD-d, aga igaüks teeb individuaalselt.
/// 4. Järgida hea programmeerimise tava.
/// 5. Kogu solution laadida GitHubi ja link valmis tööst saata mulle.
/// 6. Järgmisena teha print screen MS SQL-s database diagrams all olevast auto-genereeritud ERD-st pilt. See lisada readMe.md failina sama projekti alla GitHubis.

/// Mõned muutujad võivad olla ka NULL väärtusega ja need tuleb ära märkida

/// kui peate tõmbama mingeid packagesi alla, siis kasutage eelistatult microsofti omasid ning latest stabel versiooni

/// <summary>
/// Kui kasutate enumit, siis peate olema kindel, et on tegemist valikutega, mis jäävad kogu rakenduse eluajaks samaks.
/// </summary>
//public Gender Gender { get; set; }

/// <summary>
/// 
/// Siin on info ja analüüs, et mis varianti kasutada
/// https://stackoverflow.com/questions/10113244/why-use-icollection-and-not-ienumerable-or-listt-on-many-many-one-many-relatio/10113331
/// https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable?redirectedfrom=MSDN&view=net-5.0
/// https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1?redirectedfrom=MSDN&view=net-5.0
/// https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?redirectedfrom=MSDN&view=net-5.0
/// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers#:~:text=Object%20initializers%20let%20you%20assign,by%20lines%20of%20assignment%20statements.
/// </summary>
/// Kas peaks objekti initsialiseerima või mitte
//public IEnumerable<Children> Childrens { get; set; } = new List<Children>();
//public ICollection<Children> Childrens { get; set; }
//public List<Children> Childrens { get; set; }



//public enum Gender
//{
//    Female, 
//    Male,
//    Unknown
//}

//public class Children
//{
//    [Key]
//    public Guid Id { get; set; }

//    public string FirstName { get; set; }
//


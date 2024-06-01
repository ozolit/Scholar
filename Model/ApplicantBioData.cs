using SQLite;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholar.Model
{
    public class ApplicantBioData
    {
        [PrimaryKey,AutoIncrement]
            public long Id { get; set; }
            public long PersonId { get; set; }
            public Person Person { get; set; }
            public long PersonTypeId { get; set; }
            //public PersonType PersonType { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string MiddleName { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public string DOB { get; set; }
            public string Disability { get; set; }
            public string Hobbies { get; set; }

            public string GenderId { get; set; }
            public Country Country { get; set; }
            public long CountryId { get; set; }

            //public State State { get; set; }
            public long StateId { get; set; }

            //public LGA LGA { get; set; }
            public long LGAId { get; set; }
            public string HomeTown { get; set; }

            //public Tribe Tribe { get; set; }
            public long TribeId { get; set; }

            public string ResidentialAddress { get; set; }
            public DateTime DateApplied { get; set; }




        }

    }



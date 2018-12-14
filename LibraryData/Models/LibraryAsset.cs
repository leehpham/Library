﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace LibraryData.Models
{
    public abstract class LibraryAsset
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; } // Just store as an int for BC

        [Required]
        public Status Status { get; set; }

        [Required]
        public decimal Cost { get; set; }

        public string ImageUrl { get; set; }

        public int NumberOfCopies { get; set; }

        // virtual: foreign key to LibraryBranch table
        public virtual LibraryBranch Location { get; set; }
    }
}

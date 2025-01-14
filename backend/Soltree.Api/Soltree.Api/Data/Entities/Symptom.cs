﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Soltree.Api.Data.Entities
{
    public class Symptom : BaseEntity
    {
        [Required]
        public string? Name { get; set; }

        [Required]
        public Guid? SymptomCategoryId { get; set; }

        public SymptomCategory? SymptomCategory { get; set; }
    }
}

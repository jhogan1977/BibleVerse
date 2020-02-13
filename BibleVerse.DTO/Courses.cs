﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BibleVerse.DTO
{
    public class Courses
    {
        [Key]
        public string CourseId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int Difficulty { get; set; }

        public int TtlRwdPoints { get; set; }

        public int TtlExpPoints { get; set; }

        public string Tags { get; set; }

        [Required]
        public string OrganizationId { get; set; }

        [Required]
        public string CreatorUsername { get; set; }

        public bool IsEnabled { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime ExprDateTime { get; set; }

        public DateTime ChangeDateTime { get; set; }

        public DateTime CreateDateTime { get; set; }
    }
}

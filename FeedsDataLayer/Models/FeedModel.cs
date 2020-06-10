﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FeedsDataLayer.Models
{
    public class FeedModel
    {
      public Guid Id { get; set; }
        [Required]
        [MaxLength(128 , ErrorMessage ="Нужно слегка убавить амбиции")]
      public string Title { get; set; } 
        [Required]
      public string Feed { get; set; } 
      public string Author { get; set; } 
    }
}

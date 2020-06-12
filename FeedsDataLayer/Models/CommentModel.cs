using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FeedsDataLayer.Models
{
    public class CommentModel
    { 
        [Key]
        public int CommentId { get; set; }
        public Guid GroupId { get; set; }
        public string CommentAvtorLogin { get; set; }
        public string Comment { get; set; }
        public DateTime Data { get; set; }
    }
}

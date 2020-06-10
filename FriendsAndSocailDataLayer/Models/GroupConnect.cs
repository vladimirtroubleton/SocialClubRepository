using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FriendsAndSocailDataLayer.Models
{
    public class GroupConnect
    {
        [Key]
        public int Id {get;set;}

        public int GroupId { get; set; }

        public string UserLogin { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FriendsAndSocailDataLayer.Models
{
    public class GroupModel
    {
        [Key]
        public int Id { get; set; }
        public string NameGroup { get; set; }
        public string CreatorLogin { get; set; }
        public int CountUsersInGroup { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FriendsAndSocailDataLayer.Models
{
    public class FriendsModel
    {
        [Key]
        public int Id { get; set; }
        public string CurrentUserLogin { get; set; }
        public string FriendUserLogin { get; set; }
    }
}

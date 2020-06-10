using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FilesManageDataLayer.Models
{
    public class FilesByFeeds
    {
        [Key]
        public int Id { get; set; }
        public Guid FeedId { get; set; }
        public int FileId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace rentcarWebGofar.DBModel.Entity
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public int FromCommentUserID { get; set; }
        public int ToCommentUserID { get; set; }
        public DateTime CommentDate { get; set; }
        public string CommentString { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Whoaverse.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comment
    {
        public Comment()
        {
            this.Likes = 1;
            this.Dislikes = 0;
            this.Commentvotingtrackers = new HashSet<Commentvotingtracker>();
        }
    
        public int Id { get; set; }
        public Nullable<int> Votes { get; set; }
        public string Name { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<int> MessageId { get; set; }
        public string CommentContent { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
    
        public virtual Message Message { get; set; }
        public virtual ICollection<Commentvotingtracker> Commentvotingtrackers { get; set; }
    }
}

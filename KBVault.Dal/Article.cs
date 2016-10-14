//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KBVault.Dal
{
    using System;
    using System.Collections.Generic;
    
    public partial class Article
    {
        public Article()
        {
            this.ArticleTags = new HashSet<ArticleTag>();
            this.Attachments = new HashSet<Attachment>();
        }
    
        public long Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Views { get; set; }
        public int Likes { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public Nullable<System.DateTime> Edited { get; set; }
        public int IsDraft { get; set; }
        public Nullable<System.DateTime> PublishStartDate { get; set; }
        public Nullable<System.DateTime> PublishEndDate { get; set; }
        public long Author { get; set; }
        public int CategoryId { get; set; }
        public string SefName { get; set; }
    
        public virtual KbUser KbUser { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<ArticleTag> ArticleTags { get; set; }
        public virtual ICollection<Attachment> Attachments { get; set; }
    }
}
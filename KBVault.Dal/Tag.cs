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
    
    public partial class Tag
    {
        public Tag()
        {
            this.ArticleTags = new HashSet<ArticleTag>();
        }
    
        public long Id { get; set; }
        public string Name { get; set; }
        public long Author { get; set; }
    
        public virtual ICollection<ArticleTag> ArticleTags { get; set; }
        public virtual KbUser KbUser { get; set; }
    }
}
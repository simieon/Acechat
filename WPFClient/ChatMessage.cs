//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPFClient
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChatMessage
    {
        public int Id { get; set; }
        public int AvatarId { get; set; }
        public Nullable<int> SenderId { get; set; }
        public string Content { get; set; }
    
        public virtual ChatUser ChatUser { get; set; }
    }
}

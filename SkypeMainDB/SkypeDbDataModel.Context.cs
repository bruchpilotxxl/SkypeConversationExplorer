﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SCE.BusinessObjects.SkypeMainDB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class mainDbEntities : DbContext
    {
        public mainDbEntities()
            : base("name=mainDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Accounts> Accounts { get; set; }
        public virtual DbSet<Alerts> Alerts { get; set; }
        public virtual DbSet<CallMembers> CallMembers { get; set; }
        public virtual DbSet<Calls> Calls { get; set; }
        public virtual DbSet<ChatMembers> ChatMembers { get; set; }
        public virtual DbSet<Chats> Chats { get; set; }
        public virtual DbSet<ContactGroups> ContactGroups { get; set; }
        public virtual DbSet<Contacts> Contacts { get; set; }
        public virtual DbSet<Conversations> Conversations { get; set; }
        public virtual DbSet<DbMeta> DbMeta { get; set; }
        public virtual DbSet<LegacyMessages> LegacyMessages { get; set; }
        public virtual DbSet<Messages> Messages { get; set; }
        public virtual DbSet<Participants> Participants { get; set; }
        public virtual DbSet<SMSes> SMSes { get; set; }
        public virtual DbSet<Transfers> Transfers { get; set; }
        public virtual DbSet<VideoMessages> VideoMessages { get; set; }
        public virtual DbSet<Videos> Videos { get; set; }
        public virtual DbSet<Voicemails> Voicemails { get; set; }
    }
}

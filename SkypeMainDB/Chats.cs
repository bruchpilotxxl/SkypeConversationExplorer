//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Chats
    {
        public long id { get; set; }
        public Nullable<long> is_permanent { get; set; }
        public string name { get; set; }
        public Nullable<long> options { get; set; }
        public string friendlyname { get; set; }
        public string description { get; set; }
        public Nullable<long> timestamp { get; set; }
        public Nullable<long> activity_timestamp { get; set; }
        public string dialog_partner { get; set; }
        public string adder { get; set; }
        public Nullable<long> type { get; set; }
        public Nullable<long> mystatus { get; set; }
        public Nullable<long> myrole { get; set; }
        public string posters { get; set; }
        public string participants { get; set; }
        public string applicants { get; set; }
        public string banned_users { get; set; }
        public string name_text { get; set; }
        public string topic { get; set; }
        public string topic_xml { get; set; }
        public string guidelines { get; set; }
        public byte[] picture { get; set; }
        public string alertstring { get; set; }
        public Nullable<long> is_bookmarked { get; set; }
        public string passwordhint { get; set; }
        public Nullable<long> unconsumed_suppressed_msg { get; set; }
        public Nullable<long> unconsumed_normal_msg { get; set; }
        public Nullable<long> unconsumed_elevated_msg { get; set; }
        public Nullable<long> unconsumed_msg_voice { get; set; }
        public string activemembers { get; set; }
        public byte[] state_data { get; set; }
        public Nullable<long> lifesigns { get; set; }
        public Nullable<long> last_change { get; set; }
        public Nullable<long> first_unread_message { get; set; }
        public Nullable<long> pk_type { get; set; }
        public string dbpath { get; set; }
        public string split_friendlyname { get; set; }
        public Nullable<long> conv_dbid { get; set; }
    }
}

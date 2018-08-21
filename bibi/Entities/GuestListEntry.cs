using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace bibi.Entities
{
    class GuestListEntry
    {
        [XmlAttribute("id")] public int GuestID;
        [XmlAttribute("invited")] public DateTime Invited;
        [XmlElement("status")] public RSVPStatus Status;
        [XmlElement("changed")] public DateTime? StatusChanged;

        public GuestListEntry(int GuestID, RSVPStatus Status)
        {
            this.GuestID = GuestID;
            this.Status = Status;
            Invited = DateTime.Now;
        }

        public bool ChangeStatus(RSVPStatus NewStatus)
        {
            if (!Status.Equals(NewStatus))
            {
                Status = NewStatus;
                StatusChanged = DateTime.Now;
                return true;
            } else
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace bibi.Entities
{
    class GuestListEntry
    {
        public int GuestID;
        public DateTime Invited;
        public RSVPStatus Status;
        public DateTime? StatusChanged;
    }
}

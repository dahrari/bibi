using bibi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bibi
{
    class EventCollection
    {
        public List<Event> Content;

        public Event GetEventByID(int ID)
        {
            Event result = null;

            foreach (Event ev in Content)
            {
                if (ev.Info.ID.Equals(ID)) {
                    return result;
                }
            }

            return result;
        }

        public Event[] GetEventsByOwner(int ownerID)
        {
            List<Event> result = new List<Event>();

            foreach (Event ev in Content)
            {
                if (ev.Info.Owners.Contains(ownerID))
                {
                    result.Add(ev);
                }
            }

            if (result.Count > 0)
            {
                return result.ToArray();
            } else
            {
                return null;
            }
        }
    }
}

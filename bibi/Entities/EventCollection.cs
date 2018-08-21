using bibi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace bibi
{
    class EventCollection
    {
        [XmlArray("events"), XmlArrayItem("event")] public List<Event> Content;

        /// <summary>
        /// Create a new instance of EventCollection.
        /// </summary>
        public EventCollection()
        {
            Content = new List<Event>();
        }

        /// <summary>
        /// Searches for an event corresponding to the ID value inside this EventCollection. Returns one if there is one, and null if there is none.
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
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

        public Event[] GetEventsByRSVPStatus(int personID, RSVPStatus status)
        {
            List<Event> result = new List<Event>();

            foreach (Event ev in Content)
            {
                
            }

            if (result.Count > 0)
            {
                return result.ToArray();
            } else {
                return null;
            }
        }

        public Event[] GetEventsByInvitee(int personID)
        {

        }
    }
}

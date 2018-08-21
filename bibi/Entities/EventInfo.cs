using System;
using System.Collections.Generic;
using System.Text;

using System.Xml.Serialization;

namespace bibi.Entities
{
    class EventInfo
    {
        /// <summary>
        /// The ID of this event.
        /// </summary>
        [XmlAttribute("id")] public int ID;

        /// <summary>
        /// A short & meaningful title of an event.
        /// </summary>
        [XmlAttribute("title")] public string Title;

        /// <summary>
        /// The information or "about" content of an event. Can be plain text or HTML.
        /// </summary>
        [XmlElement("info")] public string Information;

        /// <summary>
        /// An array of ID numbers that point to the owners of this event.
        /// </summary>
        [XmlElement("owners")] public List<int> Owners;

        /// <summary>
        /// Can the people who can view this event also view it's owners. True if yes, false if no.
        /// </summary>
        [XmlAttribute("showowners")] public bool ShowOwners;

        
    }
}

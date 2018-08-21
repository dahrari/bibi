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
        [XmlAttribute("id")] private int iD;

        /// <summary>
        /// A short & meaningful title of an event.
        /// </summary>
        [XmlAttribute("title")] private string title;

        /// <summary>
        /// The information or "about" content of an event. Can be plain text or HTML.
        /// </summary>
        [XmlElement("info")] private string information;

        /// <summary>
        /// An array of ID numbers that point to the owners of this event.
        /// </summary>
        [XmlElement("owners")] private List<int> owners;

        [XmlAttribute("starttime")] private DateTime startTime;

        [XmlAttribute("endtime")] private DateTime endTime;

        public int ID { get => iD; set => iD = value; }
        public string Title { get => title; set => title = value.Replace("<![CDATA[","").Replace("]]>",""); }
        public string Information { get => information; set => information = value.Replace("<![CDATA[", "").Replace("]]>", ""); }
        public List<int> Owners { get => owners; set => owners = value; }
        public DateTime StartTime { get => startTime; set => startTime = value; }
        public DateTime EndTime { get => endTime; set => endTime = value; }
    }
}

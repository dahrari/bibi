using System;
using System.Collections.Generic;
using System.Text;

namespace bibi.Entities
{
    /// <summary>
    /// An interface for a party, ie. user, person, organization, group of people etc.
    /// </summary>
    interface IParty
    {
        int ID { get; }
        string Name { get; }
        string Information { get; }
    }
}

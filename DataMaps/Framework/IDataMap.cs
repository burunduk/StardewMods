using System.Collections.Generic;
using Microsoft.Xna.Framework;
using StardewValley;

namespace Pathoschild.Stardew.DataMaps.Framework
{
    /// <summary>Provides metadata to display in the overlay.</summary>
    internal interface IDataMap
    {
        /// <summary>Get the legend entries to display.</summary>
        IEnumerable<LegendEntry> GetLegendEntries();

        /// <summary>Get the updated data map tiles.</summary>
        /// <param name="location">The current location.</param>
        /// <param name="visibleTiles">The tiles currently visible on the screen.</param>
        IEnumerable<TileData> Update(GameLocation location, IEnumerable<Vector2> visibleTiles);
    }
}

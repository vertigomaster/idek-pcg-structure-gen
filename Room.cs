using System;
using IDEK.PCG.Core;
using IDEK.PCG.StructureGen.Core.Enums;

namespace IDEK.PCG.StructureGen.Core
{
    public class Room : IProceduralElement
    {
        public string Name { get; set; } = "Room";
        public int DesiredFloor { get; set; } = 0;
        public float EstimatedSize { get; set; } = 0f;
        public float MinSize { get; set; } = 0f;
        public PlacementPriority Priority { get; set; }
        
        /// <summary>
        /// Multiplier for how much weight this room can support, relative to its size.
        /// A default value of 1 holds the same amount of square footage.
        /// A value of 0 holds no weight, 0.5 holds half the weight.
        /// </summary>
        /// <remarks>
        /// When calculating the supported area of the floor below, a room's area is multiplied by this factor (unless explicitly overriden) 
        /// </remarks>
        public float WeightSupportFactor { get; set; } = 1f;
        
        public float EstimatedSupportedArea => WeightSupportFactor * EstimatedSize;
        
        /// <summary>
        /// Used more during room placement phase, but indicates
        /// whether windows are a must-have for this room.
        /// </summary>
        public WindowFlag WindowFlags { get; set; } = WindowFlag.Any;
        
        /// <summary>
        /// What general zones can this room be placed in (ground floor only? basement? above ground?
        /// </summary>
        [Obsolete("Will replace with number-enum pairs for \"less than n\", \"greater than n\", etc, and allow set building.")]
        public PlacementSection ValidPlacement { get; set; } = PlacementSection.Any;
    }
}
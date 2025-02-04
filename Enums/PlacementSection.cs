using System;

namespace IDEK.PCG.StructureGen.Core.Enums
{
    [Flags]
    public enum PlacementSection
    {
        None = 0,
        BelowGround = 1 << 0,
        OnGroundFloor = 1 << 1,
        UpperFloor = 1 << 2,
        Any = int.MaxValue 
    }
}
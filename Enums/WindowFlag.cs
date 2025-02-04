namespace IDEK.PCG.StructureGen.Core.Enums
{
    public enum WindowFlag
    {
        /// <summary>
        /// Any configuration is allowed; no window constraints.
        /// </summary>
        Any = 0,
        
        /// <summary>
        /// This room is explicitly flagged to not allow windows
        /// </summary>
        NoneAllowed = -1,
        
        /// <summary>
        /// This room is explicitly flagged to require windows
        /// </summary>
        MustHave = 1,
    }
}
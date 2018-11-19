namespace Mi9.Store.Entities.Entities
{
    public class ItemKeyWordEntity
    {
        public string UserLookup { get; set; }

        public short DeparmentId { get; set; }

        public virtual DepartmentEntity Deparment { get; set; }
    }
}

namespace ZakLyd.Domaine.Entities
{
    public class Properties
    {
        public long PropertiesId { get; set; }
        public long RealatedId { get; set; }
        public PropertyGroup PropertyGroup { get; set; }
        public string PropertyKey { get; set; }
        public string PropertyValue { get; set; }
    }
}
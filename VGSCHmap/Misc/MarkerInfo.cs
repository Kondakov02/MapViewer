namespace MapViewer.Misc
{
    using GMap.NET;
    using System.Text.Json.Serialization;

    public class MarkerInfo
    {
        public string Name { get; }
        public string Description { get; }
        public PointLatLng Position { get; }

        public MarkerInfo()
        {
        }

        [JsonConstructor]
        public MarkerInfo(string name, string description, PointLatLng position)
        {
            Name = name ?? "Безымянный маркер";
            Description = description ?? "";
            Position = position;
        }
    }
}

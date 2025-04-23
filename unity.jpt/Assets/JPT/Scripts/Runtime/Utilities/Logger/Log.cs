namespace Eredfall.JPT.Runtime.Utilities
{
    public static class Log
    {
        public static readonly TagLog Default = new(string.Empty);
        public static readonly TagLog Loading = new("Loading");
        public static readonly TagLog Boot = new("Bootstrap");
        public static readonly TagLog Meta = new("Menu");
        public static readonly TagLog Battle = new("Game");

        public static readonly BuilderLogPool Builder = new(new TagLog(string.Empty), 5);
    }
}
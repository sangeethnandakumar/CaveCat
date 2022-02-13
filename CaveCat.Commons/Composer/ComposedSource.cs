namespace CaveCat.Commons.Composer
{
    public class ComposedSource
    {
        public string ProgramName { get; set; }
        public string ProgramVersion { get; set; }
        public string IDE { get; set; }
        public List<Composition> Compositions { get; set; }
    }
}

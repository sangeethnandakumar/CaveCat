using CaveCat.Commons.Composer;

namespace CaveCat.Composer
{
    public interface IComposer
    {
        ComposedSource Compose(string main);
    }
}

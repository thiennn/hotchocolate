namespace HotChocolate.Types
{
    public interface IInterfaceTypeNameDependencyDescriptor
    {
        IInterfaceTypeDescriptor DependsOn<TDependency>()
            where TDependency : IType;
    }
}

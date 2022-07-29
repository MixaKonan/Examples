namespace Unit.Testing;

public class SomeTestableService
{
    private readonly ISomeDependency _someDependency;
    private readonly ISomeOtherDependency someOtherDependency;

    public SomeTestableService(ISomeDependency someDependency, ISomeOtherDependency someOtherDependency)
    {
        this._someDependency = someDependency;
        this.someOtherDependency = someOtherDependency;
    }

    public string SomeOtherDependencyMethodToTest()
    {
        var totallyRandomString = "420 69";
        
        return someOtherDependency.SomeOtherMethod(totallyRandomString);
    }

    public int SomeMethodToTest()
    {
        return _someDependency.SomeMethod();
    }
        
    public bool SomeOtherMethodToTest()
    {
        return _someDependency.GetTrue();
    }
        
        
        
        
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
        

}
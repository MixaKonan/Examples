using Moq;

namespace Unit.Testing;

[TestClass]
public class ProposedApproachUnitTest
{
    private readonly Mock<ISomeDependency> someDependencyMock;
    private readonly Mock<ISomeOtherDependency> someOtherDependencyMock;
    
    public ProposedApproachUnitTest()
    {
        this.someDependencyMock = new Mock<ISomeDependency>();
        this.someOtherDependencyMock = new Mock<ISomeOtherDependency>();
    }

    [TestMethod]
    public void SomeOtherDependencyMethodToTest_Should_ReturnTotallyRandomString()
    {
        //Arrange
        const string expected = "420 69";
    
        this.someOtherDependencyMock.Setup(someOtherDependency => someOtherDependency.SomeOtherMethod(expected))
            .Returns<string>((someArgument) => someArgument);
    
        var instance = this.GetInstance();
    
        //Act
        var actual = instance.SomeOtherDependencyMethodToTest();
        
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void SomeMethodToTest_Should_ReturnZero()
    {
        //Arrange
        const int expected = 0;

        this.someDependencyMock.Setup(someDependency => someDependency.SomeMethod())
            .Returns(expected);

        var instance = this.GetInstance();

        //Act
        var actual = instance.SomeMethodToTest();

        //Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void SomeOtherMethodToTest_Should_ReturnTrue()
    {
        //Arrange
        const bool expected = true;

        this.someDependencyMock.Setup(someDependency => someDependency.GetTrue())
            .Returns(expected);

        var instance = this.GetInstance();

        //Act
        var actual = instance.SomeOtherMethodToTest();

        //Assert
        Assert.AreEqual(expected, actual);
    }

    private SomeTestableService GetInstance()
    {
        return new SomeTestableService(
            someDependencyMock.Object,
            someOtherDependencyMock.Object);
    }

    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    


}
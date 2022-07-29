using Moq;

namespace Unit.Testing;

[TestClass]
public class UsedApproachUnitTest
{
    [TestMethod]
    public void SomeMethodToTest_Should_ReturnZero()
    {
        //Arrange
        const int expected = 0;

        var someDependencyMock = new Mock<ISomeDependency>();
        var someOtherDependency = new Mock<ISomeOtherDependency>();

        someDependencyMock.Setup(someDependency => someDependency.SomeMethod())
                          .Returns(expected);

        var instance = new SomeTestableService(someDependencyMock.Object, someOtherDependency.Object);

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

        var someDependencyMock = new Mock<ISomeDependency>();
        var someOtherDependency = new Mock<ISomeOtherDependency>();

        someDependencyMock.Setup(someDependency => someDependency.GetTrue())
                          .Returns(expected);

        var instance = new SomeTestableService(someDependencyMock.Object, someOtherDependency.Object);

        //Act
        var actual = instance.SomeOtherMethodToTest();

        //Assert
        Assert.AreEqual(expected, actual);
    }

    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    

    // [TestMethod]
    // public void SomeOtherDependencyMethodToTest_Should_ReturnTotallyRandomString()
    // {
    //     //Arrange
    //     const string expected = "420 69";
    //
    //     var someDependencyMock = new Mock<ISomeDependency>();
    //     var someOtherDependencyMock = new Mock<ISomeOtherDependency>();
    //     
    //     someOtherDependencyMock.Setup(someOtherDependency => someOtherDependency.SomeOtherMethod(expected))
    //         .Returns<string>((someArgument) => someArgument);
    //
    //     var instance = new SomeTestableClass(someDependencyMock, someOtherDependencyMock);
    //
    //     //Act
    //     var actual = instance.SomeOtherDependencyMethodToTest();
    //     
    //     Assert.AreEqual(expected, actual);
    // }
}

using MyCompany.Intranet.Core.Entities;
using MyCompany.Intranet.Core.Enums;
using MyCompany.Intranet.Core.Services;

namespace MyCompany.Intranet.Tests;

public class BmiServiceShould
{
    [Fact]
    public void ProcessBmi_WhenIndexLessThan18_5_ReturnsTypeLow()
    {
        //arrange
        var expectedType = BmiType.Low;
        var person = new Person { Height = 1.70f, Weight = 50f };
        var sut = new BmiService();

        //act 
        var result = sut.ProcessBmi(person);
        
        //assert
        Assert.Equal(expectedType,result.BmiType);
        
    }

    [Fact]
    public void ProcessBmi_WhenIndexThan_18_5AndLessThan24_5_ReturnsTypeNormal()
    {
        // arrange 
        var expectedType = BmiType.Normal;
        var person = new Person { Height = 1.70f, Weight = 70f };
        var sut = new BmiService();
        
        // act 
        var result = sut.ProcessBmi(person);
        
        //Assert 
        Assert.Equal(expectedType,result.BmiType);
    }
    
    
    
    

}
using DeLaSalle.TaxCalculator.App.Taxes;
using DeLaSalle.TaxCalculator.Core.Entities;

namespace DeLaSalle.TaxCalculator.Tests;

public class IsrShould
{
    [Fact]
    public void Isr_WhenSetSalaryAmount7000_Returns_134_399808()
    {
        // Arrange
        double expectedType = 134.399808;
        var salary = new Salary{Amount = 7000};
        var sut = new ISRCalculatorService();

        // Act
        var result = sut.GetISR(salary);
        
        // Asert
        Assert.Equal(expectedType, result);
    }
    
    [Fact]
    public void Isr_WhenSetSalaryAmount36500_Returns_1989_46936()
    {
        // Arrange
        double expectedType = 1989.46936;
        var salary = new Salary{Amount = 36500};
        var sut = new ISRCalculatorService();

        // Act
        var result = sut.GetISR(salary);
        
        // Asert
        Assert.Equal(expectedType, result);
    }
    
    [Fact]
    public void Isr_WhenSetSalaryAmount110000_Returns_8680_302496()
    {
        // Arrange
        double expectedType = 8680.302496;
        var salary = new Salary{Amount = 110000};
        var sut = new ISRCalculatorService();

        // Act
        var result = sut.GetISR(salary);
        
        // Asert
        Assert.Equal(expectedType, result);
    }
    
    [Fact]
    public void Isr_WhenSetSalaryAmount128300_Returns_11333_0544()
    {
        // Arrange
        double expectedType = 11333.0544;
        var salary = new Salary{Amount = 128300};
        var sut = new ISRCalculatorService();

        // Act
        var result = sut.GetISR(salary);
        
        // Asert
        Assert.Equal(expectedType, result);
    }
    
    [Fact]
    public void Isr_WhenSetSalaryAmount156800_Returns_16328_519936()
    {
        // Arrange
        double expectedType = 16328.519936;
        var salary = new Salary{Amount = 156800};
        var sut = new ISRCalculatorService();

        // Act
        var result = sut.GetISR(salary);
        
        // Asert
        Assert.Equal(expectedType, result);
    }
    
    [Fact]
    public void Isr_WhenSetSalaryAmount223840_Returns_30518_305824()
    {
        // Arrange
        double expectedType = 30518.305824;
        var salary = new Salary{Amount = 223840 };
        var sut = new ISRCalculatorService();

        // Act
        var result = sut.GetISR(salary);
        
        // Asert
        Assert.Equal(expectedType, result);
    }
    
    [Fact]
    public void Isr_WhenSetSalaryAmount431000_Returns_77081_865248()
    {
        // Arrange
        double expectedType = 77081.865248;
        var salary = new Salary{Amount = 431000 };
        var sut = new ISRCalculatorService();

        // Act
        var result = sut.GetISR(salary);
        
        // Asert
        Assert.Equal(expectedType, result);
    }
    
    [Fact]
    public void Isr_WhenSetSalaryAmount866700_Returns_202643_437()
    {
        // Arrange
        double expectedType = 202643.437;
        var salary = new Salary{Amount = 866700 };
        var sut = new ISRCalculatorService();

        // Act
        var result = sut.GetISR(salary);
        
        // Asert
        Assert.Equal(expectedType, result);
    }
    
    [Fact]
    public void Isr_WhenSetSalaryAmount1120500_Returns_281702_7372()
    {
        // Arrange
        double expectedType = 281702.7372;
        var salary = new Salary{Amount = 1120500 };
        var sut = new ISRCalculatorService();

        // Act
        var result = sut.GetISR(salary);
        
        // Asert
        Assert.Equal(expectedType, result);
    }
    
    [Fact]
    public void Isr_WhenSetSalaryAmount2399523_Returns_712992_943()
    {
        // Arrange
        double expectedType = 712992.943;
        var salary = new Salary{Amount = 2399523 };
        var sut = new ISRCalculatorService();

        // Act
        var result = sut.GetISR(salary);
        
        // Asert
        Assert.Equal(expectedType, result);
    }
    
    [Fact]
    public void Isr_WhenSetSalaryAmount7350966_Returns_2431011_8145()
    {
        // Arrange
        double expectedType = 2431011.8145;
        var salary = new Salary{Amount = 7350966 };
        var sut = new ISRCalculatorService();

        // Act
        var result = sut.GetISR(salary);
        
        // Asert
        Assert.Equal(expectedType, result);
    }
}
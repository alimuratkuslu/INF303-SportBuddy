using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace UnitTests;

public class UnitTest1 : IClassFixture<ICustomerDal>
{

    private readonly ICustomerDal customerDal;
    private readonly ILocationDal locationDal;

    public UnitTest1(ICustomerDal customerDal, ILocationDal locationDal)
    {
        this.customerDal = customerDal;
        this.locationDal = locationDal;
    }

    [Fact]
    public void Should_Return_Customer_Name()
    {

        // First name of the customer with id 1
        var expected = "Ali Murat";

        var customer = customerDal.GetCustomerById(1);
        var result = customer.name;

        Assert.Equal(expected, result);

    }

    [Fact]
    public void Should_Return_Customer_Email()
    {

        // Email of the customer with id 1
        var expected = "ali@gmail.com";

        var customer = customerDal.GetCustomerById(1);
        var result = customer.email;

        Assert.Equal(expected, result);

    }

    [Fact]
    public void Should_Return_Location_City()
    {

        // City of the location with id 1
        var expected = "Istanbul";

        var location = locationDal.GetLocationById(1);
        var result = location.city;

        Assert.Equal(expected, result);

    }

    [Fact]
    public void Should_Return_Location_Rating()
    {

        // Rating of the location with id 1
        var expected = 7;

        var location = locationDal.GetLocationById(1);
        var result = location.rating;

        Assert.Equal(expected, result);

    }
}

using DemoWeb.Models;
using Shouldly;

namespace TestWebModels
{
    public class TestPerson
    {
        [Theory]
        [InlineData(1, "John Doe")]
        [InlineData(2, "Jane Doe")]

        public void Test1(int id, string name)
        {
            Person p = new Person();
            p.Id = id;
            p.Name = name;

            p.Id.ShouldBe(id);
            p.Name.ShouldBe(name);
        }
    }
}
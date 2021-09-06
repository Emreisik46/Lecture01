using System;
using Xunit;
using System.IO;




namespace lec01.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void year_input_is_divisible_by_four()
        {
            Program program = new Program();
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            var input = new StringReader("1600");
            Console.SetIn(input);

            // Act
            Program.Main(new string[0]);

            // Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("Yay!", output);

        }

        [Fact]
        public void year_1700_is_leapyear()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            var input = new StringReader("1700");
            Console.SetIn(input);

            // Act
            Program.Main(new string[0]);

            // Assert
            var ouput = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("Nay!", ouput);

        }

        [Fact]
        public void prints_intput_less_than_1582()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            var input = new StringReader("1400");
            Console.SetIn(input);

            // Act
            Program.Main(new string[0]);

            // Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("The year must be greater than 1582", output);


        }


    
    }
}

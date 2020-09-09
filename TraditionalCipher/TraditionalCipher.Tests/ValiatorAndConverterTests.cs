using FluentAssertions;
using System;
using TraditionalCipher.Library;
using Xunit;

namespace TraditionalCipher.Tests
{
    public class ValiatorAndConverterTests
    {
        private ValiatorAndConverter valiatorAndConverter;

        public ValiatorAndConverterTests()
        {
            this.valiatorAndConverter = new ValiatorAndConverter();
        }

        //[Fact]
        //public void InvalidCharacterInInputText_ArgumentExceptionIsThrown()
        //{
        //    // Arrange
        //    var text = "Ad @ 73";

        //    // Act
        //    Action act = () => this.valiatorAndConverter.ValidateAndConvertToAllUpper(text);

        //    // Assert
        //    act.Should().Throw<ArgumentException>().WithMessage("Input text contains unwanted character.");
        //}

        //[Theory]
        //[InlineData("")]
        //[InlineData(null)]
        //public void EmptyAndNullInputText_ArgumentNullExceptionIsThrown(string inputText)
        //{
        //    // Act
        //    Action act = () => this.valiatorAndConverter.ValidateAndConvertToAllUpper(inputText);

        //    // Assert
        //    act.Should().Throw<ArgumentNullException>();
        //}
    }
}

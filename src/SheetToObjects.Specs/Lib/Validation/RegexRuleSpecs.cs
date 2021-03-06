﻿using FluentAssertions;
using SheetToObjects.Lib.Validation;
using Xunit;

namespace SheetToObjects.Specs.Lib.Validation
{
    public class RegexRuleSpecs
    {
        [Fact]
        public void GivenValidatingRegex_WhenValueIsInvalid_ValidationFails()
        {
            var value = "invalidemail@";
            var pattern =
                @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";

            var result = new RegexRule(pattern).Validate(value);

            result.IsSuccess.Should().BeFalse();
            result.Error.Should().Be($"Value '{value}' does not match pattern '{pattern}'");
        }

        [Fact]
        public void GivenValidatingRegex_WhenValueIsValid_ValidationIsSuccesful()
        {
            var value = "valid@email.com";
            var pattern =
                @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";

            var result = new RegexRule(pattern).Validate(value);

            result.IsSuccess.Should().BeTrue();
        }

        [Fact]
        public void GivenValidatingRegex_WhenValueAndPatterIsNull_ValidationFails()
        {
            string value = null;
            string pattern = null;

            var result = new RegexRule(pattern).Validate(value);

            result.IsSuccess.Should().BeFalse();
        }

        [Fact]
        public void GivenValidatingRegex_WhenPatternIsNull_ValidationFails()
        {
            var value = "SomeValue";
            string pattern = null;

            var result = new RegexRule(pattern).Validate(value);

            result.IsSuccess.Should().BeFalse();
        }
    }
}
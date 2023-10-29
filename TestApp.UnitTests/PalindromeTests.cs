using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;



    public class PalindromeTests
    {

        [Test]
        public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
        {
            // Arrange
            List<string> input = new() { "aha", "wow" };
            // List<string> expected = new() { "olleH" };

            // Act
            bool actual = Palindrome.IsPalindrome(input);

            // Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void Test_IsPalindrome_EmptyList_ReturnsTrue()
        {
            // Arrange
            List<string> words = new();

            // Act
            bool actual = Palindrome.IsPalindrome(words);

            // Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void Test_IsPalindrome_SingleWord_ReturnsTrue()
        {
            // Arrange
            List<string> input = new() { "aha" };
            // List<string> expected = new() { "olleH" };

            // Act
            bool actual = Palindrome.IsPalindrome(input);

            // Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
        {
            // Arrange
            List<string> input = new() { "Hello", "aha" };


            // Act
            bool actual = Palindrome.IsPalindrome(input);

            // Assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
        {
            // Arrange
            List<string> input = new() { "Wow", "aha" };


            // Act
            bool actual = Palindrome.IsPalindrome(input);

            // Assert
            Assert.IsTrue(actual);
        }
    }



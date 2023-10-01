using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PasswordLiberary2;

namespace PasswordLiberaryTests
{
    [TestClass]
    public class PasswordClassTests
    {
        [TestMethod]
        public void PasswordStrengthCheker_Five_ReturnFive()
        {
            //Arrange
            string password = "P2ssw0rd#";
            int expected = 5;
            //Act
            int action = PasswordClass.PasswordStrengthCheker(password);
            //Assert
            Assert.AreEqual(expected,action);
        }

        [TestMethod]
        public void PasswordStrengthCheker_Exception_ReturnException()
        {
            //Arrange
            string password = "Иванов";
            //Act
            Action action =()=> PasswordClass.PasswordStrengthCheker(password);
            //Assert
            Assert.ThrowsException<Exception>(action);
        }

        [TestMethod]
        public void PasswordStrengthCheker_Zero_ReturnZero()
        {
            //Arrange
            string password = "";
            int expected = 0;
            //Act
            int action = PasswordClass.PasswordStrengthCheker(password);
            //Assert
            Assert.AreEqual(expected, action);
        }

        [TestMethod]
        public void PasswordStrengthCheker_Three_ReturnThree()
        {
            //Arrange
            string password = "Password";
            int expected = 3;
            //Act
            int action = PasswordClass.PasswordStrengthCheker(password);
            //Assert
            Assert.AreEqual(expected, action);
        }

        [TestMethod]
        public void PasswordStrengthCheker_Four_ReturnFour()
        {
            //Arrange
            string password = "Passw0ord";
            int expected = 4;
            //Act
            int action = PasswordClass.PasswordStrengthCheker(password);
            //Assert
            Assert.AreEqual(expected, action);
        }

        [TestMethod]
        public void PasswordStrengthCheker_Two_ReturnTwo()
        {
            //Arrange
            string password = "Passw";
            int expected = 2;
            //Act
            int action = PasswordClass.PasswordStrengthCheker(password);
            //Assert
            Assert.AreEqual(expected, action);
        }



    }
}

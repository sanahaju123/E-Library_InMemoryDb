﻿using e_library.BusinessLayer.Interfaces;
using e_library.BusinessLayer.Services;
using e_library.BusinessLayer.Services.Repository;
using e_library.BusinessLayer.ViewModels;
using e_library.DataLayer;
using e_library.Entities;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace e_library.Test.TestCases
{
    public class BoundaryTests
    {
        private readonly ITestOutputHelper _output;
        private readonly ILibraryServices _libraryS;

        public readonly Mock<ILibraryRepository> libraryservice = new Mock<ILibraryRepository>();

        private readonly Book _book;
        private readonly Book_Issue _IssueBook;
        private readonly Student _student;

        private readonly StudentViewModel _studentViewModel;
        private static string type = "Boundary";
        public BoundaryTests(ITestOutputHelper output)
        {
            _libraryS = new LibraryServices(libraryservice.Object);

            _output = output;
            _book = new Book()
            {
                Id = 1,
                BookName = "Physics - 1",
                ISBN = "10091",
                Author = "K C Sinha",
                Publisher = "Sinha",
                Published_Year = 1990,
                Edition = "First",
                Streams = Streams.Science,
                Issued = true
            };
            _student = new Student()
            {
                Id = 1,
                Name = "Kundan",
                Email = "umakumarsingh@techademy.com",
                streams = Streams.Science,
                Phone = 9631438123,
                DOB = new DateTime(1990, 03, 01),
                Address = "Banglore"
            };
            _IssueBook = new Book_Issue()
            {
                Id = 1,
                BookId = 1,
                StudentId = 1,
                Issue_Date = DateTime.Now,
                Return_Date = DateTime.Now.AddDays(7),
                ActualReturn_Date = DateTime.Now,
                Fine = 0,
                Returned = false
            };
        }
        /// <summary>
        /// Test to validate book id is valid or not.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_ValidBookId()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                libraryservice.Setup(repo => repo.AddBook(_book)).ReturnsAsync(_book);
                var result = await _libraryS.AddBook(_book);
                if (result.Id == _book.Id)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Asert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            //Asert
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type); return res;
        }


        /// <summary>
        /// Test to validate book Name is valid or not.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_ValidBookName()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                libraryservice.Setup(repo => repo.AddBook(_book)).ReturnsAsync(_book);
                var result = await _libraryS.AddBook(_book);
                if (result.BookName == _book.BookName)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Asert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            //Asert
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }


        /// <summary>
        /// Test to validate book ISBN is valid or not.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_ValidBookISBN()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                libraryservice.Setup(repo => repo.AddBook(_book)).ReturnsAsync(_book);
                var result = await _libraryS.AddBook(_book);
                if (result.ISBN == _book.ISBN)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Asert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            //Asert
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }


        /// <summary>
        /// Test to validate book Author is valid or not.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_ValidBookAuthor()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                libraryservice.Setup(repo => repo.AddBook(_book)).ReturnsAsync(_book);
                var result = await _libraryS.AddBook(_book);
                if (result.Author == _book.Author)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Asert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            //Asert
            //final result save in text file.
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }


        /// <summary>
        /// Test to validate book Publisher is valid or not.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_ValidBookPublisher()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                libraryservice.Setup(repo => repo.AddBook(_book)).ReturnsAsync(_book);
                var result = await _libraryS.AddBook(_book);
                if (result.Publisher == _book.Publisher)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Asert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            //Asert
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }


        /// <summary>
        /// Test to validate book Published_Year is valid or not.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_ValidBookPublished_Year()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                libraryservice.Setup(repo => repo.AddBook(_book)).ReturnsAsync(_book);
                var result = await _libraryS.AddBook(_book);
                if (result.Published_Year == _book.Published_Year)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Asert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            //Asert
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_ValidBookEdition()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                libraryservice.Setup(repo => repo.AddBook(_book)).ReturnsAsync(_book);
                var result = await _libraryS.AddBook(_book);
                if (result.Edition == _book.Edition)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Asert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            //Asert
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }


        /// <summary>
        /// Test to validate book Streams is valid or not.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_ValidBookStreams()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                libraryservice.Setup(repo => repo.AddBook(_book)).ReturnsAsync(_book);
                var result = await _libraryS.AddBook(_book);
                if (result.Streams == _book.Streams)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Asert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            //Asert
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }


        /// <summary>
        /// Test to validate book Issued is valid or not.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_ValidBookIssued()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                libraryservice.Setup(repo => repo.AddBook(_book)).ReturnsAsync(_book);
                var result = await _libraryS.AddBook(_book);
                if (result.Issued == _book.Issued)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Asert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            //Asert
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }


        /// <summary>
        /// Test to validate student Id is valid or not.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_ValidStudentId()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                libraryservice.Setup(repo => repo.Register(_student)).ReturnsAsync(_student);
                var result = await _libraryS.Register(_student);
                if (result.Id == _student.Id)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Asert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            //Asert
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }


        /// <summary>
        /// Test to validate student Name is valid or not.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_ValidStudentName()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                libraryservice.Setup(repo => repo.Register(_student)).ReturnsAsync(_student);
                var result = await _libraryS.Register(_student);
                if (result.Name == _student.Name)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Asert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            //Asert
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }


        /// <summary>
        /// Test to validate student Email is valid or not.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_ValidStudentEmail()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                libraryservice.Setup(repo => repo.Register(_student)).ReturnsAsync(_student);
                var result = await _libraryS.Register(_student);
                if (result.Email == _student.Email)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Asert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            //Asert
            //final result save in text file.
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type); return res;
        }


        /// <summary>
        /// Test to validate student Streams is valid or not.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_ValidStudentstreams()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                libraryservice.Setup(repo => repo.Register(_student)).ReturnsAsync(_student);
                var result = await _libraryS.Register(_student);
                if (result.streams == _student.streams)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Asert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            //Asert
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        /// <summary>
        /// Test to validate student phone is valid or not.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_ValidStudentPhone()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                libraryservice.Setup(repo => repo.Register(_student)).ReturnsAsync(_student);
                var result = await _libraryS.Register(_student);
                if (result.Phone == _student.Phone)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Asert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            //Asert
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }


        /// <summary>
        /// Test to validate student DOB is valid or not.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_ValidStudentDOB()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                libraryservice.Setup(repo => repo.Register(_student)).ReturnsAsync(_student);
                var result = await _libraryS.Register(_student);
                if (result.DOB == _student.DOB)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Asert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            //Asert
            //final result save in text file.
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }


        /// <summary>
        /// Test to validate student Address is valid or not.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_ValidStudentAddress()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                libraryservice.Setup(repo => repo.Register(_student)).ReturnsAsync(_student);
                var result = await _libraryS.Register(_student);
                if (result.Address == _student.Address)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Asert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            //Asert
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }
    }
}

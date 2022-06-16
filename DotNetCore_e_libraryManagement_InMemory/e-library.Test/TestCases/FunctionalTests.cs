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
    public class FunctionalTests
    {
        private readonly ITestOutputHelper _output;

        private readonly ILibraryServices _libraryS;

        public readonly Mock<ILibraryRepository> libraryservice = new Mock<ILibraryRepository>();

        private readonly Book _book;
        private readonly Book_Issue _IssueBook;
        private readonly Student _student;

        private readonly StudentViewModel _studentViewModel;
        private static string type = "Functional";
        public FunctionalTests(ITestOutputHelper output)
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
        /// Test to validate valid book added in databse or not.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_ValidBookAdd()
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
                if (result != null)
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
        /// Get all issued book and validate book issued list is valid or not.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_GetAllIssuedBook()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                libraryservice.Setup(repo => repo.IssuedBook());
                var result = await _libraryS.IssuedBook();
                if (result != null)
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
        /// Test to validate get all book by student and courese stream
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_GetAllBooksByStream()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                libraryservice.Setup(repo => repo.AllBooksByStream(Streams.Science));
                var result = await _libraryS.AllBooksByStream(Streams.Science);
                if (result != null)
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
        /// Get all book by student stream by student Id
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_AllBooksByStudentStream()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                libraryservice.Setup(repo => repo.AllBooksByStudentStream(_student.Id));
                var result = await _libraryS.AllBooksByStudentStream(_student.Id);
                if (result != null)
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
        /// Test to validate a valid student register or not.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_ValidStudentRegister()
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
                if (result != null)
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
        /// Test to validate issue new book to student and return true if not test get failed.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_ValidIssueNewBook()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                libraryservice.Setup(repo => repo.IssueNewBook(_student.Id, _book.Id)).ReturnsAsync(true);
                var result = await _libraryS.IssueNewBook(_student.Id, _book.Id);
                if (result == true)
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
        /// Test to validate get all issued book by student Id
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_AllIssuedBookByStudentId()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                libraryservice.Setup(repo => repo.AllIssuedBookByStudentId(_student.Id));
                var result = await _libraryS.AllIssuedBookByStudentId(_student.Id);
                if (result != null)
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
        public async Task<bool> Testfor_Validate_GetAllBookWithFine()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                libraryservice.Setup(repo => repo.AllBookWithFine());
                var result = await _libraryS.AllBookWithFine();
                if (result != null)
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
        /// Return a book and update in book and issue_book table by tre if not test failed
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_ValidReturnBook()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                libraryservice.Setup(repo => repo.ReturnBook(_student.Id, _book.Id)).ReturnsAsync(true);
                var result = await _libraryS.ReturnBook(_student.Id, _book.Id);
                if (result == true)
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

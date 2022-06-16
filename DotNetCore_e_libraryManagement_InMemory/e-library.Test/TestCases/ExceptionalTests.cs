using e_library.BusinessLayer.Interfaces;
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
    public class ExceptionalTests
    {
        private readonly ITestOutputHelper _output;

        private readonly ILibraryServices _libraryS;

        public readonly Mock<ILibraryRepository> libraryservice = new Mock<ILibraryRepository>();

        public  Book _book;
        public Book_Issue _IssueBook;
        public Student _student;

        private readonly StudentViewModel _studentViewModel;
        private static string type = "Exceptional";
        public ExceptionalTests(ITestOutputHelper output)
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
        /// Test to validate invalid book add if book object is null.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_InvlidUserBookAdd()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            _book = null;
            //Act
            try
            {
                libraryservice.Setup(repo => repo.AddBook(_book)).ReturnsAsync(_book = null);
                var result = await _libraryS.AddBook(_book);
                if (result == null)
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
        /// Test to validate invalid student registration if student object is null.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_InvlidUserStudentRegister()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            _student = null;
            //Act
            try
            {
                libraryservice.Setup(repo => repo.Register(_student)).ReturnsAsync(_student = null);
                var result = await _libraryS.Register(_student);
                if (result == null)
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
    


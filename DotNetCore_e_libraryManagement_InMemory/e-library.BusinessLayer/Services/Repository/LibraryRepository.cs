using e_library.BusinessLayer.Services.UserException;
using e_library.DataLayer;
using e_library.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_library.BusinessLayer.Services.Repository
{
    public class LibraryRepository : ILibraryRepository
    {
        /// <summary>
        /// Creating referance Variable of DbContext
        /// </summary>
        private readonly LibraryDbContext _libraryDbContext;
        public LibraryRepository(LibraryDbContext libraryDbContext)
        {
            _libraryDbContext = libraryDbContext;
        }
        /// <summary>
        /// Add new book
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public async Task<Book> AddBook(Book book)
        {
            //do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// List all book based on book stream.
        /// </summary>
        /// <param name="streams"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Book>> AllBooksByStream(Streams streams)
        {
            //do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get all book by student Id with book stream.
        /// </summary>
        /// <param name="studentId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Book>> AllBooksByStudentStream(int studentId)
        {
            //do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get all book details with fine, If not return by stuent within duration
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Book>> AllBookWithFine()
        {
            //do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// show thoese books whos issued to student
        /// </summary>
        /// <param name="studentId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Book>> AllIssuedBookByStudentId(int studentId)
        {
            //do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// List all book that is allready issued to student.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Book>> IssuedBook()
        {
            //do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Issue a new book by student.
        /// </summary>
        /// <param name="studentId"></param>
        /// <param name="bookId"></param>
        /// <returns></returns>
        public async Task<bool> IssueNewBook(int studentId, int bookId)
        {
            //do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Register new Student
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public async Task<Student> Register(Student student)
        {
            //do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Return a book
        /// </summary>
        /// <param name="studentId"></param>
        /// <param name="bookId"></param>
        /// <returns></returns>
        public async Task<bool> ReturnBook(int studentId, int bookId)
        {
            //do code here
            throw new NotImplementedException();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Project.Avalon.Shared.DatabaseContext;
using Project.Avalon.Shared.Models;

namespace Project.Avalon.Web.Services.Students
{
    public class SemesterStudentsService
    {
        #region Property
        private readonly StudentsDBContext _studentsDBContext;
        #endregion

        #region Constructor
        public SemesterStudentsService(StudentsDBContext studentsDBContext)
        {
            _studentsDBContext = studentsDBContext;
        }
        #endregion

        #region Create a new student for this term
        public async Task<bool> CreateNewStudentForThisTermAsync(Current current)
        {
            await _studentsDBContext.CurrentStudents.AddAsync(current);
            await _studentsDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get This Terms Students
            public async Task<List<Current>> GetAllStudentsOfThisSemesterAsync()
        {
            return await _studentsDBContext.CurrentStudents.ToListAsync();
        }
        #endregion

        #region Get Each Term Student based on Id
        public async Task<Current> GetEachStudentOfThisSemesterBasedOnIdAsync(string Id)
        {
            Current student = await _studentsDBContext.CurrentStudents.SingleOrDefaultAsync(c => c.Id.Equals(Id));
            return student;
        }
        #endregion

        #region Update the current student
        public async Task<bool> UpdateCurrentStudent(Current current)
        {
            _studentsDBContext.CurrentStudents.Update(current);
            await _studentsDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Delete the current student
        public async Task<bool> DeleteCurrentStudentAsync(Current current)
        {
            _studentsDBContext.Remove(current);
            await _studentsDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Select For Referral
        public async Task<bool> SelectForReferralFromCurrent(Current current)
        {
            //Create a new selected company and assign the null variables
            Selected ReferredStudent = new Selected()
            {
                Id = current.Id,
                University = "N/A",
                Name = current.Name,
                Email = current.Email,
                ReferralNotes = String.Empty,
            };

            //Update IsInCurrentTerm to true and save changes
            current.IsSelectedForReferral = true;
            _studentsDBContext.CurrentStudents.Update(current);

            //Assign it into specific database
            await _studentsDBContext.SelectedStudents.AddAsync(ReferredStudent);

            //Save changes
            await _studentsDBContext.SaveChangesAsync();

            //Return true
            return true;
        }
        #endregion
    }
}

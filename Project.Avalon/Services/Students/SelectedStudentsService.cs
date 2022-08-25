using Microsoft.EntityFrameworkCore;
using Project.Avalon.Shared.DatabaseContext;
using Project.Avalon.Shared.Models;

namespace Project.Avalon.Web.Services.Students
{
    public class SelectedStudentsService
    {
        #region Property
        private readonly StudentsDBContext _studentsDBContext;
        #endregion

        #region Constructor
        public SelectedStudentsService(StudentsDBContext studentsDBContext)
        {
            _studentsDBContext = studentsDBContext;
        }
        #endregion

        #region Create a new student to be selected
        public async Task<bool> CreateNewStudentToBeSelectedAsync(Selected selected)
        {
            await _studentsDBContext.SelectedStudents.AddAsync(selected);
            await _studentsDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get All Selected Students
        public async Task<List<Selected>> GetAllSelectedStudentsAsync()
        {
            return await _studentsDBContext.SelectedStudents.ToListAsync();
        }
        #endregion

        #region Get Each Selected Student based on Id
        public async Task<Selected> GetEachSelectedStudentSemesterBasedOnIdAsync(string Id)
        {
            Selected student = await _studentsDBContext.SelectedStudents.SingleOrDefaultAsync(c => c.Id.Equals(Id));
            return student;
        }
        #endregion

        #region Update the selected student
        public async Task<bool> UpdateSelectedStudentAsync(Selected selected)
        {
            _studentsDBContext.SelectedStudents.Update(selected);
            await _studentsDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Delete the selected student
        public async Task<bool> DeleteSelectedStudentAsync(Selected selected)
        {
            _studentsDBContext.Remove(selected);
            await _studentsDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}

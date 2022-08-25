using Microsoft.EntityFrameworkCore;
using Project.Avalon.Shared.DatabaseContext;
using Project.Avalon.Shared.Models;

namespace Project.Avalon.Web.Services.Students
{
    public class AllStudentsService
    {
        #region Property
        private readonly StudentsDBContext _studentsDBContext;
        #endregion

        #region Constructor
        public AllStudentsService(StudentsDBContext studentsDBContext)
        {
            _studentsDBContext = studentsDBContext;
        }
        #endregion

        #region Create a new student
        public async Task<bool> CreateNewStudentAsync(All all)
        {
            await _studentsDBContext.AllStudents.AddAsync(all);
            await _studentsDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get All Students
        public async Task<List<All>> GetAllStudentsAsync()
        {
            return await _studentsDBContext.AllStudents.ToListAsync();
        }
        #endregion

        #region Get Each Student based on Id
        public async Task<All> GetEachStudentBasedOnIdAsync(string Id)
        {
            All student = await _studentsDBContext.AllStudents.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return student;
        }
        #endregion

        #region Update Student
        public async Task<bool> UpdateStudentAsync(All all)
        {
            _studentsDBContext.AllStudents.Update(all);
            await _studentsDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Delete Student
        public async Task<bool> DeleteStudentAsync(All all)
        {
            _studentsDBContext.Remove(all);
            await _studentsDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Add to current students
        public async Task<bool> AddToCurrentStudents(All all)
        {
            //Create a new selected company and assign the null variables
            Current CurrentStudent = new Current()
            {
                Id = all.Id,
                Name = all.Name,
                Email = all.Email,
                Major = all.Major,
                Minor = all.Minor,
                Concentration = all.Concentration,
                College = all.College,
                Department = all.Department,
                GPA = all.GPA,
                HasNoComplains = null,
                Notes = String.Empty,
                IsSelectedForReferral = all.IsSelectedForReferral
            };

            //Update IsInCurrentTerm to true and save changes
            all.IsInCurrentTerm = true;
            _studentsDBContext.AllStudents.Update(all);


            //Assign it into specific database
            await _studentsDBContext.CurrentStudents.AddAsync(CurrentStudent);

            //Save changes
            await _studentsDBContext.SaveChangesAsync();

            //Return true
            return true;
        }
        #endregion

        #region Select For Referral
        public async Task<bool> SelectForReferralFromAll(All all)
        {
            //Create a new selected company and assign the null variables
            Selected ReferredStudent = new Selected()
            {
                Id = all.Id,
                University = all.University,
                Name = all.Name,
                Email = all.Email,
                ReferralNotes = String.Empty
            };

            //Update IsInCurrentTerm to true and save changes
            all.IsSelectedForReferral = true;
            _studentsDBContext.AllStudents.Update(all);

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

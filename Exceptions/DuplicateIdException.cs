using System;

namespace EmployeeExceptions
{
    public class DuplicateIdException : Exception
    {
        public DuplicateIdException(int id)
            : base($"Employee with id {id} already exists!") { }
    }
}

using System;

namespace Domain.Exceptions
{
    public class DuplicateBranchNameException : Exception
    {
        public string BranchName { get; private set; }

        public DuplicateBranchNameException(string branchName)
        {
            BranchName = branchName;
        }
    }
}

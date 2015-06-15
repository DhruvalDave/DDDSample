using System;
using Domain.Exceptions;
using Domain.Specifications;

namespace Domain.Models
{
    public class Branch
    {
        public Guid BranchId { get; private set; }
        public string BranchName { get; set; }
        public string BranchTag { get; private set; }

        public Branch(Guid branchId, string branchName, string branchTag, IDuplicateBranchName duplicateBranchName)
        {
            BranchId = branchId;
            BranchName = BranchName;
            BranchTag = branchTag;

            //Raise an exception of Duplicate Branch Name
            if (duplicateBranchName.IsSatisfiedBy(this))
                throw new DuplicateBranchNameException(branchName);
        }
    }
}

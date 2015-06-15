using System.Linq;
using Domain.Infrastructure;
using Domain.Models;

namespace Domain.Specifications
{
    public class DuplicateBranchName : IDuplicateBranchName
    {
        private readonly IRepository _repository;

        public DuplicateBranchName(IRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Check for existence of branch name
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool IsSatisfiedBy(Branch entity)
        {
            var isBranchExists =
                _repository.Project<Branch, bool>(branch => branch.Any(b => b.BranchName.Equals(entity.BranchName)));
            return isBranchExists;
        }
    }

    public interface IDuplicateBranchName : ISpecification<Branch>
    {

    }
}

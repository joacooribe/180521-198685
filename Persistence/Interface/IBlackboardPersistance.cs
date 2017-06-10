using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public interface IBlackboardPersistance
    {
        void AddBlackboard(Blackboard blackboard);
        Blackboard GetBlackboard(string name, Team team);
        bool ExistsBlackboard(Blackboard blackboard);
        void DeleteBlackboard(Blackboard blackboard);
        bool IsEmptyBlackboardCollection();
    }
}

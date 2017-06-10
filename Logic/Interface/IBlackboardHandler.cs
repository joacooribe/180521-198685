using Domain;

namespace Logic
{
    public interface IBlackboardHandler
    {
        void AddBlackboard(Blackboard blackboard);
        Blackboard GetBlackboard(string name, Team team);
        bool ExistsBlackboard(Blackboard blackboard);
    }
}

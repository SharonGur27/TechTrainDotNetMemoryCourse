using System.Threading.Tasks.Dataflow;

namespace MemoryLeakExamples
{
    internal class ClosureMemberInAnonymousMethods
    {
        private ActionBlock<Action> _actionBlock;
        private readonly int _id;

        public ClosureMemberInAnonymousMethods(ActionBlock<Action> actionBlock)
        {
            _actionBlock = actionBlock;
        }

        public void Foo()
        {
            _actionBlock.Post(() =>
            {
                Console.WriteLine($"Executing action with ID {_id}");
            });
        }
    }
}

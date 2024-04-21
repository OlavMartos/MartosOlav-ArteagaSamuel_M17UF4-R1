using UnityEngine;

public class StateController : MonoBehaviour
{
    public NodeTree currentState;
    public GameObject target = null;

    public void StateTransition()
    {
        if (!currentState.AbortCondition(this))
        {
            if (currentState.children.Count != 0)
            {
                bool condition = false;
                int count = 0;
                while (!condition && count != currentState.children.Count)
                {
                    condition = CheckCondition(currentState.children[count++]);
                }

                if (condition)
                {
                    if (currentState.action != null) currentState.action.OnFinishedState();
                    currentState = currentState.children[count - 1];

                    if (currentState.action != null) currentState.action.OnSetState(this);
                }
            }
        }
        else GoRootState();
    }

    public void GoRootState()
    {
        if(currentState.parent != null)
        {
            if (currentState.action != null) currentState.action.OnFinishedState();
            currentState = currentState.parent;
            GoRootState();
        }
    }

    public bool CheckCondition(NodeTree node)
    {
        return node.Condition(this);
    }
}

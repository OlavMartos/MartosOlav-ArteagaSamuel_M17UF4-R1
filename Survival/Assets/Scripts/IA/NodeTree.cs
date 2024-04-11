using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Nodes", menuName = "Nodes/New Node", order = 3)]
public class NodeTree : ScriptableObject
{
    public NodeTree parent;
    public List<NodeTree> children;
    public SConditional condition;
    public List<SConditional> abortConditions;
    public SAction action;

    public bool Condition(StateController sc)
    {
        return condition.Check(sc);
    }

    public bool AbortCondition(StateController sc)
    {
        var abort = false;
        if(abortConditions != null)
        {
            foreach(var cond in abortConditions)
            {
                abort = abort || cond.Check(sc);
            }
        }
        return abort;
    }
}

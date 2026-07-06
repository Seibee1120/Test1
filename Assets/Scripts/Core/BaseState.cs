using UnityEngine;

public abstract class BaseState
{
    public abstract void EnterState(Animator animator);
    public abstract void UpdateState(Animator animator);
    public abstract void ExitState(Animator animator);
}

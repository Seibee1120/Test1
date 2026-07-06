using UnityEngine;

public class StateMachine : MonoBehaviour
{
    private Animator _anim;
    private BaseState _currentState;
    private BaseState _idleState;
    private BaseState _walkState;
    private BaseState _attackState;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _anim = GetComponent<Animator>();
        _idleState = new IdleState();
        _walkState = new WalkState();
        _attackState = new AttackState();

        SwitchState(_idleState);
    }

    // Update is called once per frame
    void Update()
    {
        _currentState?.UpdateState(_anim);
    }

    public void SwitchState(BaseState newState)
    {
        _currentState?.ExitState(_anim);
        _currentState = newState;
        _currentState?.EnterState(_anim);
    }

    public void TryAttack()
    {

    }
}

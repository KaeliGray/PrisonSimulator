using UnityEngine;

public class Action
{
    public KeyCode key;
    public States state;

    public Action(KeyCode key, States state)
    {
        this.key = key;
        this.state = state;
    }
}

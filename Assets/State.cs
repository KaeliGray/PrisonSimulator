using System.Collections.Generic;

public class State
{
    public States name;
    public string text;
    // list of keys and states
    public List<Action> actions;

    public State(States name, string text, List<Action> actions)
    {
        this.name = name;
        this.text = text;
        this.actions = actions;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextController : MonoBehaviour
{

    public Text text;

    public List<State> StateDefinitions = new List<State>()
    {
        new State(
            States.cell,
            "You have been sent to prison for committing the most heinous crimes in all of history. You are determined to get out." +
            "You have woken up in your cell and stand. Looking around you can see a toilet and a sink with a mirror above it. " +
            "\n\n Press T to view Toilet, B to view Bed, S to view Sink, M to view Mirror, and Y to serve your time of 60 years. ",
            new List<Action>()
            {
                new Action(KeyCode.T, States.toilet),
                new Action(KeyCode.B, States.bed_0),
                new Action(KeyCode.S, States.sink),
                new Action(KeyCode.M, States.mirror),
                new Action(KeyCode.Y, States.servetime)
            }
        ),
        new State(
            States.toilet,
            "This is your toilet." + "\n\n Press E to examine or R to return to roaming around your cell.",
            new List<Action>()
            {
                new Action(KeyCode.E, States.gross_0),
                new Action(KeyCode.R, States.cell)
            }
        ),
       new State(
            States.sink,
            "This is your sink. You wash your hands, as much as you can, here. Could there be a clue?" +
            "\n\n Press E to examine the sink, R to return to roaming around your cell, or M to look at your mirror",
            new List<Action>()
            {
                new Action(KeyCode.E, States.gross_1),
                new Action(KeyCode.R, States.cell)
            }
        ),
       new State(
            States.bed_0,
            "Your bed, where you have slept for the past 8 years. It's as hard as a rock." +
            "\n\n Press E to examine your bed or R to return to roaming around your cell.",
            new List<Action>()
            {
                new Action(KeyCode.E, States.sheets_0),
                new Action(KeyCode.R, States.cell)
            }
        ),
       new State(
            States.sink,
            "This is your sink. You wash your hands, as much as you can, here. Could there be a clue?" +
            "\n\n Press E to examine the sink, R to return to roaming around your cell, or M to look at your mirror",
            new List<Action>()
            {
                new Action(KeyCode.E, States.gross_1),
                new Action(KeyCode.R, States.cell),
                new Action(KeyCode.M, States.mirror)
            }
        ),
       new State(
            States.mirror,
            "Your mirror. Everytime you look at your reflection it reminds you that you will never see the light of day again." +
            "\n\n Press E to examine the mirror or R to return to roaming around your cell.",
            new List<Action>()
            {
                new Action(KeyCode.E, States.breakmirror),
                new Action(KeyCode.R, States.cell),
            }
        ),
       new State(
            States.servetime,
            "Maybe you should just serve your time." +
            "\n\n Press W to serve out your 60 more years or R to work to escape.",
            new List<Action>()
            {
                new Action(KeyCode.W, States.win),
                new Action(KeyCode.R, States.cell),
            }
        ),
       new State(
            States.gross_0,
            "You stuck your hand directly into the toilet. That's fucking gross. Why would you do that?" +
            "\n\n Press R to return to roaming around your cell...ya nasty.",
            new List<Action>()
            {
                new Action(KeyCode.R, States.cell),
            }
        ),
       new State(
            States.sheets_0,
            "You heard a lot of stories of people hanging themsleves with their sheets..." +
            "\n\n Press R to return to roaming around your cell.",
            new List<Action>()
            {
                new Action(KeyCode.R, States.cell),
            }
        ),
       new State(
            States.cell_shard,
            "Alright, now we are getting somewhere! Let's see what you can do with your new toy!" +
            "\n\n Press B to look at your bed, T to look at your toilet, S to look at your sink, W to wait for the guard to pass by, or Space to bitch out and serve your time.",
            new List<Action>()
            {
                new Action(KeyCode.B, States.bed_1),
                new Action(KeyCode.T, States.toilet),
                new Action(KeyCode.S, States.sink),
                new Action(KeyCode.W, States.guard),
                new Action(KeyCode.Space, States.servetime)

            }
        ),
       new State(
            States.breakmirror,
            "In a fit of rage you punched the mirror. Your hand is bleeding, but you have this really handy glass shard now." +
            "\n\n Press T to take the glass shard.",
            new List<Action>()
            {
                new Action(KeyCode.T, States.cell_shard),
            }
        ),
       new State(
            States.gross_1,
            "There is a thick coat of grime all over the sink, how have you been living like this?" +
            "\n\n Press R to return to roaming around your cell or M to look at your mirror.",
            new List<Action>()
            {
                new Action(KeyCode.R, States.cell),
                new Action(KeyCode.M, States.mirror),
            }
        ),
       new State(
            States.bed_1,
            "Still a bed." + "\n\n Press E to examine your bed or R to return to roaming around your cell.",
            new List<Action>()
            {
                new Action(KeyCode.E, States.sheets_1),
                new Action(KeyCode.R, States.cell_shard),
            }
        ),
       new State(
            States.sheets_1,
            "Maybe those people had a point, I mean, 60 years is a long ass time. Ending it all would stick it to the man, right?" +
            "\n\n Press C to cut the sheet or R to return to roaming around your cell.",
            new List<Action>()
            {
                new Action(KeyCode.C, States.cutsheet),
                new Action(KeyCode.R, States.cell_shard),
            }
        ),
       new State(
            States.cutsheet,
            "You cut the sheet and fashioned a noose. Is it time to end it all?" +
            "\n\n Press Space to hang yourself or R to rethink your options.",
            new List<Action>()
            {
                new Action(KeyCode.Space, States.hangself),
                new Action(KeyCode.R, States.cell_shard)
            }
        ),
       new State(
            States.hangself,
            "You took your own way out." + "\n\n Press Space to start over.",
            new List<Action>()
            {
                new Action(KeyCode.Space, States.cell)
            }
        ),
       new State(
            States.beaten,
            "You aren't the best looking inmate. The guard didn't take too kindly to the offer. He and three other guards come into your cell to teach you a lesson. " +
            "\n They beat you to the brink of death and leave." + "\n\n Press Space to continue.",
            new List<Action>()
            {
                new Action(KeyCode.Space, States.injuries)
            }
        ),
       new State(
            States.kill,
            "You reached through the cell bars and slit the guards throat. As you reach for his keys, other guards round the corner and rush to you." +
            " They taser and handcuff you. You have been given the death sentence." + "\n\n Press Space to continue",
            new List<Action>()
            {
                new Action(KeyCode.Space, States.death)
            }
        ),
       new State(
            States.injuries,
           "You succumb to your injuries and die alone on the floor." + "\n\n Press Space to start over.",
            new List<Action>()
            {
                new Action(KeyCode.Space, States.cell)
            }
        ),
       new State(
            States.win,
            "You served your time. It is 60 years later. You are old and all of your friends are gone." +
           "\n\n Press Space to start over.",
            new List<Action>()
            {
                new Action(KeyCode.Space, States.cell)
            }
        ),
        new State(
            States.guard,
            "The guard is walking by, you could kill him or try and offer him a sexual favor to get out." +
            "\n\n Press K to kill him or O to offer him a sexual favor.",
            new List<Action>()
            {
                new Action(KeyCode.K, States.kill),
                new Action(KeyCode.O, States.beaten),
            }
        ),
        new State(
            States.death,
            "You go in the electric chair. No one cries." + "\n\n Press Space to start over.",
            new List<Action>()
            {
                new Action(KeyCode.Space, States.cell),
            }
        ),

    };

    private States myState;
    // Use this for initialization
    void Start()
    {
        myState = States.cell;
    }

    // Update is called once per frame
    void Update()
    {
        StateDefinitions.ForEach(state =>
        {
            if (myState == state.name)
            {
                use_state(state);
            }
        });
    }

    void use_state(State state)
    {
        text.text = state.text;
        state.actions.ForEach(action =>
        {
            if (Input.GetKeyDown(action.key))
            {
                myState = action.state;
            }
        });
    }

}

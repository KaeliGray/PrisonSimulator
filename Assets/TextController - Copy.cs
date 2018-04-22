//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class TextController : MonoBehaviour
//{

//    public Text text;
//    private enum States
//    {
//        cell,
//        cell_shard,
//        toilet,
//        bed_0,
//        sink,
//        mirror,
//        servetime,
//        gross_0,
//        sheets_0,
//        breakmirror,
//        gross_1,
//        bed_1,
//        sheets_1,
//        cutsheet,
//        hangself,
//        win,
//        guard,
//        beaten,
//        kill,
//        injuries,
//        death
//    }
//    private States myState;
//    // Use this for initialization
//    void Start()
//    {
//        myState = States.cell;
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        print(myState);
//        if (myState == States.cell)
//        {
//            state_cell();
//        }
//        else if (myState == States.toilet)
//        {
//            state_toilet();
//        }
//        else if (myState == States.bed_0)
//        {
//            state_bed_0();
//        }
//        else if (myState == States.sink)
//        {
//            state_sink();
//        }
//        else if (myState == States.mirror)
//        {
//            state_mirror();
//        }
//        else if (myState == States.servetime)
//        {
//            state_servetime();
//        }
//        else if (myState == States.gross_0)
//        {
//            state_gross_0();
//        }
//        else if (myState == States.sheets_0)
//        {
//            state_sheets_0();
//        }
//        else if (myState == States.breakmirror)
//        {
//            state_breakmirror();
//        }
//        else if (myState == States.gross_1)
//        {
//            state_gross_1();
//        }
//        else if (myState == States.bed_1)
//        {
//            state_bed_1();
//        }
//        else if (myState == States.sheets_1)
//        {
//            state_sheets_1();
//        }
//        else if (myState == States.cutsheet)
//        {
//            state_cutsheet();
//        }
//        else if (myState == States.hangself)
//        {
//            state_hangself();
//        }
//        else if (myState == States.win)
//        {
//            state_win();
//        }
//        else if (myState == States.guard)
//        {
//            state_guard();
//        }
//        else if (myState == States.kill)
//        {
//            state_kill();
//        }
//        else if (myState == States.death)
//        {
//            state_death();
//        }
//        else if (myState == States.injuries)
//        {
//            state_injuries();
//        }
//        else if (myState == States.beaten)
//        {
//            state_beaten();
//        }
//        else if (myState == States.cell_shard)
//        {
//            state_cell_shard();
//        }
//        if (Input.GetKeyDown(KeyCode.Space))
//        {


//        }
//    }
//    void state_cell()
//    {
//        text.text = "You have been sent to prison for committing the most heinous crimes in all of history. You are determined to get out." +
//                "You have woken up in your cell and stand. Looking around you can see a toilet and a sink with a mirror above it. " +
//                "\n\n Press T to view Toilet, B to view Bed, S to view Sink, M to view Mirror, and Space to serve your time of 60 years. ";
//        if (Input.GetKeyDown(KeyCode.T))
//        {
//            myState = States.toilet;
//        }
//        else if (Input.GetKeyDown(KeyCode.B))
//        {
//            myState = States.bed_0;
//        }
//        else if (Input.GetKeyDown(KeyCode.S))
//        {
//            myState = States.sink;
//        }
//        else if (Input.GetKeyDown(KeyCode.M))
//        {
//            myState = States.mirror;
//        }
//        else if (Input.GetKeyDown(KeyCode.Space))
//        {
//            myState = States.servetime;
//        }
//    }
//    void state_toilet()
//    {
//        text.text = "This is your toilet." + "\n\n Press E to examine or R to return to roaming around your cell.";
//        if (Input.GetKeyDown(KeyCode.E))
//        {
//            myState = States.gross_0;
//        }
//        else if (Input.GetKeyDown(KeyCode.R))
//        {
//            myState = States.cell;
//        }
//    }
//    void state_sink()
//    {
//        text.text = "This is your sink. You wash your hands, as much as you can, here. Could there be a clue?" + 
//            "\n\n Press E to examine the sink, R to return to roaming around your cell, or M to look at your mirror";
//        if (Input.GetKeyDown(KeyCode.E))
//        {
//            myState = States.gross_1;
//        }
//        else if (Input.GetKeyDown(KeyCode.R))
//        {
//            myState = States.cell;
//        }
//        else if (Input.GetKeyDown(KeyCode.M))
//        {
//            myState = States.mirror;
//        }
//    }
//    void state_bed_0()
//    {
//        text.text = "Your bed, where you have slept for the past 8 years. It's as hard as a rock." + 
//            "\n\n Press E to examine your bed or R to return to roaming around your cell.";
//        if (Input.GetKeyDown(KeyCode.E))
//        {
//            myState = States.sheets_0;
//        }
//        else if (Input.GetKeyDown(KeyCode.R))
//        {
//            myState = States.cell;
//        }
//    }
//    void state_mirror()
//    {
//        text.text = "Your mirror. Everytime you look at your reflection it reminds you that you will never see the light of day again." + 
//            "\n\n Press E to examine the mirror or R to return to roaming around your cell.";
//        if (Input.GetKeyDown(KeyCode.E))
//        {
//            myState = States.breakmirror;
//        }
//        else if (Input.GetKeyDown(KeyCode.R))
//        {
//            myState = States.cell;
//        }
//    }
//    void state_servetime()
//    {
//        text.text = "Maybe you should just serve your time." + "\n\n Press the space bar to serve out your 60 more years or R to work to escape.";
//        if (Input.GetKeyDown(KeyCode.Space))
//        {
//            myState = States.win;
//        }
//        else if (Input.GetKeyDown(KeyCode.R))
//        {
//            myState = States.cell;
//        }
//    }
//    void state_gross_0()
//    {
//        text.text = "You stuck your hand directly into the toilet. That's fucking gross. Why would you do that?" + 
//            "\n\n Press R to return to roaming around your cell...ya nasty.";
//        if (Input.GetKeyDown(KeyCode.R))
//        {
//            myState = States.cell;
//        }

//    }
//    void state_gross_1()
//    {
//        text.text = "There is a thick coat of grime all over the sink, how have you been living like this?" + 
//            "\n\n Press R to return to roaming around your cell or M to look at your mirror.";
//        if (Input.GetKeyDown(KeyCode.R))
//        {
//            myState = States.cell;
//        }
//        else if (Input.GetKeyDown(KeyCode.M))
//        {
//            myState = States.mirror;
//        }
//    }
//    void state_sheets_0()
//    {
//        text.text = "You heard a lot of stories of people hanging themsleves with their sheets..." + 
//            "\n\n Press R to return to roaming around your cell.";
//        if (Input.GetKeyDown(KeyCode.R))
//        {
//            myState = States.cell;
//        }

//    }
//    void state_breakmirror()
//    {
//        text.text = "In a fit of rage you punched the mirror. Your hand is bleeding, but you have this really handy glass shard now." + 
//            "\n\n Press T to take the glass shard.";
//        if (Input.GetKeyDown(KeyCode.T))
//        {
//            myState = States.cell_shard;
//        }
//    }
//    void state_cell_shard()
//    {
//        text.text = "Alright, now we are getting somewhere! Let's see what you can do with your new toy!" + 
//            "\n\n Press B to look at your bed, T to look at your toilet, S to look at your sink, W to wait for the guard to pass by, or Space to bitch out and serve your time.";
//        if (Input.GetKeyDown(KeyCode.B))
//        {
//            myState = States.bed_1;
//        }
//        else if (Input.GetKeyDown(KeyCode.T))
//        {
//            myState = States.toilet;
//        }
//        else if (Input.GetKeyDown(KeyCode.S))
//        {
//            myState = States.sink;
//        }
//        else if (Input.GetKeyDown(KeyCode.W))
//        {
//            myState = States.guard;
//        }
//        else if (Input.GetKeyDown(KeyCode.Space))
//        {
//            myState = States.servetime;
//        }
//    }
//    void state_bed_1()
//    {
//        text.text = "Still a bed." + "\n\n Press E to examine your bed or R to return to roaming around your cell.";
//        if (Input.GetKeyDown(KeyCode.E))
//        {
//            myState = States.sheets_1;
//        }
//        else if (Input.GetKeyDown(KeyCode.R))
//        {
//            myState = States.cell_shard;
//        }
//    }
//    void state_sheets_1()
//    {
//        text.text = "Maybe those people had a point, I mean, 60 years is a long ass time. Ending it all would stick it to the man, right?" + 
//            "\n\n Press C to cut the sheet or R to return to roaming around your cell.";
//        if (Input.GetKeyDown(KeyCode.C))
//        {
//            myState = States.cutsheet;
//        }
//        else if (Input.GetKeyDown(KeyCode.R))
//        {
//            myState = States.cell_shard;
//        }
//    }
//    void state_guard()
//    {
//        text.text = "The guard is walking by, you could kill him or try and offer him a sexual favor to get out." + 
//            "\n\n Press K to kill him or O to offer him a sexual favor.";
//        if (Input.GetKeyDown(KeyCode.K))
//        {
//            myState = States.kill;
//        }
//        else if (Input.GetKeyDown(KeyCode.O))
//        {
//            myState = States.beaten;
//        }
//    }
//    void state_cutsheet()
//    {
//        text.text = "You cut the sheet and fashioned a noose. Is it time to end it all?" + 
//            "\n\n Press Space to hang yourself or R to rethink your options.";
//        if (Input.GetKeyDown(KeyCode.Space))
//        {
//            myState = States.hangself;
//        }
//        else if (Input.GetKeyDown(KeyCode.R))
//        {
//            myState = States.cell_shard;
//        }
//    }
//    void state_kill()
//    {
//        text.text = "You reached through the cell bars and slit the guards throat. As you reach for his keys, other guards round the corner and rush to you." + 
//            " They taser and handcuff you. You have been given the death sentence." + "\n\n Press Space to continue";
//        if (Input.GetKeyDown(KeyCode.Space))
//        {
//            myState = States.death;
//        }
//    }
//    void state_beaten()
//    {
//        text.text = "You aren't the best looking inmate. The guard didn't take too kindly to the offer. He and three other guards come into your cell to teach you a lesson. " + 
//            "\n They beat you to the brink of death and leave." + "\n\n Press Space to continue.";
//        if (Input.GetKeyDown(KeyCode.Space))
//        {
//            myState = States.injuries;
//        }
//    }
//    void state_death()
//    {
//        text.text = "You go in the electric chair. No one cries." + "\n\n Press Space to start over.";
//        if (Input.GetKeyDown(KeyCode.Space))
//        {
//            myState = States.cell;
//        }

//    }
//    void state_injuries()
//    {
//        text.text = "You succumb to your injuries and die alone on the floor." + "\n\n Press Space to start over.";
//        if (Input.GetKeyDown(KeyCode.Space))
//        {
//            myState = States.cell;
//        }
//    }
//    void state_hangself()
//    {
//        text.text = "You took your own way out." + "\n\n Press Space to start over.";
//        if (Input.GetKeyDown(KeyCode.Space))
//        {
//            myState = States.cell;
//        }
//    }
//    void state_win()
//    {
//        text.text = "You served your time. It is 60 years later. You are old and all of your friends are gone." + "\n\n Press Space to start over.";
//        if (Input.GetKeyDown(KeyCode.Space))
//        {
//            myState = States.cell;
//        }
//    }
//}

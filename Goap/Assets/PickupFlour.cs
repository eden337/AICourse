using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupFlour : GoapAction
{
    bool completed = false;
    float startTime = 0;
    public float workDuration = 2;
    public Inventory windmill;
    public PickupFlour()
    {
        addPrecondition("hasStock", true);
        addPrecondition("hasFlour", false);
        addEffect("hasFlour", true);
        name = "PickupFlour";
    }

    public override bool checkProceduralPrecondition(GameObject agent)
    {
        return true;
    }

    public override bool isDone()
    {
        return completed;
    }

    public override bool perform(GameObject agent)
    {
        if (startTime == 0)
        {
            Debug.Log("Starting: " + name);
            startTime = Time.time;
        }

        if (Time.time - startTime > workDuration)
        {
            Debug.Log("Finished: " + name);
            this.GetComponent<Inventory>().flourLevel += 5;
            windmill.flourLevel -= 5;
            completed = true;
        }
        return true;
    }

    public override bool requiresInRange()
    {
        return true;
    }

    public override void reset()
    {
        completed = false;
        startTime = 0;
    }
}

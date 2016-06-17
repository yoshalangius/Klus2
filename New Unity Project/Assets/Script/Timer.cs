using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour
{

    private float TimeStamp = 0;

    private float MaxTime = 20;

    public bool TimeStampAchieved = false;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        TimeStamp = TimeStamp + 0.1f;

        if (TimeStamp > MaxTime)
        {
            TimeStamp = 0;
            TimeStampAchieved = true;

        }
        else
        {
            Debug.Log(TimeStampAchieved);
            TimeStamp = TimeStamp + 0.1f;
        }

        if (TimeStamp < 0)
        {
            TimeStampAchieved = false;
        }

	}
}

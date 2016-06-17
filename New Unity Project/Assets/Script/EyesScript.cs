using UnityEngine;
using System.Collections;

public class EyesScript : MonoBehaviour
{

    [SerializeField]
    private float TimeStamp = 0;
    [SerializeField]
    private float MaxTime = 20;

    public bool TimeStampAchieved = false;


    [SerializeField]
    private Animator anim;


    int TimeHash = Animator.StringToHash("TimeStampAchieved");


    // Use this for initialization
    void Start ()
    {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        TimeStaps();
	}

    void TimeStaps()
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

        if (TimeStamp > 40)
        {
            TimeStampAchieved = false;
        }
    }
}

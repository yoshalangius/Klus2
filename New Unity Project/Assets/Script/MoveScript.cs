using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour
{

    private float TimeStamp = 0;

    private float MaxTime = 20;

    private float DotCount = 2;

    public bool TimeStampAchieved = false;

    [SerializeField]
    private GameObject Dot;

    private float Speed = 0.05f;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {

        FaceRight();

        if (DotCount > 0)
        {
            TimeStaps();
            DotSpawner();
        }

    }

    void FaceRight()
    {
        transform.Translate(-Speed, 0, 0);
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

        if (TimeStamp > 0)
        {
            TimeStampAchieved = false;
        }
    }

    void DotSpawner()
    {
        if (TimeStampAchieved == true)
        {
            Instantiate(Dot, transform.position, Quaternion.identity);
            DotCount = DotCount - 1;

        }
    }
}

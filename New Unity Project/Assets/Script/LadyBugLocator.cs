using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LadyBugLocator : MonoBehaviour
{

    private int _count;

    public AudioClip impact;
    AudioSource audio;

    [SerializeField]
    private GameObject BlackBox;

    [SerializeField]
    private GameObject Button;


    public Text countText;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_count == 4)
        {
            BlackBox.gameObject.SetActive(false);
            Button.gameObject.SetActive(true);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Dot"))
        {
            //other.gameObject.SetActive(false);
            _count = _count + 1;
            Debug.Log("i picked up the pick up");
            SetCountText();
            audio.PlayOneShot(impact, 5.7F);
        }
    }

    void SetCountText()
    {
        countText.text = "Score: " + _count.ToString();
        if (_count >= 12)
        {

        }
    }
}

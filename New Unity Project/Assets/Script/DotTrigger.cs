using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DotTrigger : MonoBehaviour
{

    private int _count;

    public Text countText;

    [SerializeField]
    private GameObject Button;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (_count == 8)
        {
            Button.gameObject.SetActive(true);
        }


    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Dot"))
        {
            
            _count = _count + 1;
            
        }
    }

   
}

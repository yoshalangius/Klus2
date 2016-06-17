using UnityEngine;
using System.Collections;

public class audioLine : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        yield return new WaitForSeconds(source.clip.length - ((float)source.timeSamples / source.clip.frequancy));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

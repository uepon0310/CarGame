using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

    float speed = 0;
    Vector2 startPosition;

    public AudioClip audioClip1;
    AudioSource audioSource;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            startPosition = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Vector2 endPosition = Input.mousePosition;
            float swipeLength = endPosition.x - startPosition.x;

            speed = swipeLength / 500.0f;
            //GetComponents<AudioSource>();
            audioSource = gameObject.GetComponent<AudioSource>();
            audioSource.clip = audioClip1;
            audioSource.Play();
        }

        transform.Translate(speed, 0, 0);
        speed *= 0.98f;
    }
}

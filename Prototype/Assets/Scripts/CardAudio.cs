using UnityEngine;
using System.Collections;

public class CardAudio : MonoBehaviour
{
    public GameObject card;
    public AudioClip CardPickUp;
    public AudioClip CardDrop;

    private AudioSource source;
    private AudioSource source1;


	void Start ()
    {
        source = GetComponent<AudioSource>();
        source1 = GetComponent<AudioSource>();
	}
	
	void Update ()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            float vol = 1.0f;
            source.PlayOneShot(CardPickUp, vol);            
        }

        else if(Input.GetButtonUp("Fire1"))
        {
            float vol = 1.0f;
            source1.PlayOneShot(CardDrop, vol);
        }
	}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static ScoreController;

public class BoardHit : MonoBehaviour
{

    public AudioSource source;
    public AudioClip[] notes;

    private void Start()
    {
        source = gameObject.GetComponent<AudioSource>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "BeanBag")
        {
            source.clip = notes[Random.Range(0, notes.Length)];
            source.Play();
        }
    }
   
}

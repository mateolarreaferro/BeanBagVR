using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ScoreController;

public class holeHit : MonoBehaviour
{
    public AudioSource source;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "BeanBag")
        {
            ScoreController.Instance.HitHole();
            source.GetComponent<AudioSource>().Play();
        }
    }
}

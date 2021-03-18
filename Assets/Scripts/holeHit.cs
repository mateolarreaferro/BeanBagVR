using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ScoreController;

public class holeHit : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "BeanBag")
        {
            ScoreController.Instance.HitHole();
        }
    }
}

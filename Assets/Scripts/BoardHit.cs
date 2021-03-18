using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static ScoreController;

public class BoardHit : MonoBehaviour
{

  
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "BeanBag")
        {
            Debug.Log("Good Try!");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Ok, but not!");
    }
}

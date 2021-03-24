using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeanbagScript : MonoBehaviour
{
  
    public void Thrown()
    {
        BagsController.Instance.BagOnDeck();
        gameObject.layer = 0;
    }
}

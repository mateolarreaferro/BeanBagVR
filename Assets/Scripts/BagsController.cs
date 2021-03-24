using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BagsController : MonoBehaviour
{
    //VARIABLES

    public static BagsController Instance; //Singleton

    public GameObject beanbagPrefab; //Calls Prefab (Instantiate)

    public Transform spawnTrans; //Transofrm.pos Prefab

    GameObject [] copiedBags; //Stores Bags

    int i; //Index for copiedBags[]



    private void Awake() //Singleton
    {
        if(Instance == null)

        {
            Instance = this;
        }

        else

        {
            Destroy(this);
        }
    }

    private void Start()
    {
        BagOnDeck();    
    }

    public void BagOnDeck()
    {
         copiedBags[i] = Instantiate(beanbagPrefab, spawnTrans.transform.position, beanbagPrefab.transform.rotation);
         //Changes light Color *** Currently not working
         copiedBags[i].GetComponent<Light>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));

            i = +1;

    }
   
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BagsController : MonoBehaviour
{

    public static BagsController Instance;
    public GameObject beanbagPrefab;
    public Transform spawnTrans;
    GameObject [] copiedBags;
    int i;



    private void Awake() //singleton
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
            //REVIEW WITH GREG
            copiedBags[i].GetComponent<Light>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));


            i = +1;

    }
   
    
}

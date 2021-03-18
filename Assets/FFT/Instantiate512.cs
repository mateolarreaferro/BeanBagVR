using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate512 : MonoBehaviour
{
	public GameObject sampleObjectPrefab;
	GameObject[] objectArray = new GameObject[512];
	public float maxScale;
	//Renderer renderColor;



	// Start is called before the first frame update
	void Start()
	{

		for (int i = 0; i < 512; i++)
		{
			GameObject copiedObject = (GameObject)Instantiate(sampleObjectPrefab); //Copies sampleObjectPrefab
			copiedObject.transform.position = this.transform.position; //Assigns it to position of the object where the script is attached
			copiedObject.transform.parent = this.transform;
			copiedObject.name = "Sample Object" + i; //Changes name and adds number to copy
			this.transform.eulerAngles = new Vector3(0, -0.703125f * i, 0); //y # came from 360/512
			copiedObject.transform.position = Vector3.forward * 100; //100 is arbitrary
			objectArray[i] = copiedObject;
			objectArray[i].GetComponent<Renderer>().material.color =
				new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));

		}


	}

	// Update is called once per frame
	void Update()
	{
		for (int i = 0; i < 512; i++)
		{
			if (objectArray != null)
			{
				objectArray[i].transform.localScale = new Vector3(10, (AudioPeer.samples[i] * maxScale) + 2, 10);
			}
		}


	}
}

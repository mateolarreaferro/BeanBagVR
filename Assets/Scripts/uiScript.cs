using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uiScript : MonoBehaviour
{
    //VARIABLES

    public GameObject board; //to alter height

    public GameObject sun; //change hour

    public AudioSource source;

    public AudioClip[] sfx; //Sound Effects


   

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    
    }


    // Buttons

    public void ResetGame()
    {
        source.clip = sfx[0];
        source.Play();
        SceneManager.LoadScene(0);
    }

    public void FinishGame()
    {
        source.clip = sfx[0];
        source.Play();
        Application.Quit();
    }


    // Sliders

    public void ChangeBoardHeight(float height)
    {
        source.clip = sfx[1];
        source.Play();
        board.transform.position = new Vector3(board.transform.position.x, height, board.transform.position.z);
    }

    public void ChangeTimeOfDay(float movement)
    {
        source.clip = sfx[1];
        source.Play();
        movement += 10f;
        sun.transform.Rotate(movement, 0, 0, Space.World);
    }


 
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uiScript : MonoBehaviour
{
    public GameObject board; //to alter size


    ////Music System
    //bool MusicStatus;
    //public AudioSource Source;
    //public AudioClip[] clips;

    // Start is called before the first frame update
    void Start()
    {
        //StartMusic();

        
    }

    void Update()
    {
        //if (!Source.isPlaying)
        //{
        //    ShuffleSongs();
        //}
    }

    // Buttons

    public void ResetGame()
    {
        SceneManager.LoadScene(0);
    }

    public void FinishGame()
    {
        Application.Quit();
    }

    //public void ShuffleSongs()
    //{
    //    int newClip = Random.Range(0, clips.Length);
    //    Source.clip = clips[newClip];
    //    Source.Play();
    //}


    // Sliders

    public void ChangeBoardSize(float size)
    {
        //
    }

    public void ChangeTimeOfDay(float movement)
    {
        //
    }


    // Toggle

    //public void Music()
    //{
    //    if (MusicStatus == true)
    //    {
    //        Source.Pause();
    //        MusicStatus = false;
    //    }
    //    if (MusicStatus == false)
    //    {
    //        Source.Play();
    //        MusicStatus = true;
    //    }
        
    //}

    // Others

    //void StartMusic()
    //{
    //    Source = GetComponent<AudioSource>();
    //    int randomClip = Random.Range(0, clips.Length);
    //    Source.clip = clips[randomClip];
    //    Source.Play();
    //    MusicStatus = true;

    //}

    






    

 

 
}

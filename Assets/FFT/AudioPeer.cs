using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (AudioSource))]
public class AudioPeer : MonoBehaviour
{
    //VARIABLES

    AudioSource Source;
    public static float[] samples = new float[512]; //static so that we can access from other scripts
    public static float[] freqBand = new float[8];

    //Music System
    bool MusicStatus;
    public AudioClip[] clips;

    //UI Sound
    public AudioSource uiAS;
    public AudioClip [] uiClips;


    // Start is called before the first frame update
    void Start()
    {
        Source = GetComponent<AudioSource>();
        uiAS = GetComponent<AudioSource>();
        StartMusic();
       
    }

    // Update is called once per frame
    void Update()
    {
        GetSpectrumAudioSource();

        MakeFrequencyBands();

        if (!Source.isPlaying)
        {
            ShuffleSongs(); //Goes to next song once song is finished
        }
    }

    void GetSpectrumAudioSource()
    {
        Source.GetSpectrumData(samples, 0, FFTWindow.Blackman);
    }

    void MakeFrequencyBands()
    {
       
        int count = 0;

        for (int i = 0; i < 8; i++)
        {
            float average = 0;
            int sampleCount = (int)Mathf.Pow(2, i) * 2; // --> 2, 4, 8, 16, 32,....., 256

            if (i == 7)
            {
                sampleCount += 2; // to get 512 intead of 510
            }

            for (int j = 0; j < sampleCount; j++)
            {
                average += samples[count] * (count + 1);
                count++;
            }

            average /= count;

            freqBand[i] = average * 10;


            //Logic
            //number of hertz the song has / 512 band = x per sample

            //Bands:
            //20-60 Hz - Sub Bass
            //60-250 - Bass
            //250-500 - Low Midrange
            //500-2kHz - Midrange
            //2-4kHz - Upper Midrange
            //4-6kHz - Presence
            //6-20kHz - Brilliance

            //0-2 -> 2x
            //1 - 4 -> 4x
            //2 - 8 -> 8x
            //3 - 
            //4
            //5
            //6
            //7 - 256 -> 256x



        }

    }

    public void ShuffleSongs()
    {
        uiAS.clip = uiClips[0];
        uiAS.Play();
        int newClip = Random.Range(0, clips.Length);
        Source.clip = clips[newClip];
        Source.Play();
    }

    public void Music()
    {
        
        if (MusicStatus == true)
        {
            uiAS.clip = uiClips[0];
            uiAS.Play();
            Source.Pause();
            Debug.Log("Hasta Aqui");
            MusicStatus = false;
            
        }
    

    }
    void StartMusic()
    {
        Source = GetComponent<AudioSource>();
        int randomClip = Random.Range(0, clips.Length);
        Source.clip = clips[randomClip];
        Source.Play();
        MusicStatus = true;

    }
}

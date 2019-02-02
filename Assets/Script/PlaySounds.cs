using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySounds : MonoBehaviour {

    public AudioClip carEngine;
    public AudioClip money;
    public AudioClip openDoor;
    public AudioClip knockDoor;
    public AudioClip buzz;
    public AudioClip hang;
    public AudioClip furnituremove;
    public AudioClip crowd;
    public AudioClip cellring;
    public AudioClip dishes;

    public AudioClip soundTrack1;
    public AudioClip soundTrack2;
    public AudioClip soundTrack3;

    public AudioSource songFX;
    public AudioSource soundTrack;


    public int current;

    void Update()
    {
        if (current != GameManager.currentDialogId)
        {
            current = GameManager.currentDialogId;
            songFX.Stop();
            foreach (int i in GameManager.dialog[GameManager.currentDialogId].songs)
            {
                if (i < 20)
                {
                    songFX.Play();
                    audioClipChange(i);
                    songFX.Play();
                }
                else
                {
                    soundTrack.Play();
                    soundTrackChange(i);
                    soundTrack.Play();
                }
            }
        }
    }

    void audioClipChange(int idSong)
    {
        switch (idSong)
        {
            case 1:
                songFX.clip = cellring;
                break;
            case 2:
                songFX.clip = knockDoor;
                break;
            case 3:
                songFX.clip = openDoor;
                break;
            case 4:
                songFX.clip = hang;
                break;
            case 5:
                songFX.clip = dishes;
                break;
            case 6:
                songFX.clip = buzz;
                break;
            case 7:
                songFX.clip = furnituremove;
                break;
            case 8:
                songFX.clip = crowd;
                break;
            case 9:
                songFX.clip = money;
                break;
            case 10:
                songFX.clip = carEngine;
                break;

        }
    }


    void soundTrackChange(int idSound)
    {
        switch (idSound)
        {
            case 20:
                soundTrack.clip = soundTrack1;
                break;
            case 21:
                soundTrack.clip = soundTrack2;
                break;
            case 22:
                soundTrack.clip = soundTrack3;
                break;
        }
    }

}

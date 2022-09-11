using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    //Audio Sources
    [SerializeField] private AudioSource playerSource;
    [SerializeField] private AudioSource monsterSource;
    [SerializeField] private AudioSource ambientSource;

    //Audio Assets
    #region audio assets
    [SerializeField] public AudioClip lampOn;
    [SerializeField] public AudioClip lampOff;
    [SerializeField] public AudioClip lever;
    [SerializeField] public AudioClip door;
    [SerializeField] public AudioClip button;

    [SerializeField] public AudioClip ambientSound_1;
    #endregion

    private void Awake() // szenen übergreifende Musik
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }        
    }

    private void Start()
    {
        //ambientSource.PlayOneShot(ambientSound_1);
    }

    public void playSound(Sounds sound)
    {
        switch (sound)
        {
            case Sounds.LampOn:
                Debug.Log("Sound: LampOn");
                playerSource.PlayOneShot(lampOn);
                break;
            case Sounds.LampOff:
                Debug.Log("Sound: LampOff");
                playerSource.PlayOneShot(lampOff);
                break;
            case Sounds.Lever:
                playerSource.PlayOneShot(lever);
                break;
            case Sounds.Door:
                playerSource.PlayOneShot(door);
                break;
            case Sounds.Button:
                playerSource.PlayOneShot(button);
                break;

        }


    }

    public void playAmbientSound()
    {

    }


}

public enum Sounds
{
    LampOn,
    LampOff,
    Lever,
    Button,
    Door,

}

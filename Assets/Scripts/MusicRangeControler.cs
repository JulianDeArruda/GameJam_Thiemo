using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicRangeControler : MonoBehaviour
{
    public AudioSource track1;
    public AudioSource track2;
    public AudioSource track3;

    public bool musicOnOff;

    public float volumeModifier = 0.5f;

    public float track1MaxDist;
    public float track2MaxDist;
    public float track3MaxDist;

    public GamneObject player;
    public GamneObject target;

    void Update() 
    {
        if (musicOnOff)
        {
            track1.volume = CalculateDistanceVolume(track1MaxDist) - volumeModifier;
            track2.volume = CalculateDistanceVolume(track2MaxDist) - volumeModifier;
            track3.volume = CalculateDistanceVolume(track3MaxDist) - volumeModifier;
        }
    }

    float CalculateDistanceVolume(float MaxDist) 
    { // Distance between target an player:
        float distance = Vector3.Distance(player.transform.position, target.transform.position);
        // sauberere zahlen:
        float distanceClamped = Mathf.Clamp(distance, 0, MaxDist);
        //dividing the distance so it returns from1 to 0 (Music is quieter the closer you get)
        float audiDeistance = distanceClamped / MaxDist;
        // inverting the result so it gets louder the closer you are
        audiDeistance = 1 - audiDeistance;
        return audiDeistance;
    }
}

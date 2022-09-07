using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprechblasen : TexteundDialoge
{
    [SerializeField] GameObject CharacterProfile;

    public void ChangeProfile(GameObject Profile)
    {
        CharacterProfile= Profile;
    }

    public override void setVariable()
    {
        if (_up)
        {
            textTMP.text = _text;
            CharacterProfile.SetActive(true);
        }
        else
        {
            textTMP.text = "";
            CharacterProfile.SetActive(false);
        }
    }
}

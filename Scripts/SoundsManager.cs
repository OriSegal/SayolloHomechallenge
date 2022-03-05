using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsManager : MonoBehaviour
{
    public AudioSource[] Sounds;

    public void PlayJetSound()
    {
        Sounds[0].Play();
    }

    public void StopJetSound()
    {
        Sounds[0].Stop();
    }

    public void HitSound()
    {
        Sounds[1].Play();
    }

    public void FruitSound()
    {
        Sounds[2].Play();
    }

    public void ClickSound()
    {
        Sounds[3].Play();
    }
}

using UnityEngine;
using UnityEngine.Audio;

public class AudioChangeVolume : MonoBehaviour
{
    public AudioMixer group;
    public string floatParam = "MyExposedParam";

    public void ChangeVolume(float volume)
    {
        group.SetFloat(floatParam, volume);
    }
}

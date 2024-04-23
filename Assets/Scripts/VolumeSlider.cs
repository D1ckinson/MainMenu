using UnityEngine;
using UnityEngine.Audio;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _mixer;

    public void ChangeVolume(float volume) =>
        _mixer.audioMixer.SetFloat(_mixer.name, volume);
}

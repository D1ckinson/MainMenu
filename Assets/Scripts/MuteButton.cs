using TMPro;
using UnityEngine;
using UnityEngine.Audio;

public class MuteButton : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _mixer;
    [SerializeField] private TMP_Text _text;

    private float _enableVolume = 0;
    private float _disableVolume = -80;
    private string _enabledName = "Выкл. звук";
    private string _disabledName = "Вкл. звук";

    public void ToggleSound() =>
        _mixer.audioMixer.SetFloat(_mixer.name, GetValue());

    private float GetValue()
    {
        _mixer.audioMixer.GetFloat(_mixer.name, out float value);

        if (value == _enableVolume)
        {
            _text.text = _enabledName;
            return _disableVolume;
        }
        else
        {
            _text.text = _disabledName;
            return _enableVolume;
        }
    }
}

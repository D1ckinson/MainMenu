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

    private float SoundValue
    {
        get
        {
            _mixer.audioMixer.GetFloat(_mixer.name, out float value);

            return value;
        }
    }

    private void Awake() =>
        SetText();

    public void ToggleSound()
    {
        _mixer.audioMixer.SetFloat(_mixer.name, GetValue());

        SetText();
    }

    private float GetValue() =>
        SoundValue == _enableVolume ? _disableVolume : _enableVolume;

    private void SetText() =>
        _text.text = SoundValue == _enableVolume ? _enabledName : _disabledName;
}

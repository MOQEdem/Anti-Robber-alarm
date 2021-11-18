using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(Animator))]

public class Alarm : MonoBehaviour
{
    private AudioSource _audioSourse;
    private Animator _animator;

    private void Start()
    {
        _audioSourse = GetComponent<AudioSource>();
        _audioSourse.volume = 0f;
        _animator = GetComponent<Animator>();
    }

    public void ActivateAlarm()
    {
        _animator.SetBool(AnimatorAlarm.Params.IsAlarmOn, true);
        StartCoroutine(VolumeChanger(1f));
    }

    public void DeactivateAlarm()
    {
        _animator.SetBool(AnimatorAlarm.Params.IsAlarmOn, false);
        StartCoroutine(VolumeChanger(0f));
    }

    private IEnumerator VolumeChanger(float targetVolume)
    {
        float stepOfChange = 0.00015f;

        while (_audioSourse.volume != targetVolume)
        {
            _audioSourse.volume = Mathf.MoveTowards(_audioSourse.volume, targetVolume, stepOfChange);
            yield return null;
        }
    }
}

public static class AnimatorAlarm
{
    public static class Params
    {
        public const string IsAlarmOn = nameof(IsAlarmOn);
    }
}

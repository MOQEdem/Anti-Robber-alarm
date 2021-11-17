using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alarm : MonoBehaviour
{
    private AudioSource _audioSourse;
    private Animator _animator;
    private bool _isAlarmOn;

    private void Start()
    {
        _audioSourse = GetComponent<AudioSource>();
        _audioSourse.volume = 0f;
        _animator = GetComponent<Animator>();
        _isAlarmOn = false;
    }

    private void Update()
    {
        if (_isAlarmOn)
        {
            _audioSourse.volume = Mathf.MoveTowards(_audioSourse.volume, 1f, 0.0001f);
        }
        else
        {
            _audioSourse.volume = Mathf.MoveTowards(_audioSourse.volume, 0f, 0.0001f);
        }
    }

    public void ActivateAlarm()
    {
        _isAlarmOn = true;
        _animator.SetBool("IsAlarmOn", true);
    }

    public void DeactivateAlarm()
    {
        _isAlarmOn = false;
        _animator.SetBool("IsAlarmOn", false);
    }
}

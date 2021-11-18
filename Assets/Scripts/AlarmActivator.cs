using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmActivator : MonoBehaviour
{
    [SerializeField] private GameObject _alarm;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Robber>(out Robber Robber))
        {
            if (_alarm.TryGetComponent<Alarm>(out Alarm alarm))
                alarm.ActivateAlarm();
        }
    }
}

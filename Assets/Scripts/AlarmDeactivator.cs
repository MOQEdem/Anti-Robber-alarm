using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmDeactivator : MonoBehaviour
{
    private GameObject _alarm;

    private void Start()
    {
        _alarm = GameObject.FindGameObjectWithTag("Alarm");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Robber>(out Robber Robber))
        {
            _alarm.TryGetComponent<Alarm>(out Alarm alarm);
            alarm.DeactivateAlarm();
        }
    }
}

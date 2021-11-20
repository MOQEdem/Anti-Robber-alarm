using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmDeactivator : MonoBehaviour
{
    [SerializeField] private Alarm _alarm;

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Robber>(out Robber Robber))
        {
            if (_alarm.TryGetComponent<Alarm>(out Alarm alarm))
                alarm.DeactivateAlarm();
        }
    }
}

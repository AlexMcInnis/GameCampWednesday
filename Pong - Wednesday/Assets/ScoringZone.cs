using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScoringZone : MonoBehaviour
{
    public EventTrigger.TriggerEvent score;

    private void OnCollisionEnter2D(Collision2D coll)
    {
        BallMovement ball = coll.gameObject.GetComponent<BallMovement>();
        
        if(ball != null)
        {
            BaseEventData eventData = new BaseEventData(EventSystem.current);
            score.Invoke(eventData);
        }
    }
}

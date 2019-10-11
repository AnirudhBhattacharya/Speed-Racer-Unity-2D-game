using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCountDown : MonoBehaviour
{
    private GameManager GMS;

    // Function to indicate when the Countdown is completed
    public void SetCountDownNow()
    {
        GMS = GameObject.Find("GameManager").GetComponent<GameManager>();
        GMS.countDownDone = true;
        Destroy(gameObject);
    }
}

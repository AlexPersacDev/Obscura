using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockPuzzle : MonoBehaviour
{
    //-- set start time 00:00
    public int minutes = 0;
    public int hour = 0;
    public int seconds = 0;
   // public bool realTime = true;

    public GameObject pointerSeconds;
    public GameObject pointerMinutes;
    public GameObject pointerHours;

    //-- time speed factor
    public float clockSpeed = 1.0f;     // 1.0f = realtime, < 1.0f = slower, > 1.0f = faster

    //-- internal vars
    float msecs = 0;

    float rotationHours;
    float rotationMinutes;
    float rotationSeconds;
    [SerializeField] GameManager gM;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //-- calculate time
        msecs += Time.deltaTime * clockSpeed;
        if (msecs >= 1.0f)
        {
            msecs -= 1.0f;
            seconds++;
            if (seconds >= 60)
            {
                seconds = 0;
                minutes++;
                if (minutes > 60)
                {
                    minutes = 0;
                    hour++;
                    if (hour >= 24)
                        hour = 0;
                }
            }
        }
        SetRealTime();
        IsOnTime();
        //-- calculate pointer angles
        rotationSeconds = (360.0f / 60.0f) * seconds;
        rotationMinutes = (360.0f / 60.0f) * minutes;
        rotationHours = ((360.0f / 12.0f) * hour) + ((360.0f / (60.0f * 12.0f)) * minutes);

        //-- draw pointers
        pointerSeconds.transform.localEulerAngles = new Vector3(0.0f, 0.0f, rotationSeconds);
        pointerMinutes.transform.localEulerAngles = new Vector3(0.0f, 0.0f, rotationMinutes);
        pointerHours.transform.localEulerAngles = new Vector3(0.0f, 0.0f, rotationHours);
    }

    public void SetRealTime()
    {
        hour = System.DateTime.Now.Hour;
        minutes = System.DateTime.Now.Minute;
        seconds = System.DateTime.Now.Second;
    }
    public void IsOnTime()
    {
        if ((rotationHours >= 375 && rotationHours <= 389.5f) && (rotationMinutes >= 180 && rotationMinutes <= 354))
        {
            gM.ClockOnTime();
        }
    }
}

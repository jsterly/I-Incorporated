using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventActionTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void makeAction()
    {
        if (Calendar.GetCurrentDayIndex() == Calendar.DayOfEvent)
        {
            Calendar.IncreaseSignificantActions(2);
            if(DayChanger.summary_messages[0] == "")
            {
                DayChanger.summary_messages[0] = "went to the Networking Event. It took all day.";
            }
        }
    }
}

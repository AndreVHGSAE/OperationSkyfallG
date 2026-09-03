using System;
using UnityEngine;
using UnityEngine.Events;



public class Timer : MonoBehaviour
{
    UpdateUI uiScript;

    [Tooltip("la duración máxima del timer")]
    public float maxTime = 100;

	[Tooltip("Los segundos que activan oleadas de enemigos")]
	public TimerEvent[] timerEvents;



    //tiempo actual del timer
    [SerializeField]
    private float currentTime;


    void Start()
    {
        currentTime = maxTime;
        uiScript = GameObject.Find("Canvas").GetComponent<UpdateUI>();
        uiScript.AddTime(currentTime);
    }

    // Update is called once per frame
    void Update()
    {
        Cowntdown();
        if(currentTime <= 0)
        Time.timeScale = 0;
    }

    private void Cowntdown()
    {
        currentTime -= Time.deltaTime;
        uiScript.AddTime(currentTime);
        for (int i = 0; i < timerEvents.Length; i++)
        {
            timerEvents[i].CheckTimer(currentTime);

		}
    }
}

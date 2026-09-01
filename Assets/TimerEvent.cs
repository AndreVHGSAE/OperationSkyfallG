using UnityEngine;
using UnityEngine.Events;


[System.Serializable] //anotación para que unity la reconozca como un parámetro del inspector
public class TimerEvent
{
	public float eventSeconds;
	public UnityEvent eventToCall;
	private bool called = false;

	public void CheckTimer(float timerSeconds)
	{
		if(timerSeconds <= eventSeconds && called == false)
		{
			eventToCall.Invoke();
			called = true;
		}
	}
}


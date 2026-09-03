using System.Collections;
using UnityEngine;

public class PowerupFast : PowerupBase
{
	[SerializeField]
	private int duration = 5;

	private float maxTimeS = 0.1f;

	//override es para poder añadir lógica extra a la función del padre
	protected override void PowerupEffect(GameObject playerGameObject)
	{
		PlayerScript player = playerGameObject.GetComponent<PlayerScript>();
		player.IncreaseFireRate(maxTimeS, duration);
	}

}

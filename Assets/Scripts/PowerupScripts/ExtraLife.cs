using UnityEngine;

public class ExtraLife : PowerupBase
{
    [SerializeField]
    private int lifes = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

	protected override void PowerupEffect(GameObject playerGameObject)
	{
		base.PowerupEffect(playerGameObject);
		playerGameObject.GetComponent<PlayerScript>().AddExtraLifes(lifes);
	}
}

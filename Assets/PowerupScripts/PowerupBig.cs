using UnityEngine;

public class PowerupBig : PowerupBase
{
    [SerializeField]
    private int duration = 5;
    private bool BigActivated = true;

    protected override void PowerupEffect(GameObject playerGameObject)
    {
        PlayerScript player = playerGameObject.GetComponent<PlayerScript>();
        player.BigShots(BigActivated, duration);
    }
}

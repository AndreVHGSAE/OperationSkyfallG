using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource explosionSource, powerupSource;

    public static SoundManager instance;

	private void Awake()
	{
        instance = this;
	}

	public void PlaySfx(ESoundTypes soundType)
    {
        switch (soundType)
        {
            case ESoundTypes.Explosion:
                explosionSource.Play();
                //
                //
                //
                break;

            case ESoundTypes.Powerup:
                powerupSource.Play();
                break;
		}
	}
}

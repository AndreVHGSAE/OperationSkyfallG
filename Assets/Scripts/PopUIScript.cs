using NUnit.Framework;
using UnityEngine;

public class PopUIScript : MonoBehaviour
{
    public float CurrentTime=5;

    // Update is called once per frame
    void Update()
    {
        CurrentTime -= Time.deltaTime;
        if(CurrentTime<=0)
        {
            Destroy(this.gameObject);
        }
    }
    
}

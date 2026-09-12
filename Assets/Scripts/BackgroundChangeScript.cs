using UnityEngine;

public class BackgroundChangeScript : MonoBehaviour
{
    public void BackgroundSet()
    {
        transform.localPosition += new Vector3(0, 0, -2);
    }
}

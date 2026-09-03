using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    public float targetPosition;
    public float snapValue;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition += new Vector3(0, -1f * Time.deltaTime, 0);
        if(transform.position.y <= -targetPosition)
        {
            transform.localPosition += new Vector3(0, snapValue*2, 0);
        }
    }
}

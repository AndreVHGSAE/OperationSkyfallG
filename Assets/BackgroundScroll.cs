using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition += new Vector3(0, -1f * Time.deltaTime, 0);
        if(transform.position.y <= -12)
        {
            transform.localPosition += new Vector3(0, 24, 0);
        }
    }
}

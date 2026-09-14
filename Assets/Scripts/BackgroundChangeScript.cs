using DG.Tweening;
using UnityEngine;

public class BackgroundChangeScript : MonoBehaviour
{
    public void BackgroundSet()
    {
        transform.localPosition += new Vector3(0, 0, -2);
        //GetComponent<SpriteRenderer>().DOColor(new Color(1,1,1,1), 1).From();
    }
}

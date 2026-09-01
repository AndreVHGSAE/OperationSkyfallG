using UnityEngine;

public class HomingBulletScript : MonoBehaviour
{
    GameObject player;
    UpdateUI uiScript;

    float currentTime;
    public float maxTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("Player");
        uiScript = GameObject.Find("Canvas").GetComponent<UpdateUI>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, 1f * Time.deltaTime);
        Vector3 direction = player.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);

        if (this.gameObject.activeInHierarchy)
        {
            currentTime += Time.deltaTime;
            if (currentTime > maxTime)
            {
                gameObject.SetActive(false);
                currentTime = 0;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet" || collision.tag == "BigBullet")
        {
            if (collision.tag == "Bullet")
            {
                collision.gameObject.SetActive(false);
            }
            gameObject.SetActive(false);
        }
    }
}

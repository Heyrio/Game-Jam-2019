using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob : MonoBehaviour
{
    //public MobStats mob_stats;
    public bool inside = false;
    public float staying_time;
    public float wait_time = 0;
    public int age;
    public int worth;
    public string type;
    public string not_like_type;
    private Rigidbody2D rb;

    void Awake()
    {
        //randomly generate stats
        staying_time = Random.Range(1, 24) * 4;
        age = Random.Range(15, 80);
        worth = Random.Range(0, 50);
        type = Game.getRandomType();
        int likes_age_range_x = Random.Range(15, 80);
        int likes_age_range_y = Random.Range(likes_age_range_x, 80);
        not_like_type = Game.getRandomType();
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (inside)
        {
            staying_time -= Time.deltaTime;
            if (staying_time < 0)
            {
                FindObjectOfType<Game>().removeMob(this);
            }
            wait_time -= Time.deltaTime;
            if(wait_time <= 0f)
            {
                wait_time = Random.Range(1, 3);
                change_velocity();
            }
        }
    }

    public void move_mob(Vector2 pos)
    {
        transform.position = pos;
    }

    public void change_velocity()
    {
        switch(Random.Range(0, 4))
        {
            case 0:
                rb.velocity = new Vector2(0f, 0f);
                break;
            case 1:
                rb.velocity = new Vector2(15f, 0f);
                break;
            case 2:
                rb.velocity = new Vector2(-15f, 0f);
                break;
            case 3:
                rb.velocity = new Vector2(0f, 15f);
                break;
            case 4:
                rb.velocity = new Vector2(0f, -15f);
                break;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        rb.velocity = rb.velocity * -1;
        wait_time = 1f;
    }
}

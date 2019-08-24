using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob : MonoBehaviour
{
    public MobStats mob_stats;
    public Vector2[] positions;
    public bool inside = false;
    public float staying_time;

    void Awake()
    {
        mob_stats = FindObjectOfType<Game>().getRandomMobStats();
        staying_time = Random.Range(mob_stats.staying_time.x, mob_stats.staying_time.y);
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
        }
    }
}

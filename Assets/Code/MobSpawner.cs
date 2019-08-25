using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobSpawner : MonoBehaviour
{
    public float time = 0f;
    public int time_diff = 0;
    public Vector2 time_interval;
    public Mob mob_prefab;
    public Vector2 spawnPosition;
    public MobQueue mob_queue;


    // Start is called before the first frame update
    void Start()
    {
        time_diff = (int)Random.Range(time_interval.x, time_interval.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (mob_queue.mob_queue.Count < 5)
        {
            time += Time.deltaTime;
            if (time > time_diff)
            {
                time = 0f;
                time_diff = (int)Random.Range(time_interval.x, time_interval.y);
                spawnMob();
            }
        }
    }

    public void spawnMob()
    {
        GameObject new_mob = GameObject.Instantiate(mob_prefab.gameObject, spawnPosition, Quaternion.identity);
        mob_queue.mob_queue.Add(new_mob.GetComponent<Mob>());
        if(mob_queue.mob_queue.Count == 1)
        {
            mob_queue.updateCurrent();
        }
    }
}

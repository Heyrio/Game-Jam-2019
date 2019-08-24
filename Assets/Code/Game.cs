using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public int hours = 0;
    private float time = 0f;
    private int time_diff = 7;

    public long money;

    public int mob_max_count = 20;
    public List<Mob> mob_list;

    public static string[] types =
    {
        "drunk",
        "sober",
        "loud",
        "quiet",
        "rich",
        "poor",
        "boring",
        "exciting",
        "clean",
        "dirty"
    };

    public List<MobStats> mob_stats_list;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time > time_diff)
        {
            time = 0;
            hours++;
            charge();
        }
    }

    private void charge()
    {
        foreach(Mob mob in mob_list)
        {
            money += mob.mob_stats.worth;
        }
    }

    public void addMob(Mob mob)
    {
        mob_list.Add(mob);
        mob.inside = true;

        if (checkClash(mob))
        {
            Debug.Log("LOSE");
        }
    }

    public void removeMob(Mob mob)
    {
        mob_list.Remove(mob);
        mob.inside = false;
        Destroy(mob.gameObject);
    }

    public MobStats getRandomMobStats()
    {
        return mob_stats_list[Random.Range(0, mob_stats_list.Count)];
    }

    private bool checkClash(Mob mob)
    {
        return false;
    }
}

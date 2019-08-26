using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Game : MonoBehaviour
{
    public int hours = 0;
    private float time = 0f;
    private int time_diff = 4;

    public TextMeshProUGUI money_text;

    public Vector2 entrance;

    public bool can_accept_more = true;

    public long money = 20;

    public int mob_max_count = 10;
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
            money -= 3;
        }
        money_text.text = "$" + money;
    }

    public void addMob(Mob mob)
    {
        if (checkClash(mob))
        {
            money -= 50;
            mob.inside = false;
            Destroy(mob.gameObject);
        }
        else
        {
            mob_list.Add(mob);
            money += mob.worth;
            mob.transform.position = entrance;
            mob.inside = true;
        }

        can_accept_more = mob_list.Count < mob_max_count;
    }

    public void removeMob(Mob mob)
    {
        mob_list.Remove(mob);
        mob.inside = false;
        Destroy(mob.gameObject);
        can_accept_more = mob_list.Count < mob_max_count;
    }

    public MobStats getRandomMobStats()
    {
        return mob_stats_list[Random.Range(0, mob_stats_list.Count)];
    }

    public static string getRandomType()
    {
        int i= Random.Range(0, types.Length -1);
        return types[i];
    }

    private bool checkClash(Mob r_mob)
    {
        foreach(Mob mob in mob_list)
        {
            if(mob != r_mob)
            {
                if(mob.type == r_mob.not_like_type)
                {
                    return true;
                }
            }
        }
        return false;
    }

    public void addMoney(int amount)
    {
        money += amount;
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public int hours = 0;
    private float time = 0f;
    private int time_diff = 4;

    public bool can_accept_more = true;

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
        money -= 10;
        foreach(Mob mob in mob_list)
        {
            money += mob.worth;
            money -= 10;
        }
    }

    public void addMob(Mob mob)
    {
        mob_list.Add(mob);
        mob.inside = true;

        if (checkClash(mob))
        {
            money -= 500;
            mob.inside = false;
            Destroy(mob.gameObject);
        }
        else
        {
            mob_list.Add(mob);
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

    public static string[] getRandomTypes()
    {
        int amount = Random.Range(1, 4);
        List<string> output = new List<string>(amount);
        int i = 0;
        while(i < amount)
        {
            int s = Random.Range(0, types.Length - 1);
            if (!output.Contains(types[s])){
                output.Add(types[s]);
                i++;
            }
        }
        return output.ToArray();
    }

    private bool checkClash(Mob mob)
    {
        return false;
    }

    public void addMoney(int amount)
    {
        money += amount;
    }

    public static string array_to_string(string[] array)
    {
        string output = "";
        foreach(string s in array)
        {
            output += s + ", ";
        }
        return output;
    }
}

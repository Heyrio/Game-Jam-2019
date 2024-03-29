﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MobQueue : MonoBehaviour
{
    public Mob current_mob;
    public List<Mob> mob_queue;
    public Vector2[] line = new Vector2[10];
    public float choose_timer = 30f;
    public int max_choose_timer = 30;
    public StatsPanel panel;

    public TextMeshProUGUI gametime_text;

    // Start is called before the first frame update
    void Start()
    {
        choose_timer = max_choose_timer;
    }

    // Update is called once per frame
    void Update()
    {
        if(current_mob != null)
        {
            choose_timer -= Time.deltaTime;
            if(choose_timer < 0f)
            {
                denyCurrent();
            }
        }

        for(int i = 0; i < mob_queue.Count; i++)
        {
            mob_queue[i].move_mob(line[i]);
        }

        gametime_text.text = "Countdown: " + choose_timer.ToString("F0");

    }

    public void updateCurrent()
    {
        if (mob_queue.Count > 0)
        {
            //current_mob = mob_queue[mob_queue.Count - 1];
            current_mob = mob_queue[0];
        }
        else
        {
            current_mob = null;
        }
        choose_timer = max_choose_timer;
        panel.mob_to_display = current_mob;
    }

    //important events
    public void acceptCurrent()
    {
        Game manager = FindObjectOfType<Game>();
        if (current_mob != null) {
            if (manager.can_accept_more)
            {
                manager.addMob(current_mob);
                mob_queue.Remove(current_mob);
                choose_timer = max_choose_timer;
                updateCurrent();
            }
            else
            {
                manager.addMoney(-50);
                denyCurrent();
            }
        }
    }

    public void denyCurrent()
    {
        if (current_mob != null)
        {
            mob_queue.Remove(current_mob);
            choose_timer = max_choose_timer;
            Destroy(current_mob.gameObject);
            updateCurrent();
        }
    }
}

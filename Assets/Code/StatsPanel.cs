using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StatsPanel : MonoBehaviour
{
    public TextMeshProUGUI content;
    public Mob mob_to_display;

    private void Awake()
    {
        content = GetComponent<TextMeshProUGUI>();    
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (mob_to_display != null)
        {
            content.text = "Age: " + mob_to_display.age + "\n" +
                           "Pays: " + mob_to_display.worth + " per hour\n" +
                           "Stays for : " + mob_to_display.staying_time + " hours\n" +
                           "Type: " + Game.array_to_string(mob_to_display.type) + "\n" +
                           "Doesn't like: " + Game.array_to_string(mob_to_display.not_like_type);
        }
        else
        {
            content.text = "";
        }
    }
}

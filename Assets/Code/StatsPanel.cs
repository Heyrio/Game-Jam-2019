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
                           "Pays: " + mob_to_display.worth + " to enter\n" +
                           "Stays for : " + mob_to_display.staying_time + " hours\n" +
                           "Type: " + mob_to_display.type + "\n" +
                           "Doesn't like: " + mob_to_display.not_like_type;
        }
        else
        {
            content.text = "";
        }
    }
}

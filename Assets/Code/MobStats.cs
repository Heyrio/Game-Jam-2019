using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MobStats", menuName = "MobStats", order = 1)]
public class MobStats : ScriptableObject
{
    public int age;
    public int worth;
    public string[] type;
    public Vector2 staying_time;
    public Vector2 likes_age_range;
    public string[] not_like_type;
}

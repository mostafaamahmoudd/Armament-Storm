using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    [HideInInspector] public EnemyController ec;
    [SerializeField] private Text text;
    public int killsNum = 0;


    void Update()
    {
        text.text = "Score : " + (killsNum).ToString();
    }
}

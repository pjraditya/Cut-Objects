using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gamemanager : MonoBehaviour
{
    public static Gamemanager instance;
    public int score;
    public int chance;
    public AudioSource audioo;
    public AudioClip knifesound;
    public TextMeshProUGUI scoretxt;
    public TextMeshProUGUI chancetxt;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        score = 0;
        chance = 3;
        audioo = GetComponent<AudioSource>();
    }
   public void UpdateScore()
    {
        score += 10;
        scoretxt.text = "Score:" + score;
    }
    public void LessScore()
    {
        score -= 10;
        scoretxt.text = "Score:" + score;
    }
    public void Chances()
    {
        chance -= 1;
        chancetxt.text = "Chances:" + chance;
    }
    public void playmusic()
    {
        audioo.PlayOneShot(knifesound);
    }
}

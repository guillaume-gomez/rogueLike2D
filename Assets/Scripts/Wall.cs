﻿using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour
{
    public Sprite dmgSprite;
    public int hp = 4;

    private SpriteRenderer spriteRenderer;

    void Awake ()
    {
        spriteRenderer = GetComponent<SpriteRenderer> ();
    }

    //DamageWall is called when the player attacks a wall.
    public void DamageWall (int loss)
    {
        spriteRenderer.sprite = dmgSprite;
        hp -= loss;
        if(hp <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
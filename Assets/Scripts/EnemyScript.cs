﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private EnemyFormation formation; 
    public int scoreValue;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
       formation = GetComponentInParent<EnemyFormation>(); 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "SideBoundary")
        {
            formation.movingSide = false;
            formation.SetDestinationAndMoveDown();
        }
        if (collision.gameObject.tag == "Boundary" || collision.gameObject.tag == "Player")
        {
            gameManager.RestartGame();
        }
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using AsteroidGame.UI;

namespace AsteroidGame.Player
{
    public class PlayerLives : MonoBehaviour
    {
        [SerializeField]
        PlayerData playerData;
        int currentLives;

        void Start()
        {
            currentLives = playerData.PlayerLives;
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            Die();
        }

        void Die()
        {
            --currentLives;

            if (currentLives <= 0)
            {
                GameLoop.instance.EndGame();
            }
            else
            {
                GameLoop.instance.Restart();
            }
        }
    }
}
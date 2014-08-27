﻿using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts.Colliders
{
    public class LevelSelectCollider : MonoBehaviour
    {
        public List<GameObject> levels;

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                var hit = Physics2D.Raycast(ray.origin, ray.direction);

                for (int i = 0; i < levels.Count; i++)
                {
                    if (hit.collider == levels[i].collider2D)
                    {
                        Application.LoadLevel(i + 1);
                    }
                }
            }
            else if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SceneController : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    private GameObject enemy;

    void Update()
    {

        if (enemy == null)
        {
            enemy = Instantiate(enemyPrefab) as GameObject;

            enemy.transform.position = new Vector3(0, 1, 0);

            float angle = Random.Range(0, 360);
            enemy.transform.Rotate(0, angle, 0);

            float scale = Random.Range(0.5f, 2.0f);
            enemy.transform.localScale = new Vector3(1, scale, 1);

            // Get the Renderer component attached to the enemy
            Renderer enemyRenderer = enemy.GetComponent<Renderer>();

            // Generate a random color
            Color randomColor = new Color(Random.value, Random.value, Random.value);

            // Set the enemy renderer's color to the random color
            enemyRenderer.material.color = randomColor;
        }
    }
}

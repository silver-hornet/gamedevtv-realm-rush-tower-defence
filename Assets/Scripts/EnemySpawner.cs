using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawner : MonoBehaviour
{
    [Range(0.1f, 120f)][SerializeField] float secondsBetweenSpawns = 4f;
    [SerializeField] EnemyMovement enemiesPrefab; // this ensures that we can only drag in a prefab that has the EnemyMovement script on it, rather than just dragging in any game object accidentally
    [SerializeField] Transform enemyParentTransform;

    int score;
    [SerializeField] Text spawnedEnemies;

    // Start is called before the first frame update
    void Start()
    {
        spawnedEnemies.text = score.ToString();
        StartCoroutine(RepeatedlySpawnEnemies());
    }

    IEnumerator RepeatedlySpawnEnemies()
    {
        while (true) // forever
        {
            AddScore();
            var newEnemy = Instantiate(enemiesPrefab, transform.position, Quaternion.identity);
            newEnemy.transform.parent = enemyParentTransform;
            yield return new WaitForSeconds(secondsBetweenSpawns);
        }
    }

    void AddScore()
    {
        score++;
        spawnedEnemies.text = score.ToString();
    }
}

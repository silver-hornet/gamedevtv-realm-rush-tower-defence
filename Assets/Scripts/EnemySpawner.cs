using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Range(0.1f, 120f)][SerializeField] float secondsBetweenSpawns = 4f;
    [SerializeField] EnemyMovement enemiesPrefab; // this ensures that we can only drag in a prefab that has the EnemyMovement script on it, rather than just dragging in any game object accidentally

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RepeatedlySpawnEnemies());
    }

    IEnumerator RepeatedlySpawnEnemies()
    {
        while (true) // forever
        {
            Instantiate(enemiesPrefab, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(secondsBetweenSpawns);
        }
    }
}

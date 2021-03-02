using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerFactory : MonoBehaviour
{
    [SerializeField] int towerLimit = 5;
    [SerializeField] Tower towerPrefab;
    int numTowers;

    public void AddTower(Waypoint baseWaypoint)
    {
        var towers = FindObjectsOfType<Tower>();
        numTowers = towers.Length;

        if (numTowers < towerLimit)
        {
            InstantiateNewTower(baseWaypoint);
        }
        else
            MoveExistingTower();
    }

    static void MoveExistingTower()
    {
        print("Can't play any more towers");
        // todo actually move!
    }

    void InstantiateNewTower(Waypoint baseWaypoint)
    {
        Instantiate(towerPrefab, baseWaypoint.transform.position, Quaternion.identity);
        baseWaypoint.isPlaceable = false;
        numTowers++;
    }
}

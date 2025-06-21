using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public GameObject[] obstacle;
    public Transform enemyHolder;

    GameObject instantiatedObstacle;

   
    public void SpawnObstacles()
    {

        if (instantiatedObstacle != null)
        {
            Destroy(instantiatedObstacle);
        }

        var randompick = Random.Range(0,obstacle.Length);
        instantiatedObstacle = Instantiate(obstacle[randompick],enemyHolder);
        var zPosition = Random.Range(5f, 9f);
        var xPostion = Random.Range(-1f, 1f);
        instantiatedObstacle.transform.position += new Vector3(xPostion, 0.5f, zPosition);
    }
}

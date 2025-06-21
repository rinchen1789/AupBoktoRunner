using System.Collections.Generic;
using UnityEngine;

public class EndlessPathManager: MonoBehaviour
{
    [SerializeField] private List<GameObject> path = new List<GameObject>();
    [SerializeField] private GameObject spawnPoint;
    private int nextIndex;
    private int currentIndex;
    private GameObject runningPath;


    [SerializeField] private PlayerMovement playerMovement;


    

    void Update()
    {
        if (runningPath == playerMovement.currentPath)
        {
            return;
        }
        PathChanger();
  }

  public void PathChanger()
    {
        do
        {
            nextIndex = Random.Range(0, path.Count);
        } while(nextIndex == currentIndex);
        Debug.Log(nextIndex);

        currentIndex = nextIndex;

        path[nextIndex].transform.position = spawnPoint.transform.position;

        runningPath = playerMovement.currentPath;
        spawnPoint = path[nextIndex].transform.GetChild(1).gameObject;

    }

}
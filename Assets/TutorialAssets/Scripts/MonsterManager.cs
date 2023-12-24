using System.Collections.Generic;
using UnityEngine;

public class MonsterManager : MonoBehaviour
{
    [SerializeField] GameObject[] monsters;
    [SerializeField] Transform spawnPoint;
    [SerializeField] float numberOfMonsters = 8f;
    [SerializeField] List<GameObject> spawnedMonsters;
    // Start is called before the first frame update
    void Start()
    {
        MonsterSpawner();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void MonsterSpawner()
    {
        for (int i = 0; i < numberOfMonsters; i++)
        {
            GameObject randomMonster = Instantiate(monsters[Random.Range(0, monsters.Length)], spawnPoint);
            spawnedMonsters.Add(randomMonster);
        }
    }
}

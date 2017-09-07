using UnityEngine;

public class test : MonoBehaviour
{
    public GameObject prefab;

    public GameObject wall;

    private Transform[] SpawnPointersArray;

    public void Start()
    {
        InitiateSpawnPontsArray();
        LaunchEggs();
    }

    public void LaunchEggs()
    {
        GameObject t = Instantiate(
            prefab,
            SpawnPointersArray[Random.Range(0, SpawnPointersArray.Length)].position,
            Quaternion.identity,
            MotherOfEggsScript._instance.transform
            );
        //SpawnPointersArray[Random.Range(0, SpawnPointersArray.Length)]
    }



    void InitiateSpawnPontsArray()
    {
        SpawnPointersArray = new Transform[wall.transform.childCount];
        for (int i = 0; i < SpawnPointersArray.Length; i++)
        {
            SpawnPointersArray[i] = wall.transform.GetChild(i);
        }
    }

}
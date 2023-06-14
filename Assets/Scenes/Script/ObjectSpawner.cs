using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject Left_EnemyPrefab;

    void Awake()
    {
        Instantiate(Left_EnemyPrefab);
    }
    void Start()
    {
        InvokeRepeating("Awake", 2 , 2);
    }
}

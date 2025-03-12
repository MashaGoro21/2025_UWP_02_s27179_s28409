using UnityEngine;
public class EnemyManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    void Update()
    {
        foreach (var enemy in FindObjectsOfType<Enemy>())
        {
            enemy.transform.position += new Vector3(0, 0, 1) * Time.deltaTime;
        }
    }
}
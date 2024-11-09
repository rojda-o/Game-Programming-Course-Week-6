using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

public class SpawnManager_sc : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;

    [SerializeField]
    GameObject tripleShotBonusPrefab;
    public GameObject enemyContainer;
    bool stopSpawning = false;

    IEnumerator SpawnEnemyRoutine()
    {
        while(stopSpawning == false)
        {
            Vector3 position = new Vector3(Random.Range(-9.4f, 9.4f), 7.4f,0);  //rastgele bir pozisyon değeri alıyor
            GameObject new_enemy = Instantiate(enemyPrefab, position, Quaternion.identity);  //pozisyon bilgisini kullanarak enemyPrefab'den new_enemy nesnesi üretiliyor
            new_enemy.transform.parent = enemyContainer.transform; //new_enemy nesnesi, enemyContainer'ın altına atanır

            yield return new WaitForSeconds(5.0f); //Coroutine 5 saniye boyunca duraklatılır ve sonra kaldığı yerden devam eder.
        }
    }

    IEnumerator SpawnBonusRoutine()
    {
        while (stopSpawning == false)
        {
            Vector3 position = new Vector3(Random.Range(-9.4f, 9.4f), 7.4f,0);  
            Instantiate(tripleShotBonusPrefab, position, Quaternion.identity);  
            yield return new WaitForSeconds(3.0f); 

        }
    }

    public void OnPlayerDeath()
    {
        stopSpawning = true;
    }


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemyRoutine()); //Couroutine'leri çağırmak için bir fonksiyon
        StartCoroutine(SpawnBonusRoutine());
    }

    private GameObject GameObject(string v)
    {
        throw new System.NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}



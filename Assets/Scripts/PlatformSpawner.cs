using System.Collections;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platform;
    float respawnTime = 1f;
    Vector2 ScreenB;

    float lastPlatformY; // Son spawn edilen platformun Y y�ksekli�i

    float minYDistance = 1.5f;  // Minimum dikey mesafe
    float maxYDistance = 3f;    // Maksimum z�planabilir mesafe

    void Start()
    {
        ScreenB = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

        // �lk platformun Y konumu, ekran�n 0.8 y�ksekli�i
        lastPlatformY = ScreenB.y * 0.8f;

        StartCoroutine(platformWave());
    }

    void Update()
    {
        ScreenB = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    void Spawn()
    {
        float newX = Random.Range(-ScreenB.x + 0.5f, ScreenB.x - 0.5f);
        float newY = lastPlatformY + Random.Range(minYDistance, maxYDistance);

        Vector3 spawnPos = new Vector3(newX, newY, 0);
        Instantiate(platform, spawnPos, Quaternion.identity);

        lastPlatformY = newY; // Bir sonraki i�in g�ncelle
    }

    IEnumerator platformWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            Spawn();
        }
    }
}

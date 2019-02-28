using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieTarget : MonoBehaviour
{

    private int health;
    public GameObject[] healthImages;
    public GameObject destroyedTargetPrefab;

    private void Start()
    {
        health = healthImages.Length;
        health = healthImages.Length;
    }

    public void TakeDamage()
    {
        health--;
        healthImages[health].SetActive(false);
        if (health <= 0)
        {
            Transform currentTransform = transform;
            GameObject zo = Instantiate(destroyedTargetPrefab, currentTransform.position, currentTransform.rotation);
            Destroy(gameObject);
            Destroy(zo, 3.0f);
        }
    }
}

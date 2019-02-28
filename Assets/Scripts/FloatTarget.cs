using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FloatTarget : MonoBehaviour {

    private int health;
    public GameObject[] healthImages;
    public GameObject destroyedTargetPrefab;

    private void Start()
    {
        health = healthImages.Length;
    }

    public void TakeDamage()
    {
        health--;
        healthImages[health].SetActive(false);
        if (health <= 0)
        {
            Transform currentTransform = transform;
            GameObject go = Instantiate(destroyedTargetPrefab, currentTransform.position, currentTransform.rotation);
            Destroy(gameObject);
            Destroy(go, 5.0f);
        }
    }
}

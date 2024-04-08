using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{

    [SerializeField]
    private SpriteRenderer background;

    public float spawnInterval = 10f; // Time in seconds between each spawn.
    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            background.color = Color.red;
            WaitAndExecute();
            SceneReloader.ReloadCurrentScene();
        }
    }

    IEnumerator WaitAndExecute()
    {
        yield return new WaitForSeconds(3);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            background.color = Color.red;
            WaitAndExecute();
            SceneReloader.ReloadCurrentScene();
        }
    }
}

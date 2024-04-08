using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{

    [SerializeField]
    private SpriteRenderer background;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject); // Destroy the object

            GameObject targetObject = GameObject.Find("Background");
            SpriteRenderer spriteRenderer = targetObject.GetComponent<SpriteRenderer>();
            spriteRenderer.color = Color.green;
            WaitAndExecute();
            SceneReloader.ReloadCurrentScene();
        }
    }

    IEnumerator WaitAndExecute()
    {
        yield return new WaitForSeconds(3);
    }
}
